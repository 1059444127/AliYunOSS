using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliyun.OpenServices;
using Aliyun.OpenServices.OpenStorageService;
using System.IO;
using System.Threading;

namespace WinApp
{
    public partial class Form1 : Form
    {

        static string endPoint = "http://oss-cn-beijing.aliyuncs.com";
        static string accessKeyID = "yNwTNYUewtVW4hFl";
        static string accessKeySecret = "sQx9gDGpM9Tep76CuSAafYafQQxe8k";
        static string bucketName = "aliyunoss001";
        static string key = "";

        BackgroundWorker bw = new BackgroundWorker();
        private ManualResetEvent manualReset = new ManualResetEvent(true);
        delegate void SetTextCallback(string text);

        static string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addListItem(openFileDialog1.FileName);
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        { // 这被工作线程调用
            mutiPartUpload();
        }

        public void mutiPartUpload()
        {
            for (; ; )
            {
                getListItemName();

                if (string.IsNullOrEmpty(path))
                {
                    break;
                }

                key = Guid.NewGuid().ToString() + path.Substring(path.LastIndexOf('.'));

                OssClient ossClient = new OssClient(endPoint, accessKeyID, accessKeySecret);

                InitiateMultipartUploadRequest initRequest =
                                new InitiateMultipartUploadRequest(bucketName, key);
                InitiateMultipartUploadResult initResult = ossClient.InitiateMultipartUpload(initRequest);


                // 设置每块为 5M ,不允许小于5M
                int partSize = 1024 * 100;

                FileInfo partFile = new FileInfo(path);

                // 计算分块数目 
                int partCount = (int)(partFile.Length / partSize);
                if (partFile.Length % partSize != 0)
                {
                    partCount++;
                }

                // 新建一个List保存每个分块上传后的ETag和PartNumber 
                List<PartETag> partETags = new List<PartETag>();

                for (int i = 0; i < partCount; i++)
                {
                    Bar.Value = (i * 100) / partCount;
                    UploadInfo(Bar.Value.ToString());

                    // 获取文件流 
                    FileStream fis = new FileStream(partFile.FullName, FileMode.Open);

                    // 跳到每个分块的开头 
                    long skipBytes = partSize * i;
                    fis.Position = skipBytes;
                    //fis.skip(skipBytes); 

                    // 计算每个分块的大小 
                    long size = partSize < partFile.Length - skipBytes ?
                            partSize : partFile.Length - skipBytes;

                    // 创建UploadPartRequest，上传分块 
                    UploadPartRequest uploadPartRequest = new UploadPartRequest(bucketName, key, initResult.UploadId);
                    uploadPartRequest.InputStream = fis;
                    uploadPartRequest.PartSize = size;
                    uploadPartRequest.PartNumber = (i + 1);
                    UploadPartResult uploadPartResult = ossClient.UploadPart(uploadPartRequest);

                    // 将返回的PartETag保存到List中。 
                    partETags.Add(uploadPartResult.PartETag);

                    // 关闭文件 
                    fis.Close();

                    manualReset.WaitOne();//如果ManualResetEvent的初始化为终止状态（true），那么该方法将一直工作，直到收到Reset信号。然后，直到收到Set信号，就继续工作。
                }

                CompleteMultipartUploadRequest completeReq = new CompleteMultipartUploadRequest(bucketName, key, initResult.UploadId);
                foreach (PartETag partETag in partETags)
                {
                    completeReq.PartETags.Add(partETag);
                }
                //  红色标注的是与JAVA的SDK有区别的地方 

                //完成分块上传 
                CompleteMultipartUploadResult completeResult = ossClient.CompleteMultipartUpload(completeReq);

                Bar.Value = 100;
                UploadInfo(Bar.Value.ToString());

                // 返回最终文件的MD5，用于用户进行校验 
                //Console.WriteLine(completeResult.ETag);

                setListItemValue();
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            if (btPause.Text == "暂停")
            {
                manualReset.Reset();//暂停当前线程的工作，发信号给waitOne方法，阻塞
                btPause.Text = "继续";
            }
            else
            {
                manualReset.Set();//继续某个线程的工作
                btPause.Text = "暂停";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            bw.CancelAsync();
        }

        void UploadInfo(string text)
        {
            if ("100" == text)
            {
                SetText("'" + path + "'文件，已完成");
            }
            else
            {
                SetText("'" + path + "'文件，已上传" + text + "%");
            }
        }

        // 此方法演示一个对windows窗体控件作线程安全调用的模式
        // 如果调用线程和创建TextBox控件的线程不同，这个方法创建
        // 代理SetTextCallback并且自己通过Invoke方法异步调用它
        // 如果相同则直接设置Text属性
        private void SetText(string text)
        {
            // InvokeRequired需要比较调用线程ID和创建线程ID
            // 如果它们不相同则返回true
            if (this.lbInfo.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbInfo.Text = text;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += bw_DoWork;
            bw.RunWorkerAsync("");
        }

        void getListItemName()
        {
            path = "";
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                ListItem item = listBox.Items[i] as ListItem;
                if (item.Value == "0")
                {
                    path = item.Name;
                    break;
                }
            }
        }

        void setListItemValue()
        {
            List<ListItem> list = new List<ListItem>();
            bool getValue = false;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                ListItem item = listBox.Items[i] as ListItem;
                if (item.Value == "0" && !getValue)
                {
                    getValue = true;
                    item.Value = "1";
                    item.Name += "[完成]";
                }
                list.Add(item);
            }

            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Value";
            listBox.DataSource = list;
        }

        void addListItem(string Name)
        {
            List<ListItem> list = new List<ListItem>();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                ListItem item = listBox.Items[i] as ListItem;
                list.Add(item);
            }

            list.Add(new ListItem(Name, "0"));

            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Value";
            listBox.DataSource = list;
        }
    }

    public class ListItem
    {
        public ListItem(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
}

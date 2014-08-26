namespace OSSClientLib
{
    partial class OCB
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码
        private void InitializeComponent()
        {
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.btPause = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpLoad.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpLoad.Location = new System.Drawing.Point(27, 228);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(60, 25);
            this.btnUpLoad.TabIndex = 0;
            this.btnUpLoad.Text = "浏览...";
            this.btnUpLoad.UseVisualStyleBackColor = false;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Bar.Location = new System.Drawing.Point(68, 25);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(376, 19);
            this.Bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Bar.TabIndex = 1;
            // 
            // btPause
            // 
            this.btPause.BackColor = System.Drawing.SystemColors.Control;
            this.btPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPause.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPause.Location = new System.Drawing.Point(257, 228);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(60, 25);
            this.btPause.TabIndex = 3;
            this.btPause.Text = "暂停";
            this.btPause.UseVisualStyleBackColor = false;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCancel.Location = new System.Drawing.Point(384, 228);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(60, 25);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbInfo.Location = new System.Drawing.Point(34, 54);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 11);
            this.lbInfo.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(68, 78);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(376, 134);
            this.listBox.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(134, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 25);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "上传";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 11);
            this.label1.TabIndex = 8;
            this.label1.Text = "进度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 11);
            this.label2.TabIndex = 9;
            this.label2.Text = "源文件:";
            // 
            // OCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.btnUpLoad);
            this.Name = "OCB";
            this.Size = new System.Drawing.Size(477, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar Bar;
        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


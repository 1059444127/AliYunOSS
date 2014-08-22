namespace WinApp
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
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
            this.SuspendLayout();
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpLoad.Location = new System.Drawing.Point(12, 319);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(60, 25);
            this.btnUpLoad.TabIndex = 0;
            this.btnUpLoad.Text = "上传";
            this.btnUpLoad.UseVisualStyleBackColor = false;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(12, 15);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(417, 27);
            this.Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Bar.TabIndex = 1;
            // 
            // btPause
            // 
            this.btPause.BackColor = System.Drawing.SystemColors.Control;
            this.btPause.Location = new System.Drawing.Point(144, 319);
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
            this.btCancel.Location = new System.Drawing.Point(210, 319);
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
            this.lbInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbInfo.Location = new System.Drawing.Point(14, 54);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 12);
            this.lbInfo.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(12, 76);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(417, 232);
            this.listBox.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(78, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 25);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 354);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btPause);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.btnUpLoad);
            this.Name = "Form1";
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
    }
}


namespace UI
{
    partial class MainForm
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
            this.BtnFile = new System.Windows.Forms.Button();
            this.Labe = new System.Windows.Forms.Label();
            this.BtnS = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFile
            // 
            this.BtnFile.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFile.Location = new System.Drawing.Point(166, 247);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(97, 23);
            this.BtnFile.TabIndex = 3;
            this.BtnFile.Text = "选择";
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // Labe
            // 
            this.Labe.AutoSize = true;
            this.Labe.BackColor = System.Drawing.Color.Transparent;
            this.Labe.Font = new System.Drawing.Font("华文中宋", 23.77982F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Labe.Location = new System.Drawing.Point(99, 105);
            this.Labe.Name = "Labe";
            this.Labe.Size = new System.Drawing.Size(0, 41);
            this.Labe.TabIndex = 4;
            this.Labe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnS
            // 
            this.BtnS.BackColor = System.Drawing.SystemColors.Control;
            this.BtnS.Location = new System.Drawing.Point(30, 247);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(105, 23);
            this.BtnS.TabIndex = 5;
            this.BtnS.Text = "开始";
            this.BtnS.UseVisualStyleBackColor = false;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(30, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 19);
            this.progressBar1.TabIndex = 6;
            // 
            // tbFilePath
            // 
            this.tbFilePath.CausesValidation = false;
            this.tbFilePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbFilePath.Enabled = false;
            this.tbFilePath.Location = new System.Drawing.Point(19, 218);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(256, 23);
            this.tbFilePath.TabIndex = 7;
            this.tbFilePath.Text = "未选择文件";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.imgbin_borders_and_frames_frame_decorative_arts_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 388);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.Labe);
            this.Controls.Add(this.BtnFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CYRoll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Label Labe;
        private System.Windows.Forms.Button BtnS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbFilePath;
    }
}


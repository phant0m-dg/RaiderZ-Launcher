namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartGameButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.imageLabel = new System.Windows.Forms.PictureBox();
            this.textBox_Username = new ZBobb.AlphaBlendTextBox();
            this.textBox_Password = new ZBobb.AlphaBlendTextBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.downloadUpdates = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.StartGameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Location = new System.Drawing.Point(382, 328);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(125, 28);
            this.StartGameButton.TabIndex = 7;
            this.StartGameButton.TabStop = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGamebtn_Click);
            this.StartGameButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartGamebtn_MouseDown);
            this.StartGameButton.MouseEnter += new System.EventHandler(this.StartGamebtn_MouseEnter);
            this.StartGameButton.MouseLeave += new System.EventHandler(this.StartGamebtn_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(488, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 25);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.Closebtn_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Closebtn_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.Closebtn_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.Closebtn_MouseLeave);
            // 
            // imageLabel
            // 
            this.imageLabel.Location = new System.Drawing.Point(11, 288);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(0, 0);
            this.imageLabel.TabIndex = 9;
            this.imageLabel.TabStop = false;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackAlpha = 0;
            this.textBox_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Username.ForeColor = System.Drawing.Color.White;
            this.textBox_Username.Location = new System.Drawing.Point(35, 333);
            this.textBox_Username.MaxLength = 24;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(154, 13);
            this.textBox_Username.TabIndex = 1;
            this.textBox_Username.Text = "Username";
            this.textBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsername_KeyDown);
            this.textBox_Username.MouseEnter += new System.EventHandler(this.tbxUsername_MouseEnter);
            this.textBox_Username.MouseLeave += new System.EventHandler(this.tbxUsername_MouseLeave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackAlpha = 0;
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(208, 333);
            this.textBox_Password.MaxLength = 24;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(154, 13);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            this.textBox_Password.MouseEnter += new System.EventHandler(this.txbPassword_MouseEnter);
            this.textBox_Password.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(10, 304);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(205, 10);
            this.downloadProgress.TabIndex = 10;
            // 
            // downloadUpdates
            // 
            this.downloadUpdates.WorkerReportsProgress = true;
            this.downloadUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadUpdates_DoWork);
            this.downloadUpdates.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.downloadUpdates_ProgressChanged);
            this.downloadUpdates.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.downloadUpdates_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartGameButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DareRaiderz Patcher";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titelLeiste_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titelLeiste_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.StartGameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartGameButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox imageLabel;
        private ZBobb.AlphaBlendTextBox textBox_Username;
        private ZBobb.AlphaBlendTextBox textBox_Password;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.ComponentModel.BackgroundWorker downloadUpdates;
    }
}


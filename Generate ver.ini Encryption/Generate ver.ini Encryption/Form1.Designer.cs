namespace GetFileChecksum
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
            this.GenerateChecksum = new System.Windows.Forms.Button();
            this.BrowseFileTextBox = new System.Windows.Forms.TextBox();
            this.BrowseFile = new System.Windows.Forms.Button();
            this.SelectFileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Checksum = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GenerateChecksum
            // 
            this.GenerateChecksum.Location = new System.Drawing.Point(12, 50);
            this.GenerateChecksum.Name = "GenerateChecksum";
            this.GenerateChecksum.Size = new System.Drawing.Size(260, 25);
            this.GenerateChecksum.TabIndex = 1;
            this.GenerateChecksum.Text = "Encrypt File";
            this.GenerateChecksum.UseVisualStyleBackColor = true;
            this.GenerateChecksum.Click += new System.EventHandler(this.GenerateChecksum_Click);
            // 
            // BrowseFileTextBox
            // 
            this.BrowseFileTextBox.Enabled = false;
            this.BrowseFileTextBox.Location = new System.Drawing.Point(12, 24);
            this.BrowseFileTextBox.Name = "BrowseFileTextBox";
            this.BrowseFileTextBox.Size = new System.Drawing.Size(179, 20);
            this.BrowseFileTextBox.TabIndex = 2;
            // 
            // BrowseFile
            // 
            this.BrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFile.Location = new System.Drawing.Point(197, 24);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(75, 20);
            this.BrowseFile.TabIndex = 3;
            this.BrowseFile.Text = "Browse";
            this.BrowseFile.UseVisualStyleBackColor = true;
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // SelectFileLabel
            // 
            this.SelectFileLabel.AutoSize = true;
            this.SelectFileLabel.Location = new System.Drawing.Point(9, 8);
            this.SelectFileLabel.Name = "SelectFileLabel";
            this.SelectFileLabel.Size = new System.Drawing.Size(56, 13);
            this.SelectFileLabel.TabIndex = 4;
            this.SelectFileLabel.Text = "Select File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phant0m";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Encryption to File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(260, 25);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MD5 Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Crypted Text";
            // 
            // Checksum
            // 
            this.Checksum.Location = new System.Drawing.Point(12, 154);
            this.Checksum.Multiline = false;
            this.Checksum.Name = "Checksum";
            this.Checksum.ReadOnly = true;
            this.Checksum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Checksum.Size = new System.Drawing.Size(260, 50);
            this.Checksum.TabIndex = 0;
            this.Checksum.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFileLabel);
            this.Controls.Add(this.BrowseFile);
            this.Controls.Add(this.BrowseFileTextBox);
            this.Controls.Add(this.GenerateChecksum);
            this.Controls.Add(this.Checksum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateChecksum;
        private System.Windows.Forms.TextBox BrowseFileTextBox;
        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.Label SelectFileLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Checksum;
    }
}


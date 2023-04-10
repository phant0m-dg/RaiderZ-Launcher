namespace GetMD5Hash
{
    partial class GetMD5Hash
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
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.GetHash = new System.Windows.Forms.Button();
            this.HashBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Credits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(119, 25);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Location = new System.Drawing.Point(12, 25);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 0;
            // 
            // GetHash
            // 
            this.GetHash.Location = new System.Drawing.Point(12, 51);
            this.GetHash.Name = "GetHash";
            this.GetHash.Size = new System.Drawing.Size(207, 38);
            this.GetHash.TabIndex = 2;
            this.GetHash.Text = "Generate MD5 Hash";
            this.GetHash.UseVisualStyleBackColor = true;
            this.GetHash.Click += new System.EventHandler(this.GetHash_Click);
            // 
            // HashBox
            // 
            this.HashBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HashBox.Location = new System.Drawing.Point(12, 95);
            this.HashBox.Name = "HashBox";
            this.HashBox.Size = new System.Drawing.Size(207, 20);
            this.HashBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Location = new System.Drawing.Point(170, 118);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(49, 13);
            this.Credits.TabIndex = 6;
            this.Credits.Text = "Phant0m";
            // 
            // GetMD5Hash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 134);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HashBox);
            this.Controls.Add(this.GetHash);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetMD5Hash";
            this.Text = "Get MD5 Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button GetHash;
        private System.Windows.Forms.TextBox HashBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Credits;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace GetMD5Hash
{
    public partial class GetMD5Hash : Form
    {
        public GetMD5Hash()
        {
            InitializeComponent();
        }

        private void GetHash_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Cannot generate NULL MD5 hash!" + "\n" + "Please enter the Username and Password.", "Error");
            }
            else
            {
                string Hash = BitConverter.ToString(MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(Password.Text + Username.Text))).Replace("-", string.Empty).ToLower();
                HashBox.Text = Hash;
                Username.Text = "";
                Password.Text = "";
            }
        }
    }
}

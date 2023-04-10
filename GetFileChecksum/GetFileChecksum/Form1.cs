using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GetFileChecksum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileBrowsed = new OpenFileDialog();
            FileBrowsed.Title = "Select a file to create a checksum";
            FileBrowsed.InitialDirectory = @"c:\";
            FileBrowsed.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            FileBrowsed.FilterIndex = 2;
            FileBrowsed.RestoreDirectory = true;
            if (FileBrowsed.ShowDialog() == DialogResult.OK)
            {
                BrowseFileTextBox.Text = FileBrowsed.FileName;
            }
        }

        private void GenerateChecksum_Click(object sender, EventArgs e)
        {
            FileStream FileToSum = new FileStream(BrowseFileTextBox.Text, FileMode.Open, FileAccess.Read);
            string CurrentFileSum = BitConverter.ToString(MD5.Create().ComputeHash(FileToSum)).ToLower().Replace("-", "").Replace("q", "!").Replace("w", "@").Replace("e", "#").Replace("r", "$").Replace("t", "%").Replace("y", "^").Replace("u", "&").Replace("i", "*").Replace("o", "(").Replace("p", ")").Replace("a", "_").Replace("s", "+").Replace("d", "-").Replace("f", "=").Replace("g", "`").Replace("h", "~").Replace("j", "[").Replace("k", "{").Replace("l", "]").Replace("z", "}").Replace("x", ":").Replace("c", "|").Replace("v", "'").Replace("b", ",").Replace("n", "<").Replace("m", "?");
            FileToSum.Close();
            Checksum.Text = CurrentFileSum;
        }
    }
}

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
            FileBrowsed.Title = "Find ver.ini to encrypt it";
            FileBrowsed.InitialDirectory = Directory.GetCurrentDirectory();
            FileBrowsed.Filter = "All files (ver.ini)|ver.ini";
            FileBrowsed.FilterIndex = 2;
            FileBrowsed.RestoreDirectory = true;
            if (FileBrowsed.ShowDialog() == DialogResult.OK)
            {
                BrowseFileTextBox.Text = FileBrowsed.FileName;
            }
        }

        private void GenerateChecksum_Click(object sender, EventArgs e)
        {
            FileStream readVER_INI = new FileStream(BrowseFileTextBox.Text, FileMode.Open, FileAccess.Read);
            string FileVER_INI = Convert.ToString(readVER_INI);
            string plainMD5 = BitConverter.ToString(MD5.Create().ComputeHash(readVER_INI)).ToLower().Replace("-", "");
            string CurrentFileSum = plainMD5.Replace("q", "!").Replace("w", "@").Replace("e", "#").Replace("r", "$").Replace("t", "%").Replace("y", "^").Replace("u", "&").Replace("i", "*").Replace("o", "(").Replace("p", ")").Replace("a", "_").Replace("s", "+").Replace("d", "-").Replace("f", "=").Replace("g", "`").Replace("h", "~").Replace("j", "[").Replace("k", "{").Replace("l", "]").Replace("z", "}").Replace("x", ":").Replace("c", "|").Replace("v", "'").Replace("b", ",").Replace("n", "<").Replace("m", "?");
            readVER_INI.Close();
            Checksum.Text = CurrentFileSum;
            richTextBox1.Text = plainMD5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enc = Convert.ToString(Checksum.Text);
            string encsave = enc.Replace(Environment.NewLine, string.Empty)
;
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(BrowseFileTextBox.Text);
                file.WriteLine(encsave);
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error writing encryption to file!");
            }
        }
    }
}

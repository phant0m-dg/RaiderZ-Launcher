//------------------------------------------------------------------
//-----------------------------Usings-------------------------------
//------------------------------------------------------------------
#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using Ionic.Zip;
using Ionic.Zlib;
#endregion

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        //------------------------------------------------------------------
        //---------------------Click Anywhere to Move-----------------------
        //------------------------------------------------------------------
        #region Click Anywhere to Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        //------------------------------------------------------------------
        //------------------Click Anywhere to Move Event--------------------
        //------------------------------------------------------------------
        #region Click Anywhere to Move Event
        private void titelLeiste_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion

        //------------------------------------------------------------------
        //-----------------------------Form1--------------------------------
        //------------------------------------------------------------------
        #region Form1
        public Form1()
        {
            this.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Body.png");
            InitializeComponent();
            StartGameButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\StartGame.png");
            CloseButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Close.png");

            string readmd5 = System.IO.File.ReadAllText(@"ver.ini");

            string nextVersion = readmd5;
            string nextVersionDec = nextVersion.Replace("!", "q").Replace("@", "w").Replace("#", "e").Replace("$", "r").Replace("%", "t").Replace("^", "y").Replace("&", "u").Replace("*", "i").Replace("(", "o").Replace(")", "p").Replace("_", "a").Replace("+", "s").Replace("-", "d").Replace("=", "f").Replace("`", "g").Replace("~", "h").Replace("[", "j").Replace("{", "k").Replace("]", "l").Replace("}", "z").Replace(":", "x").Replace("|", "c").Replace("'", "v").Replace(",", "b").Replace("<", "n").Replace("?", "m");
            //MessageBox.Show(nextVersionDec);
            string needUpdate = "UpdatePlease";
            HttpWebRequest checkFileExist = (HttpWebRequest)System.Net.WebRequest.Create("http://raiderz.daregamer.com/updates/" + nextVersionDec + "/needupdate.ini");
            HttpWebResponse responseFileExist = (HttpWebResponse)checkFileExist.GetResponse();

            string myTextUrl = "http://raiderz.daregamer.com/updates/" + nextVersionDec + "/needupdate.ini";
            WebClient urlGrabber = new WebClient();
            string textResult = urlGrabber.DownloadString(myTextUrl);

            if (textResult != needUpdate)
            {
                imageLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\UpToDate.png");
                imageLabel.Height = 11;
                imageLabel.Width = 118;
                StartGameButton.Enabled = true;
            }
            else
            {
                imageLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Downloading.png");
                imageLabel.Height = 11;
                imageLabel.Width = 135;
                CloseButton.Enabled = false;
                downloadUpdates.RunWorkerAsync();
            }

        }
        #endregion

        //------------------------------------------------------------------
        //---------------------StartGameButton Events-----------------------
        //------------------------------------------------------------------
        #region StartGameButton Events
        private void StartGamebtn_Click(object sender, EventArgs e)
        {
            string OriginalFileSum = "3098=#8778|,68#0_76-=7-9-26_65|7";

            if (File.Exists("Raiderz.exe"))
            {
                FileStream FileToSum = new FileStream(@"Raiderz.exe", FileMode.Open, FileAccess.Read);
                string CurrentFileSum = BitConverter.ToString(MD5.Create().ComputeHash(FileToSum)).ToLower().Replace("-", "").Replace("q", "!").Replace("w", "@").Replace("e", "#").Replace("r", "$").Replace("t", "%").Replace("y", "^").Replace("u", "&").Replace("i", "*").Replace("o", "(").Replace("p", ")").Replace("a", "_").Replace("s", "+").Replace("d", "-").Replace("f", "=").Replace("g", "`").Replace("h", "~").Replace("j", "[").Replace("k", "{").Replace("l", "]").Replace("z", "}").Replace("x", ":").Replace("c", "|").Replace("v", "'").Replace("b", ",").Replace("n", "<").Replace("m", "?");
                FileToSum.Close();


                if (CurrentFileSum == OriginalFileSum)
                {
                    var pwid = System.Text.Encoding.UTF8.GetBytes(textBox_Password.Text + textBox_Username.Text);
                    string accpwhash = BitConverter.ToString(MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(textBox_Password.Text + textBox_Username.Text))).Replace("-", string.Empty).ToLower();
                    string[] args = { "login", accpwhash };

                    if (textBox_Username.Text == null || textBox_Username.Text == "" || textBox_Password.Text == null || textBox_Password.Text == "")
                    {
                        MessageBox.Show("Please fill the Username and Password fields!", "Error!");
                    }
                    else
                    {
                        if (File.Exists("Raiderz.exe"))
                        {
                            textBox_Username.Enabled = false;
                            textBox_Password.Enabled = false;
                            System.Threading.Thread.Sleep(1000);
                            Process.Start("Raiderz.exe", String.Join(" ", args));
                            System.Threading.Thread.Sleep(1000);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The file Raiderz.exe was not found!", "Error!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The file Raiderz.exe has been modified!" + "\n" + "Please restore it to be able to play!", "Error!");
                    Environment.Exit(1);
                }
            }
            else
            {
                MessageBox.Show("The file Raiderz.exe was not found!", "Error!");
            }
        }
        private void StartGamebtn_MouseEnter(object sender, EventArgs e)
        {
            StartGameButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\StartGame_act.png");
        }
        private void StartGamebtn_MouseLeave(object sender, EventArgs e)
        {
            StartGameButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\StartGame.png");
        }
        private void StartGamebtn_MouseDown(object sender, MouseEventArgs e)
        {
            StartGameButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\StartGame_click.png");
        }
        #endregion

        //------------------------------------------------------------------
        //----------------------CloseButton Events--------------------------
        //------------------------------------------------------------------
        #region CloseButton Events
        private void Closebtn_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Close_act.png");
        }
        private void Closebtn_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Close.png");
        }
        private void Closebtn_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Close_click.png");
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //------------------------------------------------------------------
        //---------------Username&Password textBox Events-------------------
        //------------------------------------------------------------------
        #region Username&Password textBox Events
        //Username textBox
        private void tbxUsername_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "Username")
            {
            textBox_Username.Text = "";
            }
        }
        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_Username.Text == "Username" || textBox_Username.Text == null || textBox_Username.Text == "" || textBox_Username.Text.Length <= 0)
            {
                textBox_Username.Text = "";
            }
        }
        private void tbxUsername_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Username.Text == null || textBox_Username.Text == "" || textBox_Username.Text.Length <= 0)
            {
            textBox_Username.Text = "Username";
            }
        }
        //Password textBox
        private void txbPassword_MouseEnter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password")
            {
                textBox_Password.Text = "";
            }
        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_Password.Text == "Password" || textBox_Password.Text == null || textBox_Password.Text == "" || textBox_Password.Text.Length <= 0)
            {
                textBox_Password.Text = "";
            }
        }
        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == null || textBox_Password.Text == "" || textBox_Password.Text.Length <= 0)
            {
                textBox_Password.Text = "Password";
            }
        }
        #endregion

        //------------------------------------------------------------------
        //--------------------AutomaticUpdater Events-----------------------
        //------------------------------------------------------------------
        #region AutomaticUpdater Events
        private void downloadUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            string readmd5 = System.IO.File.ReadAllText(@"ver.ini");
            string nextVersion = readmd5;
            string nextVersionDec = nextVersion.Replace("!", "q").Replace("@", "w").Replace("#", "e").Replace("$", "r").Replace("%", "t").Replace("^", "y").Replace("&", "u").Replace("*", "i").Replace("(", "o").Replace(")", "p").Replace("_", "a").Replace("+", "s").Replace("-", "d").Replace("=", "f").Replace("`", "g").Replace("~", "h").Replace("[", "j").Replace("{", "k").Replace("]", "l").Replace("}", "z").Replace(":", "x").Replace("|", "c").Replace("'", "v").Replace(",", "b").Replace("<", "n").Replace("?", "m");

            // the URL to download the file from
            string sUrlToReadFileFrom = "http://raiderz.daregamer.com/updates/" + nextVersionDec + "/" + nextVersionDec + ".zip";
            // the path to write the file to
            string sFilePathToWriteFileTo = nextVersionDec + ".zip";

            // first, we need to get the exact size (in bytes) of the file we are downloading
            Uri url = new Uri(sUrlToReadFileFrom);
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            response.Close();
            // gets the size of the file in bytes
            Int64 iSize = response.ContentLength;

            // keeps track of the total bytes downloaded so we can update the progress bar
            Int64 iRunningByteTotal = 0;

            // use the webclient object to download the file
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                // open the file at the remote URL for reading
                using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                {
                    // using the FileStream object, we can write the downloaded bytes to the file system
                    using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        // loop the stream and get the file into the byte buffer
                        int iByteSize = 0;
                        byte[] byteBuffer = new byte[iSize];
                        while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                        {
                            // write the bytes to the file system at the file path specified
                            streamLocal.Write(byteBuffer, 0, iByteSize);
                            iRunningByteTotal += iByteSize;

                            // calculate the progress out of a base "100"
                            double dIndex = (double)(iRunningByteTotal);
                            double dTotal = (double)byteBuffer.Length;
                            double dProgressPercentage = (dIndex / dTotal);
                            int iProgressPercentage = (int)(dProgressPercentage * 100);

                            // update the progress bar
                            downloadUpdates.ReportProgress(iProgressPercentage);
                        }
                        // clean up the file stream
                        streamLocal.Close();
                    }
                    // close the connection to the remote server
                    streamRemote.Close();
                }
            }
        }

        private void downloadUpdates_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }

        private void downloadUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string readmd5 = System.IO.File.ReadAllText(@"ver.ini");
            string nextVersion = readmd5;
            string nextVersionDec = nextVersion.Replace("!", "q").Replace("@", "w").Replace("#", "e").Replace("$", "r").Replace("%", "t").Replace("^", "y").Replace("&", "u").Replace("*", "i").Replace("(", "o").Replace(")", "p").Replace("_", "a").Replace("+", "s").Replace("-", "d").Replace("=", "f").Replace("`", "g").Replace("~", "h").Replace("[", "j").Replace("{", "k").Replace("]", "l").Replace("}", "z").Replace(":", "x").Replace("|", "c").Replace("'", "v").Replace(",", "b").Replace("<", "n").Replace("?", "m");

            if (File.Exists(nextVersionDec + ".zip"))
            {
                try
                {
                    try
                    {
                        using (ZipFile zip = ZipFile.Read(nextVersionDec + ".zip"))
                        {
                            imageLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\Unzipping.png");
                            imageLabel.Height = 11;
                            imageLabel.Width = 99;
                            zip.ExtractAll(Directory.GetCurrentDirectory(), ExtractExistingFileAction.OverwriteSilently);
                        }
                        imageLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\DeletingZip.png");
                        imageLabel.Height = 11;
                        imageLabel.Width = 110;
                        File.Delete(nextVersionDec + ".zip");
                        Application.Restart();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not delete ZIP!");
                        Environment.Exit(1);
                    }
                }
                catch
                {
                    MessageBox.Show("Error Unpacking ZIP!");
                    File.Delete(nextVersionDec + ".zip");
                    Application.Restart();
                }
            }
            else
            {
                imageLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\launcher\\UpToDate.png");
                imageLabel.Height = 11;
                imageLabel.Width = 118;
                CloseButton.Enabled = true;
                StartGameButton.Enabled = true;
            }
        }
        #endregion
    }
}
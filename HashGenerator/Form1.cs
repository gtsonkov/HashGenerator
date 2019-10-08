using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashGenerator
{
    public partial class HashGenerator : Form
    {
        public HashGenerator()
        {
            InitializeComponent();
        }

        private void GetHashBtn_Click(object sender, EventArgs e)
        {

        }

        private void BroweseBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            using (OpenFileDialog BrowseFiles = new OpenFileDialog())
            {
                if (BrowseFiles.ShowDialog()==DialogResult.OK)
                {
                    FileInfo info = new FileInfo(BrowseFiles.FileName);
                    SelectFileTxt.Text = BrowseFiles.FileName;
                    FileNameShow.Text = info.Name;
                    long FileSize = info.Length;
                    if (FileSize>1024)
                    {
                        FileSizeShow.Text = double.Parse(Math.Round((FileSize/1024.00),4).ToString()) + " KB";
                    }
                    else
                    {
                        FileSizeShow.Text = FileSize.ToString();
                    }
                    
                    bool getMd5 = false;
                    bool getSHA512 = false;
                    if (UseMD5.Checked == true)
                    {
                        getMd5 = true;
                    }
                    else
                    {
                        getSHA512 = true;
                    }
                    string HasCode = GetFileHash(getMd5, getSHA512, BrowseFiles);
                    FileHashTxt.Text = HasCode;
                }

            }
        }

        private string GetFileHash(bool getMd5, bool getSHA512, OpenFileDialog browseFiles)
        {
            if (getMd5)
            {
                using (var Md5Hash = MD5.Create())
                {
                    using (var FileRead = File.OpenRead(browseFiles.FileName))
                    {
                        var result =Md5Hash.ComputeHash(FileRead);
                        string cryptStringMd5 = BitConverter.ToString(result).Replace("-", "").ToUpperInvariant();
                        return cryptStringMd5;
                    }
                }
            }
            else
            {
                using (var SSha512 = SHA512.Create())
                {
                    using (var FileRead = File.OpenRead(browseFiles.FileName))
                    {
                        var result = SSha512.ComputeHash(FileRead);
                        string cryptStringMd5 = BitConverter.ToString(result).Replace("-", "").ToUpperInvariant();
                        return cryptStringMd5;
                    }
                }
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(FileHashTxt.Text);
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            OKLbl.Visible = false;
            NoLbl.Visible = false;
            bool identical = false;
            char[] cyrrFileHash = FileHashTxt.Text.ToCharArray();
            char[] manualInputHash = ComapreHashTxt.Text.ToCharArray();
            if (cyrrFileHash.Length == manualInputHash.Length)
            {
                for (int i = 0; i < cyrrFileHash.Length; i++)
                {
                    if (!(cyrrFileHash[i] == manualInputHash[i]))
                    {
                        break;
                    }
                    if (i == (cyrrFileHash.Length - 1))
                    {
                        identical = true;
                    }
                }
            }
            if (identical)
            {
                OKLbl.Visible = true;
            }
            else
            {
                NoLbl.Visible = true;
            }
        }

        private void UseMD5_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void UseSha512_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            SelectFileTxt.Text = null;
            FileNameShow.Text = null;
            FileHashTxt.Text = null;
            OKLbl.Visible = false;
            NoLbl.Visible = false;
        }
    }
}

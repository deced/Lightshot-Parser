using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightShot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        WebClient wClient;
        int MaskType = 7;
        Thread thread;
        int good = 0;
        int errors = 0;
        int deleted = 0;
        public void GetUrls(string startUrl, int depth)
        {
            if (depth > 0)
            {
                string chars = "qwertyuiopasdfghjklzxcvbnm1234567890";
                for (int i = 0; i < chars.Length; i++)
                {
                    GetUrls(startUrl + chars[i], depth - 1);
                }
            }
            else
                Parse(startUrl);

        }

        public void Parse(string url)
        {
            try
            {
                wClient = new WebClient();
                wClient.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.0.6) Gecko/20060728 Firefox/1.5";
                string path = LightShotParser.Properties.Settings.Default.SaveFolder + url.Substring(16);
                string s = wClient.DownloadString(url);
                if (s.IndexOf("https://image.prntscr.com/image/") != -1)
                {
                    s = s.Substring(s.IndexOf("https://image.prntscr.com/image/"));
                    s = s.Substring(0, s.IndexOf("\"/>"));
                    s = s.TrimEnd('"');
                    wClient.DownloadFile(s, path + ".jpg");
                    good++;
                }
                else if (s.IndexOf("https://i.imgur.com/") != -1)
                {
                    s = s.Substring(s.IndexOf("https://i.imgur.com/"));
                    s = s.Substring(0, s.IndexOf("\"/>"));
                    s = s.TrimEnd('"');
                    wClient.DownloadFile(s, path + ".jpg");
                    good++;
                }
                else if (s.Contains("0_173a7b_211be8ff.png") || s.IndexOf("http://img") > 0)
                {
                    deleted++;
                }
               // wClient.Headers["User-Agent"] = "Mozilla/5.0";
                this.Invoke("Валид: " + good.ToString(), "Ошибок: " + errors.ToString(), "Были удалены с сервиса: " + deleted.ToString());
            }
            catch 
            {
                errors++; this.Invoke("Валид: " + good.ToString(), "Ошибок: " + errors.ToString(), "Были удалены с сервиса: " + deleted.ToString());
            }
        }

        public void Work(string Url)
        {
            GetUrls(Url.Substring(0, Url.Length - MaskType), MaskType);
        }




        private void StartBtn_Click(object sender, EventArgs e)
        {
            good = 0;
            errors = 0;
            deleted = 0;
            Regex regex = new Regex(@"^https:\/\/(prnt\.sc|prntscr\.com)\/\w{6}$");
            if (LightShotParser.Properties.Settings.Default.SaveFolder == "")
                MessageBox.Show("Выберите папку для сохранения скриншотов");
            else if (MaskType == 7)
                MessageBox.Show("Выберите маску ссылки для парсинга");
            else if (regex.IsMatch(StartUrlTb.Text))
            {
                if (StartUrlTb.Enabled == true)
                {
                    if (new Regex(@"^http:\/\/prntscr\.com\/\w{6}$").IsMatch(StartUrlTb.Text))
                        StartUrlTb.Text = StartUrlTb.Text.Replace("prntscr.com", "prnt.sc");

                    ParserProgressPb.Value = 0;
                    thread = new Thread(() => Work(StartUrlTb.Text));
                    thread.Start();
                    UrlTypeComBox.Enabled = false;
                    StartUrlTb.Enabled = false;
                    ChooseFolderBtn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Начальная ссылка должна иметь вид https://prnt.sc/XXXXXX");
            }
        }

        #region Обновление лейблов, Textbox

        public delegate void UpdateLabel(string Good, string Bad, string Deleted);
        UpdateLabel updateLabel;

        public void Invoke(string Good, string Bad, string Deleted)
        {
            updateLabel = new UpdateLabel(Change);
            GoodLabel.Invoke(updateLabel, Good, Bad, Deleted);
        }

        public void Change(string text, string Bad, string Deleted)
        {
            if (StartUrlTb.Enabled == false)
            {
                GoodLabel.Text = text;
                ErrorsLabel.Text = Bad;
                DeletedLabel.Text = Deleted;
                ParserProgressPb.PerformStep();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartUrlTb.Text = "Начальная ссылка";
            StartUrlTb.ForeColor = Color.Gray;
        }

        private void tbUrl_Click(object sender, EventArgs e)
        {
            StartUrlTb.Text = "";
            StartUrlTb.ForeColor = Color.Black;
        }

        private void tbUrl_Leave(object sender, EventArgs e)
        {
            if (StartUrlTb.Text == "")
            {
                StartUrlTb.Text = "Начальная ссылка";
                StartUrlTb.ForeColor = Color.Gray;
            }
        }
        #endregion


        private void UrlTypeComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (UrlTypeComBox.Text)
            {
                case "https://prnt.sc/XXXXXO":
                    MaskDataLabel.Text = "Будет сгенерировано 36 ссылок";
                    MaskType = 1;
                    ParserProgressPb.Maximum = 36;
                    break;
                case "https://prnt.sc/XXXXOO":
                    MaskDataLabel.Text = "Будет сгенерировано 1296 ссылок";
                    MaskType = 2;
                    ParserProgressPb.Maximum = 1296;
                    break;
                case "https://prnt.sc/XXXOOO":
                    MaskDataLabel.Text = "Будет сгенерировано 46656 ссылок";
                    MaskType = 3;
                    ParserProgressPb.Maximum = 46656;
                    break;
                case "https://prnt.sc/XXOOOO":
                    MaskDataLabel.Text = "Будет сгенерировано 1679616 ссылок";
                    MaskType = 4;
                    ParserProgressPb.Maximum = 1679616;
                    break;
                case "https://prnt.sc/XOOOOO":
                    MaskDataLabel.Text = "Будет сгенерировано 60466176 ссылок";
                    MaskType = 5;
                    ParserProgressPb.Maximum = 60466176;
                    break;
                case "https://prnt.sc/OOOOOO":
                    MaskDataLabel.Text = "Будет сгенерировано 2076782336 ссылок";
                    ParserProgressPb.Maximum = 2076782336;
                    MaskType = 6;
                    break;
            }
        }

        private void ChooseFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                LightShotParser.Properties.Settings.Default.SaveFolder = folderBrowserDialog.SelectedPath + "\\";
                LightShotParser.Properties.Settings.Default.Save();
                MessageBox.Show("Скриншоты будут загружаться в " + folderBrowserDialog.SelectedPath + "\\");
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (!UrlTypeComBox.Enabled)
            {
                UrlTypeComBox.Enabled = true;
                StartUrlTb.Enabled = true;
                ChooseFolderBtn.Enabled = true;
                thread.Abort();
                GoodLabel.Text = "Валид: 0";
                DeletedLabel.Text = "Были удалены с сервиса: 0";
                ErrorsLabel.Text = "Ошибок: 0";
                ParserProgressPb.Value = 0;
            }
        }

    }
}

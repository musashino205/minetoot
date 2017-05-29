using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;

namespace MineToot
{
    public partial class frmBase : Form
    {
        private string logPath = "";
        private string logFileName = "";
        private string logDirName = "";
        private string logLastLine = "";

        // settings
        bool loginout = true;
        bool death = true;
        bool chat = false;
        string svDomain = "";
        string svName = "Minecraft Server";
        int interval = 100;
        string token = "";
        int privacyIndex = 1;
        bool toot = false;

        clsParseLog clsPL = new clsParseLog();
        clsDeathMsg clsDM = new clsDeathMsg();

        frmSettings fTS;

        public frmBase()
        {
            InitializeComponent();

            loadSettings();
        }

        private void loadSettings()
        {
            // settings 読み込み
            loginout = settings.app.Default.loginout;

            death = settings.app.Default.death;

            chat = settings.app.Default.chat;

            if (settings.app.Default.server_domain != "")
                svDomain = settings.app.Default.server_domain;

            if (settings.app.Default.server_name != "")
                svName = settings.app.Default.server_name;

            interval = settings.app.Default.interval;

            if (settings.app.Default.token != "")
                token = settings.app.Default.token;

            privacyIndex = settings.app.Default.privacy;

            toot = settings.app.Default.toot;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            ofdLog.FileName = "latest.log";
            ofdLog.Filter = "ログ ファイル(*.log)|*.log";
            ofdLog.Title = "Minecraft ログファイルを開く";
            ofdLog.RestoreDirectory = true;

            if (ofdLog.ShowDialog() == DialogResult.OK)
            {
                lblLogPath.Text = ofdLog.FileName;
                logPath = ofdLog.FileName;
                logFileName = Path.GetFileName(logPath);
                logDirName = Path.GetDirectoryName(logPath);

                readAll(logPath);
            }
        }

        private void readAll(string filepath)
        {
            // Read log (all lines)
            FileStream fs = new FileStream(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            TextReader sr = new StreamReader(fs, Encoding.GetEncoding("SHIFT_JIS"));
            txtLogMsg.Text = sr.ReadToEnd();
            fs.Close();

            // Read last line in logfile
            //logLastLine = readLL(logPath);

            scrollLogLL();
            scrollTransLL();
        }

        private void scrollLogLL()
        {
            txtLogMsg.SelectionStart = txtLogMsg.Text.Length;
            txtLogMsg.Focus();
            txtLogMsg.ScrollToCaret();
        }

        private void scrollTransLL()
        {
            txtTrans.SelectionStart = txtTrans.Text.Length;
            txtTrans.Focus();
            txtTrans.ScrollToCaret();
        }

        // Read last line
        private string readLL(string filepath)
        {
            string lastline = "";

            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            TextReader sr = new StreamReader(fs, Encoding.GetEncoding("SHIFT_JIS"));

            while (sr.Peek() >= 0)
            {
                lastline = sr.ReadLine();
            }
            return lastline;
        }

        // Get index of last line
        private long getLLIndex(string filepath)
        {
            long index = 0;

            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            TextReader sr = new StreamReader(fs, Encoding.GetEncoding("SHIFT_JIS"));

            while (sr.Peek() >= 0)
            {
                index++;
                sr.ReadLine();
            }

            return index;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            logLastLine = readLL(logPath);
            tmrReadInterval.Interval = interval;

            tmrReadInterval.Enabled = true;
            txtTrans.Text += Environment.NewLine + "##### Logfile monitoring started #####" + Environment.NewLine;
            scrollTransLL();
        }

        private void tmrReadInterval_Tick(object sender, EventArgs e)
        {
            string lastline = readLL(logPath);
            string parsedStr = "";
            if (logLastLine != lastline)
            {
                txtLogMsg.Text += lastline + Environment.NewLine;
                logLastLine = lastline;
                scrollLogLL();

                txtTrans.Text += "===<new line detected!>===\r\n";
                string[] strAry;
                strAry = clsPL.parseLogAray(lastline);
                txtTrans.Text += "-----<splited data>-----\r\n";
                txtTrans.Text += strAry[1] + Environment.NewLine
                    + strAry[2] + Environment.NewLine
                    + strAry[3] + Environment.NewLine;
                txtTrans.Text += "-----<parsed data>-----\r\n";
                parsedStr = clsPL.parseLogLine(lastline, svName);
                txtTrans.Text += parsedStr;
                scrollTransLL();

                if (toot && clsPL.translated && clsPL.chkDoToot())
                    postTootHttp(parsedStr);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrReadInterval.Enabled = false;
            txtTrans.Text += "##### Logfile monitoring stopped #####";

            scrollTransLL();
        }

        // HttpClient
        private async void postTootHttp(string text)
        {
            // privacy
            string privacy = "";
            switch (privacyIndex)
            {
                case 0:
                    privacy = "public";
                    break;
                case 1:
                    privacy = "unlisted";
                    break;
                case 2:
                default:
                    privacy = "private";
                    break;
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = int.MaxValue;
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "access_token", token },
                { "status", text },
                { "visibility", privacy }
            });
            var response = new HttpResponseMessage();


            response = await client.PostAsync("https://" + svDomain + "/api/v1/statuses", content);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            postTootHttp("test");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fTS = new frmSettings();
            fTS.ShowDialog();

            loadSettings();
        }
    }
}

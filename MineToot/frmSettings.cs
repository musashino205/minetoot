using System;
using System.Data;
using System.Windows.Forms;

namespace MineToot
{
    public partial class frmSettings : Form
    {
        private DataTable dtUsers = new DataTable();
        private DataTable dtTexts = new DataTable();

        public frmSettings()
        {
            InitializeComponent();

            // settings 読み込み
            chkLoginout.Checked = settings.app.Default.loginout;

            chkDeath.Checked = settings.app.Default.death;

            chkChat.Checked = settings.app.Default.chat;

            if (settings.app.Default.server_name != "")
                txtSvName.Text = settings.app.Default.server_name;

            if (settings.app.Default.server_domain != "")
                txtSvDomain.Text = settings.app.Default.server_domain;

            if (settings.app.Default.server_name != "")
                txtSvName.Text = settings.app.Default.server_name;

            numInterval.Value = settings.app.Default.interval;

            if (settings.app.Default.token != "")
                txtToken.Text = settings.app.Default.token;

            cmbPrivacy.SelectedIndex = settings.app.Default.privacy;

            chkToot.Checked = settings.app.Default.toot;

            // users 関連
            //cmbPrivacy.SelectedIndex = 1;
            dtUsers.Columns.Add("user", Type.GetType("System.String"));
            dtUsers.TableName = "Userlist";

            // users.settings.users に値が存在していれば読み込む
            if (settings.users.Default.user != "")
            {
                string[] ary = settings.users.Default.user.Split(',');
                for (int i = 0; i < ary.Length; i++)
                {
                    if (ary[i] != "")
                        dtUsers.Rows.Add(ary[i]);
                }
            }

            dgvUsers.DataSource = dtUsers;

            dgvUsers.Columns[0].Width = dgvUsers.Width - 50;
        }

        private void frmTootSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // dtUsers -> users.settings
            string strUsers = "";

            for (int i = 0; i < dtUsers.Rows.Count; i++)
            {
                strUsers += dtUsers.Rows[i][0] + ",";
            }

            settings.users.Default.user = strUsers;

            // settings
            settings.app.Default.loginout = chkLoginout.Checked;
            settings.app.Default.death = chkDeath.Checked;
            settings.app.Default.chat = chkChat.Checked;
            settings.app.Default.server_domain = txtSvDomain.Text;
            settings.app.Default.server_name = txtSvName.Text;
            settings.app.Default.interval = Convert.ToInt32(numInterval.Value);
            settings.app.Default.token = txtToken.Text;
            settings.app.Default.privacy = cmbPrivacy.SelectedIndex;
            settings.app.Default.toot = chkToot.Checked;

            settings.users.Default.Save();
            settings.app.Default.Save();
            this.Close();
        }

        private void chkTokenVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTokenVisible.Checked)
                txtToken.UseSystemPasswordChar = false;
            else
                txtToken.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

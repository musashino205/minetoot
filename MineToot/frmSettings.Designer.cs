namespace MineToot
{
    partial class frmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChat = new System.Windows.Forms.CheckBox();
            this.chkDeath = new System.Windows.Forms.CheckBox();
            this.chkLoginout = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTexts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSvDomain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrivacy = new System.Windows.Forms.ComboBox();
            this.chkTokenVisible = new System.Windows.Forms.CheckBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.chkToot = new System.Windows.Forms.CheckBox();
            this.txtSvName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chkChat);
            this.groupBox1.Controls.Add(this.chkDeath);
            this.groupBox1.Controls.Add(this.chkLoginout);
            this.groupBox1.Location = new System.Drawing.Point(0, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(204, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // chkChat
            // 
            this.chkChat.AutoSize = true;
            this.chkChat.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.chkChat.Location = new System.Drawing.Point(8, 81);
            this.chkChat.Name = "chkChat";
            this.chkChat.Size = new System.Drawing.Size(53, 19);
            this.chkChat.TabIndex = 2;
            this.chkChat.Text = "Chat";
            this.chkChat.UseVisualStyleBackColor = true;
            // 
            // chkDeath
            // 
            this.chkDeath.AutoSize = true;
            this.chkDeath.Checked = true;
            this.chkDeath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeath.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.chkDeath.Location = new System.Drawing.Point(8, 53);
            this.chkDeath.Name = "chkDeath";
            this.chkDeath.Size = new System.Drawing.Size(61, 19);
            this.chkDeath.TabIndex = 1;
            this.chkDeath.Text = "Death";
            this.chkDeath.UseVisualStyleBackColor = true;
            // 
            // chkLoginout
            // 
            this.chkLoginout.AutoSize = true;
            this.chkLoginout.Checked = true;
            this.chkLoginout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoginout.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.chkLoginout.Location = new System.Drawing.Point(8, 25);
            this.chkLoginout.Name = "chkLoginout";
            this.chkLoginout.Size = new System.Drawing.Size(103, 19);
            this.chkLoginout.TabIndex = 0;
            this.chkLoginout.Text = "Login/Logout";
            this.chkLoginout.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvUsers);
            this.groupBox2.Location = new System.Drawing.Point(203, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(196, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluded Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(4, 21);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 21;
            this.dgvUsers.Size = new System.Drawing.Size(188, 393);
            this.dgvUsers.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvTexts);
            this.groupBox3.Location = new System.Drawing.Point(399, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 418);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluded Words";
            // 
            // dgvTexts
            // 
            this.dgvTexts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTexts.Location = new System.Drawing.Point(3, 20);
            this.dgvTexts.Name = "dgvTexts";
            this.dgvTexts.RowTemplate.Height = 21;
            this.dgvTexts.Size = new System.Drawing.Size(179, 395);
            this.dgvTexts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(399, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 30);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "OK";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(506, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.txtSvDomain);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbPrivacy);
            this.groupBox4.Controls.Add(this.chkTokenVisible);
            this.groupBox4.Controls.Add(this.txtToken);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numInterval);
            this.groupBox4.Controls.Add(this.chkToot);
            this.groupBox4.Controls.Add(this.txtSvName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 295);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // txtSvDomain
            // 
            this.txtSvDomain.Location = new System.Drawing.Point(3, 36);
            this.txtSvDomain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtSvDomain.Name = "txtSvDomain";
            this.txtSvDomain.Size = new System.Drawing.Size(197, 24);
            this.txtSvDomain.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mastodon Server Domain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Privacy:";
            // 
            // cmbPrivacy
            // 
            this.cmbPrivacy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrivacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivacy.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.cmbPrivacy.FormattingEnabled = true;
            this.cmbPrivacy.Items.AddRange(new object[] {
            "Public",
            "Unlisted",
            "Private"});
            this.cmbPrivacy.Location = new System.Drawing.Point(3, 231);
            this.cmbPrivacy.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPrivacy.Name = "cmbPrivacy";
            this.cmbPrivacy.Size = new System.Drawing.Size(197, 23);
            this.cmbPrivacy.TabIndex = 10;
            // 
            // chkTokenVisible
            // 
            this.chkTokenVisible.AutoSize = true;
            this.chkTokenVisible.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.chkTokenVisible.Location = new System.Drawing.Point(137, 197);
            this.chkTokenVisible.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.chkTokenVisible.Name = "chkTokenVisible";
            this.chkTokenVisible.Size = new System.Drawing.Size(63, 19);
            this.chkTokenVisible.TabIndex = 9;
            this.chkTokenVisible.Text = "Visible";
            this.chkTokenVisible.UseVisualStyleBackColor = true;
            this.chkTokenVisible.CheckedChanged += new System.EventHandler(this.chkTokenVisible_CheckedChanged);
            // 
            // txtToken
            // 
            this.txtToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToken.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.txtToken.Location = new System.Drawing.Point(3, 174);
            this.txtToken.Margin = new System.Windows.Forms.Padding(0);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(197, 23);
            this.txtToken.TabIndex = 8;
            this.txtToken.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Access Token:";
            // 
            // numInterval
            // 
            this.numInterval.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.numInterval.Location = new System.Drawing.Point(3, 128);
            this.numInterval.Margin = new System.Windows.Forms.Padding(0);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(165, 23);
            this.numInterval.TabIndex = 6;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkToot
            // 
            this.chkToot.AutoSize = true;
            this.chkToot.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.chkToot.Location = new System.Drawing.Point(12, 267);
            this.chkToot.Name = "chkToot";
            this.chkToot.Size = new System.Drawing.Size(52, 19);
            this.chkToot.TabIndex = 5;
            this.chkToot.Text = "Toot";
            this.chkToot.UseVisualStyleBackColor = true;
            // 
            // txtSvName
            // 
            this.txtSvName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSvName.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.txtSvName.Location = new System.Drawing.Point(3, 82);
            this.txtSvName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSvName.Name = "txtSvName";
            this.txtSvName.Size = new System.Drawing.Size(197, 23);
            this.txtSvName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minecraft Server Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label2.Location = new System.Drawing.Point(171, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monitoring Interval: ";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmTootSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkChat;
        private System.Windows.Forms.CheckBox chkDeath;
        private System.Windows.Forms.CheckBox chkLoginout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTexts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSvName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkToot;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrivacy;
        private System.Windows.Forms.CheckBox chkTokenVisible;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSvDomain;
        private System.Windows.Forms.Label label6;
    }
}
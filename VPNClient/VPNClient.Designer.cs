namespace VPNClient
{
    partial class VPNClient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LogoBox = new System.Windows.Forms.GroupBox();
            this.AccountInfo = new System.Windows.Forms.GroupBox();
            this.lReminderValue = new System.Windows.Forms.Label();
            this.lReminderKey = new System.Windows.Forms.Label();
            this.lAccountTypeValue = new System.Windows.Forms.Label();
            this.lAccountTypeKey = new System.Windows.Forms.Label();
            this.lDeadlineValue = new System.Windows.Forms.Label();
            this.lDeadlineKey = new System.Windows.Forms.Label();
            this.lUserNameValue = new System.Windows.Forms.Label();
            this.lUserNameKey = new System.Windows.Forms.Label();
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.rSSTP = new System.Windows.Forms.RadioButton();
            this.rL2TP = new System.Windows.Forms.RadioButton();
            this.rPPTP = new System.Windows.Forms.RadioButton();
            this.lProtocol = new System.Windows.Forms.Label();
            this.tUserkey = new System.Windows.Forms.TextBox();
            this.lUserKey = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tServerIP = new System.Windows.Forms.TextBox();
            this.lServerIP = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.bWebSite = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.AccountInfo.SuspendLayout();
            this.SettingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Location = new System.Drawing.Point(8, 10);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(268, 82);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // AccountInfo
            // 
            this.AccountInfo.Controls.Add(this.lReminderValue);
            this.AccountInfo.Controls.Add(this.lReminderKey);
            this.AccountInfo.Controls.Add(this.lAccountTypeValue);
            this.AccountInfo.Controls.Add(this.lAccountTypeKey);
            this.AccountInfo.Controls.Add(this.lDeadlineValue);
            this.AccountInfo.Controls.Add(this.lDeadlineKey);
            this.AccountInfo.Controls.Add(this.lUserNameValue);
            this.AccountInfo.Controls.Add(this.lUserNameKey);
            this.AccountInfo.Location = new System.Drawing.Point(8, 98);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(268, 82);
            this.AccountInfo.TabIndex = 1;
            this.AccountInfo.TabStop = false;
            // 
            // lReminderValue
            // 
            this.lReminderValue.AutoSize = true;
            this.lReminderValue.Location = new System.Drawing.Point(208, 50);
            this.lReminderValue.Name = "lReminderValue";
            this.lReminderValue.Size = new System.Drawing.Size(41, 12);
            this.lReminderValue.TabIndex = 7;
            this.lReminderValue.Text = "label5";
            // 
            // lReminderKey
            // 
            this.lReminderKey.AutoSize = true;
            this.lReminderKey.Location = new System.Drawing.Point(137, 50);
            this.lReminderKey.Name = "lReminderKey";
            this.lReminderKey.Size = new System.Drawing.Size(65, 12);
            this.lReminderKey.TabIndex = 6;
            this.lReminderKey.Text = "剩余时间：";
            // 
            // lAccountTypeValue
            // 
            this.lAccountTypeValue.AutoSize = true;
            this.lAccountTypeValue.Location = new System.Drawing.Point(208, 17);
            this.lAccountTypeValue.Name = "lAccountTypeValue";
            this.lAccountTypeValue.Size = new System.Drawing.Size(41, 12);
            this.lAccountTypeValue.TabIndex = 5;
            this.lAccountTypeValue.Text = "label7";
            // 
            // lAccountTypeKey
            // 
            this.lAccountTypeKey.AutoSize = true;
            this.lAccountTypeKey.Location = new System.Drawing.Point(137, 17);
            this.lAccountTypeKey.Name = "lAccountTypeKey";
            this.lAccountTypeKey.Size = new System.Drawing.Size(65, 12);
            this.lAccountTypeKey.TabIndex = 4;
            this.lAccountTypeKey.Text = "账户类型：";
            // 
            // lDeadlineValue
            // 
            this.lDeadlineValue.AutoSize = true;
            this.lDeadlineValue.Location = new System.Drawing.Point(74, 50);
            this.lDeadlineValue.Name = "lDeadlineValue";
            this.lDeadlineValue.Size = new System.Drawing.Size(41, 12);
            this.lDeadlineValue.TabIndex = 3;
            this.lDeadlineValue.Text = "label3";
            // 
            // lDeadlineKey
            // 
            this.lDeadlineKey.AutoSize = true;
            this.lDeadlineKey.Location = new System.Drawing.Point(15, 50);
            this.lDeadlineKey.Name = "lDeadlineKey";
            this.lDeadlineKey.Size = new System.Drawing.Size(65, 12);
            this.lDeadlineKey.TabIndex = 2;
            this.lDeadlineKey.Text = "到期时间：";
            // 
            // lUserNameValue
            // 
            this.lUserNameValue.AutoSize = true;
            this.lUserNameValue.Location = new System.Drawing.Point(74, 17);
            this.lUserNameValue.Name = "lUserNameValue";
            this.lUserNameValue.Size = new System.Drawing.Size(41, 12);
            this.lUserNameValue.TabIndex = 1;
            this.lUserNameValue.Text = "label2";
            // 
            // lUserNameKey
            // 
            this.lUserNameKey.AutoSize = true;
            this.lUserNameKey.Location = new System.Drawing.Point(15, 17);
            this.lUserNameKey.Name = "lUserNameKey";
            this.lUserNameKey.Size = new System.Drawing.Size(65, 12);
            this.lUserNameKey.TabIndex = 0;
            this.lUserNameKey.Text = "用户名称：";
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.rSSTP);
            this.SettingBox.Controls.Add(this.rL2TP);
            this.SettingBox.Controls.Add(this.rPPTP);
            this.SettingBox.Controls.Add(this.lProtocol);
            this.SettingBox.Controls.Add(this.tUserkey);
            this.SettingBox.Controls.Add(this.lUserKey);
            this.SettingBox.Controls.Add(this.tUsername);
            this.SettingBox.Controls.Add(this.lUsername);
            this.SettingBox.Controls.Add(this.tServerIP);
            this.SettingBox.Controls.Add(this.lServerIP);
            this.SettingBox.Location = new System.Drawing.Point(8, 186);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(268, 145);
            this.SettingBox.TabIndex = 2;
            this.SettingBox.TabStop = false;
            // 
            // rSSTP
            // 
            this.rSSTP.AutoSize = true;
            this.rSSTP.Location = new System.Drawing.Point(202, 109);
            this.rSSTP.Name = "rSSTP";
            this.rSSTP.Size = new System.Drawing.Size(47, 16);
            this.rSSTP.TabIndex = 9;
            this.rSSTP.TabStop = true;
            this.rSSTP.Text = "SSTP";
            this.rSSTP.UseVisualStyleBackColor = true;
            // 
            // rL2TP
            // 
            this.rL2TP.AutoSize = true;
            this.rL2TP.Location = new System.Drawing.Point(139, 109);
            this.rL2TP.Name = "rL2TP";
            this.rL2TP.Size = new System.Drawing.Size(47, 16);
            this.rL2TP.TabIndex = 8;
            this.rL2TP.TabStop = true;
            this.rL2TP.Text = "L2TP";
            this.rL2TP.UseVisualStyleBackColor = true;
            // 
            // rPPTP
            // 
            this.rPPTP.AutoSize = true;
            this.rPPTP.Location = new System.Drawing.Point(83, 109);
            this.rPPTP.Name = "rPPTP";
            this.rPPTP.Size = new System.Drawing.Size(47, 16);
            this.rPPTP.TabIndex = 7;
            this.rPPTP.TabStop = true;
            this.rPPTP.Text = "PPTP";
            this.rPPTP.UseVisualStyleBackColor = true;
            // 
            // lProtocol
            // 
            this.lProtocol.AutoSize = true;
            this.lProtocol.Location = new System.Drawing.Point(12, 109);
            this.lProtocol.Name = "lProtocol";
            this.lProtocol.Size = new System.Drawing.Size(65, 12);
            this.lProtocol.TabIndex = 6;
            this.lProtocol.Text = "连接协议：";
            // 
            // tUserkey
            // 
            this.tUserkey.Location = new System.Drawing.Point(83, 75);
            this.tUserkey.Name = "tUserkey";
            this.tUserkey.PasswordChar = '*';
            this.tUserkey.Size = new System.Drawing.Size(166, 21);
            this.tUserkey.TabIndex = 5;
            // 
            // lUserKey
            // 
            this.lUserKey.AutoSize = true;
            this.lUserKey.Location = new System.Drawing.Point(12, 79);
            this.lUserKey.Name = "lUserKey";
            this.lUserKey.Size = new System.Drawing.Size(65, 12);
            this.lUserKey.TabIndex = 4;
            this.lUserKey.Text = "用户密码：";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(83, 48);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(166, 21);
            this.tUsername.TabIndex = 3;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(12, 52);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(65, 12);
            this.lUsername.TabIndex = 2;
            this.lUsername.Text = "用户账号：";
            // 
            // tServerIP
            // 
            this.tServerIP.Location = new System.Drawing.Point(83, 21);
            this.tServerIP.Name = "tServerIP";
            this.tServerIP.Size = new System.Drawing.Size(166, 21);
            this.tServerIP.TabIndex = 1;
            // 
            // lServerIP
            // 
            this.lServerIP.AutoSize = true;
            this.lServerIP.Location = new System.Drawing.Point(12, 25);
            this.lServerIP.Name = "lServerIP";
            this.lServerIP.Size = new System.Drawing.Size(65, 12);
            this.lServerIP.TabIndex = 0;
            this.lServerIP.Text = "服务地址：";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(8, 350);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 3;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bWebSite
            // 
            this.bWebSite.Location = new System.Drawing.Point(99, 349);
            this.bWebSite.Name = "bWebSite";
            this.bWebSite.Size = new System.Drawing.Size(75, 23);
            this.bWebSite.TabIndex = 4;
            this.bWebSite.Text = "官网";
            this.bWebSite.UseVisualStyleBackColor = true;
            this.bWebSite.Click += new System.EventHandler(this.bWebSite_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(192, 350);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "退出";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tMessage
            // 
            this.tMessage.Location = new System.Drawing.Point(8, 389);
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.ReadOnly = true;
            this.tMessage.Size = new System.Drawing.Size(268, 62);
            this.tMessage.TabIndex = 6;
            // 
            // VPNClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 481);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bWebSite);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.SettingBox);
            this.Controls.Add(this.AccountInfo);
            this.Controls.Add(this.LogoBox);
            this.Name = "VPNClient";
            this.Text = "VPN网络加速器";
            this.AccountInfo.ResumeLayout(false);
            this.AccountInfo.PerformLayout();
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LogoBox;
        private System.Windows.Forms.GroupBox AccountInfo;
        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bWebSite;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.Label lReminderValue;
        private System.Windows.Forms.Label lReminderKey;
        private System.Windows.Forms.Label lAccountTypeValue;
        private System.Windows.Forms.Label lAccountTypeKey;
        private System.Windows.Forms.Label lDeadlineValue;
        private System.Windows.Forms.Label lDeadlineKey;
        private System.Windows.Forms.Label lUserNameValue;
        private System.Windows.Forms.Label lUserNameKey;
        private System.Windows.Forms.RadioButton rSSTP;
        private System.Windows.Forms.RadioButton rL2TP;
        private System.Windows.Forms.RadioButton rPPTP;
        private System.Windows.Forms.Label lProtocol;
        private System.Windows.Forms.TextBox tUserkey;
        private System.Windows.Forms.Label lUserKey;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tServerIP;
        private System.Windows.Forms.Label lServerIP;
    }
}


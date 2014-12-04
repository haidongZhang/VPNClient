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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPNClient));
            this.AllUsersPhoneBook = new DotRas.RasPhoneBook(this.components);
            this.Dialer = new DotRas.RasDialer(this.components);
            this.SettingBox = new System.Windows.Forms.GroupBox();
            this.tUserkey = new System.Windows.Forms.TextBox();
            this.lUserKey = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.tServerIP = new System.Windows.Forms.TextBox();
            this.lServerIP = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bRenew = new System.Windows.Forms.Button();
            this.tMessage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dialer
            // 
            // TODO: “this.Dialer.CallbackId”的代码生成失败，原因是出现异常“无效的基元类型: System.IntPtr。请考虑使用 CodeObjectCreateExpression。”。
            this.Dialer.Credentials = null;
            this.Dialer.EapOptions = new DotRas.RasEapOptions(false, false, false);
            this.Dialer.Options = new DotRas.RasDialOptions(false, false, false, false, false, false, false, false, false, false);
            this.Dialer.StateChanged += new System.EventHandler<DotRas.StateChangedEventArgs>(this.Dialer_StateChanged);
            this.Dialer.DialCompleted += new System.EventHandler<DotRas.DialCompletedEventArgs>(this.Dialer_DialCompleted);
            this.Dialer.Error += new System.EventHandler<System.IO.ErrorEventArgs>(this.Dialer_Error);
            // 
            // SettingBox
            // 
            this.SettingBox.Controls.Add(this.tUserkey);
            this.SettingBox.Controls.Add(this.lUserKey);
            this.SettingBox.Controls.Add(this.tUsername);
            this.SettingBox.Controls.Add(this.lUsername);
            this.SettingBox.Controls.Add(this.tServerIP);
            this.SettingBox.Controls.Add(this.lServerIP);
            this.SettingBox.Location = new System.Drawing.Point(12, 100);
            this.SettingBox.Name = "SettingBox";
            this.SettingBox.Size = new System.Drawing.Size(268, 121);
            this.SettingBox.TabIndex = 2;
            this.SettingBox.TabStop = false;
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
            this.bConnect.Location = new System.Drawing.Point(12, 234);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 3;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(103, 233);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bDisconnect.TabIndex = 4;
            this.bDisconnect.Text = "断开";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bRenew
            // 
            this.bRenew.Location = new System.Drawing.Point(196, 234);
            this.bRenew.Name = "bRenew";
            this.bRenew.Size = new System.Drawing.Size(75, 23);
            this.bRenew.TabIndex = 5;
            this.bRenew.Text = "续费";
            this.bRenew.UseVisualStyleBackColor = true;
            this.bRenew.Click += new System.EventHandler(this.bRenew_Click);
            // 
            // tMessage
            // 
            this.tMessage.Location = new System.Drawing.Point(12, 274);
            this.tMessage.Multiline = true;
            this.tMessage.Name = "tMessage";
            this.tMessage.ReadOnly = true;
            this.tMessage.Size = new System.Drawing.Size(268, 87);
            this.tMessage.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 81);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // VPNClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tMessage);
            this.Controls.Add(this.bRenew);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.SettingBox);
            this.Name = "VPNClient";
            this.Text = "VPN网络加速器";
            this.SettingBox.ResumeLayout(false);
            this.SettingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingBox;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bRenew;
        private System.Windows.Forms.TextBox tMessage;
        private System.Windows.Forms.TextBox tUserkey;
        private System.Windows.Forms.Label lUserKey;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox tServerIP;
        private System.Windows.Forms.Label lServerIP;

        private DotRas.RasPhoneBook AllUsersPhoneBook;
        private DotRas.RasDialer Dialer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


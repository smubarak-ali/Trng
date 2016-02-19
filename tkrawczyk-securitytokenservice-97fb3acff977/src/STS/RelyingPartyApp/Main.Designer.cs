namespace STS.RelyingPartyApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.rtbClaims = new System.Windows.Forms.RichTextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.chbIsUser = new System.Windows.Forms.CheckBox();
            this.chbIsSuperAdmin = new System.Windows.Forms.CheckBox();
            this.chbIsAdmin = new System.Windows.Forms.CheckBox();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceTwo = new System.Windows.Forms.Button();
            this.btnServiceOne = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbClaims
            // 
            this.rtbClaims.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbClaims.Location = new System.Drawing.Point(0, 0);
            this.rtbClaims.Name = "rtbClaims";
            this.rtbClaims.ReadOnly = true;
            this.rtbClaims.Size = new System.Drawing.Size(659, 399);
            this.rtbClaims.TabIndex = 0;
            this.rtbClaims.Text = "";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.chbIsUser);
            this.pnlInfo.Controls.Add(this.chbIsSuperAdmin);
            this.pnlInfo.Controls.Add(this.chbIsAdmin);
            this.pnlInfo.Controls.Add(this.rtbClaims);
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(659, 428);
            this.pnlInfo.TabIndex = 1;
            // 
            // chbIsUser
            // 
            this.chbIsUser.AutoSize = true;
            this.chbIsUser.Location = new System.Drawing.Point(3, 405);
            this.chbIsUser.Name = "chbIsUser";
            this.chbIsUser.Size = new System.Drawing.Size(55, 17);
            this.chbIsUser.TabIndex = 3;
            this.chbIsUser.Text = "isUser";
            this.chbIsUser.UseVisualStyleBackColor = true;
            // 
            // chbIsSuperAdmin
            // 
            this.chbIsSuperAdmin.AutoSize = true;
            this.chbIsSuperAdmin.Location = new System.Drawing.Point(123, 405);
            this.chbIsSuperAdmin.Name = "chbIsSuperAdmin";
            this.chbIsSuperAdmin.Size = new System.Drawing.Size(90, 17);
            this.chbIsSuperAdmin.TabIndex = 2;
            this.chbIsSuperAdmin.Text = "isSuperAdmin";
            this.chbIsSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // chbIsAdmin
            // 
            this.chbIsAdmin.AutoSize = true;
            this.chbIsAdmin.Location = new System.Drawing.Point(64, 405);
            this.chbIsAdmin.Name = "chbIsAdmin";
            this.chbIsAdmin.Size = new System.Drawing.Size(62, 17);
            this.chbIsAdmin.TabIndex = 1;
            this.chbIsAdmin.Text = "isAdmin";
            this.chbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // errProv
            // 
            this.errProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProv.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnServiceTwo);
            this.panel1.Controls.Add(this.btnServiceOne);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnServiceTwo
            // 
            this.btnServiceTwo.Location = new System.Drawing.Point(274, 68);
            this.btnServiceTwo.Name = "btnServiceTwo";
            this.btnServiceTwo.Size = new System.Drawing.Size(92, 23);
            this.btnServiceTwo.TabIndex = 15;
            this.btnServiceTwo.Text = "Call Service 2";
            this.btnServiceTwo.UseVisualStyleBackColor = true;
            this.btnServiceTwo.Click += new System.EventHandler(this.btnServiceTwo_Click);
            // 
            // btnServiceOne
            // 
            this.btnServiceOne.Location = new System.Drawing.Point(176, 68);
            this.btnServiceOne.Name = "btnServiceOne";
            this.btnServiceOne.Size = new System.Drawing.Size(92, 23);
            this.btnServiceOne.TabIndex = 14;
            this.btnServiceOne.Text = "Call Service 1";
            this.btnServiceOne.UseVisualStyleBackColor = true;
            this.btnServiceOne.Click += new System.EventHandler(this.btnServiceOne_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(81, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(81, 13);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(143, 20);
            this.txtLogin.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "User Name";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(95, 66);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(14, 66);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relying Party App";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbClaims;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.CheckBox chbIsUser;
        private System.Windows.Forms.CheckBox chbIsSuperAdmin;
        private System.Windows.Forms.CheckBox chbIsAdmin;
        private System.Windows.Forms.ErrorProvider errProv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnServiceOne;
        private System.Windows.Forms.Button btnServiceTwo;
    }
}


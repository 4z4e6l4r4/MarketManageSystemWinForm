namespace MarketYönetimSistemi
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AdminTabPage = new System.Windows.Forms.TabPage();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UserTabPage = new System.Windows.Forms.TabPage();
            this.UserLoginBtn = new System.Windows.Forms.Button();
            this.UserPasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.AdminTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AdminTabPage);
            this.tabControl1.Controls.Add(this.UserTabPage);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 483);
            this.tabControl1.TabIndex = 8;
            // 
            // AdminTabPage
            // 
            this.AdminTabPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdminTabPage.Controls.Add(this.LoginBtn);
            this.AdminTabPage.Controls.Add(this.PasswordTxt);
            this.AdminTabPage.Controls.Add(this.PasswordLbl);
            this.AdminTabPage.Controls.Add(this.pictureBox1);
            this.AdminTabPage.Controls.Add(this.UsernameLbl);
            this.AdminTabPage.Location = new System.Drawing.Point(4, 25);
            this.AdminTabPage.Name = "AdminTabPage";
            this.AdminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminTabPage.Size = new System.Drawing.Size(330, 454);
            this.AdminTabPage.TabIndex = 0;
            this.AdminTabPage.Text = "Admin";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Location = new System.Drawing.Point(117, 337);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(92, 33);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordTxt.Location = new System.Drawing.Point(81, 304);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '♪';
            this.PasswordTxt.Size = new System.Drawing.Size(166, 22);
            this.PasswordTxt.TabIndex = 12;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PasswordLbl.Location = new System.Drawing.Point(77, 279);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(83, 20);
            this.PasswordLbl.TabIndex = 11;
            this.PasswordLbl.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MarketYönetimSistemi.Properties.Resources.admin1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 53);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(166, 166);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(166, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLbl.Location = new System.Drawing.Point(123, 229);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(86, 29);
            this.UsernameLbl.TabIndex = 8;
            this.UsernameLbl.Text = "Admin";
            // 
            // UserTabPage
            // 
            this.UserTabPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserTabPage.Controls.Add(this.UserLoginBtn);
            this.UserTabPage.Controls.Add(this.UserPasswordTxt);
            this.UserTabPage.Controls.Add(this.label1);
            this.UserTabPage.Controls.Add(this.UsernameTxt);
            this.UserTabPage.Controls.Add(this.label2);
            this.UserTabPage.Controls.Add(this.pictureBox2);
            this.UserTabPage.Location = new System.Drawing.Point(4, 25);
            this.UserTabPage.Name = "UserTabPage";
            this.UserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserTabPage.Size = new System.Drawing.Size(330, 454);
            this.UserTabPage.TabIndex = 1;
            this.UserTabPage.Text = "User";
            // 
            // UserLoginBtn
            // 
            this.UserLoginBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UserLoginBtn.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserLoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserLoginBtn.Location = new System.Drawing.Point(118, 371);
            this.UserLoginBtn.Name = "UserLoginBtn";
            this.UserLoginBtn.Size = new System.Drawing.Size(92, 33);
            this.UserLoginBtn.TabIndex = 13;
            this.UserLoginBtn.Text = "Login";
            this.UserLoginBtn.UseVisualStyleBackColor = false;
            this.UserLoginBtn.Click += new System.EventHandler(this.UserLoginBtn_Click);
            // 
            // UserPasswordTxt
            // 
            this.UserPasswordTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UserPasswordTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserPasswordTxt.Location = new System.Drawing.Point(82, 336);
            this.UserPasswordTxt.Name = "UserPasswordTxt";
            this.UserPasswordTxt.PasswordChar = '♪';
            this.UserPasswordTxt.Size = new System.Drawing.Size(166, 22);
            this.UserPasswordTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UsernameTxt.Location = new System.Drawing.Point(82, 269);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(166, 22);
            this.UsernameTxt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::MarketYönetimSistemi.Properties.Resources.users;
            this.pictureBox2.Location = new System.Drawing.Point(82, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 467);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPanel";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tabControl1.ResumeLayout(false);
            this.AdminTabPage.ResumeLayout(false);
            this.AdminTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserTabPage.ResumeLayout(false);
            this.UserTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AdminTabPage;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TabPage UserTabPage;
        private System.Windows.Forms.Button UserLoginBtn;
        private System.Windows.Forms.TextBox UserPasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label2;
    }
}


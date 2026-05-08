<<<<<<< HEAD
﻿namespace CyberBites
=======
﻿namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            pnlLogin = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            btnShowSignup = new Krypton.Toolkit.KryptonButton();
            txtLoginPass = new Krypton.Toolkit.KryptonTextBox();
            lblPass = new Label();
            lblUser = new Label();
            label1 = new Label();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            txtLoginUser = new Krypton.Toolkit.KryptonTextBox();
            pnlSignUp = new Krypton.Toolkit.KryptonPanel();
            linkShowLogin = new Krypton.Toolkit.KryptonLinkLabel();
            pictureBox2 = new PictureBox();
            btnCreateAcc = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            txtRegPass = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            txtRegUser = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            txtRegEmail = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            txtRegName = new Krypton.Toolkit.KryptonTextBox();
            lblSignup = new Label();
            ((System.ComponentModel.ISupportInitialize)pnlLogin).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlSignUp).BeginInit();
            pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(btnShowSignup);
            pnlLogin.Controls.Add(txtLoginPass);
            pnlLogin.Controls.Add(lblPass);
            pnlLogin.Controls.Add(lblUser);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtLoginUser);
            pnlLogin.Location = new Point(374, 41);
            pnlLogin.Margin = new Padding(3, 2, 3, 2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.GridDataCellCustom1;
            pnlLogin.Size = new Size(406, 439);
            pnlLogin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnShowSignup
            // 
            btnShowSignup.Cursor = Cursors.Hand;
            btnShowSignup.Location = new Point(78, 348);
            btnShowSignup.Margin = new Padding(3, 2, 3, 2);
            btnShowSignup.Name = "btnShowSignup";
            btnShowSignup.RightToLeft = RightToLeft.No;
            btnShowSignup.Size = new Size(241, 48);
            btnShowSignup.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnShowSignup.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnShowSignup.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnShowSignup.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnShowSignup.StateCommon.Border.Rounding = 7F;
            btnShowSignup.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnShowSignup.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnShowSignup.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnShowSignup.TabIndex = 3;
            btnShowSignup.Values.DropDownArrowColor = Color.Empty;
            btnShowSignup.Values.Text = "SIGN UP";
            btnShowSignup.Click += btnShowSignup_Click;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Cursor = Cursors.IBeam;
            txtLoginPass.Location = new Point(78, 230);
            txtLoginPass.Margin = new Padding(3, 2, 3, 2);
            txtLoginPass.Multiline = true;
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PasswordChar = '*';
            txtLoginPass.Size = new Size(241, 44);
            txtLoginPass.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtLoginPass.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtLoginPass.StateCommon.Border.Rounding = 7F;
            txtLoginPass.StateCommon.Content.Color1 = Color.White;
            txtLoginPass.StateCommon.Content.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLoginPass.StateCommon.Content.Padding = new Padding(2, 15, 2, 2);
            txtLoginPass.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtLoginPass.TabIndex = 1;
            txtLoginPass.TextAlign = HorizontalAlignment.Center;
            txtLoginPass.KeyDown += txtLoginPass_KeyDown;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(78, 213);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(78, 143);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(60, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 100);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 5;
            label1.Text = "CyberBites";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(78, 288);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(241, 48);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnLogin.StateCommon.Border.Rounding = 7F;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnLogin.TabIndex = 2;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Cursor = Cursors.IBeam;
            txtLoginUser.Location = new Point(78, 160);
            txtLoginUser.Margin = new Padding(3, 2, 3, 2);
            txtLoginUser.Multiline = true;
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Size = new Size(241, 44);
            txtLoginUser.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtLoginUser.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtLoginUser.StateCommon.Border.Rounding = 7F;
            txtLoginUser.StateCommon.Content.Color1 = Color.White;
            txtLoginUser.StateCommon.Content.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLoginUser.StateCommon.Content.Padding = new Padding(2, 15, 2, 0);
            txtLoginUser.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtLoginUser.TabIndex = 0;
            txtLoginUser.TextAlign = HorizontalAlignment.Center;
            txtLoginUser.KeyDown += txtLoginUser_KeyDown;
            // 
            // pnlSignUp
            // 
            pnlSignUp.Controls.Add(linkShowLogin);
            pnlSignUp.Controls.Add(pictureBox2);
            pnlSignUp.Controls.Add(btnCreateAcc);
            pnlSignUp.Controls.Add(label5);
            pnlSignUp.Controls.Add(txtRegPass);
            pnlSignUp.Controls.Add(label4);
            pnlSignUp.Controls.Add(txtRegUser);
            pnlSignUp.Controls.Add(label3);
            pnlSignUp.Controls.Add(txtRegEmail);
            pnlSignUp.Controls.Add(label2);
            pnlSignUp.Controls.Add(txtRegName);
            pnlSignUp.Controls.Add(lblSignup);
            pnlSignUp.Location = new Point(791, 41);
            pnlSignUp.Margin = new Padding(3, 2, 3, 2);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.GridDataCellCustom1;
            pnlSignUp.Size = new Size(406, 439);
            pnlSignUp.TabIndex = 1;
            // 
            // linkShowLogin
            // 
            linkShowLogin.Cursor = Cursors.Hand;
            linkShowLogin.Location = new Point(89, 411);
            linkShowLogin.Margin = new Padding(3, 2, 3, 2);
            linkShowLogin.Name = "linkShowLogin";
            linkShowLogin.Size = new Size(232, 23);
            linkShowLogin.TabIndex = 5;
            linkShowLogin.Values.Text = "Already have an account? Login here.";
            linkShowLogin.LinkClicked += kryptonLinkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 29);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.Cursor = Cursors.Hand;
            btnCreateAcc.Location = new Point(88, 367);
            btnCreateAcc.Margin = new Padding(3, 2, 3, 2);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.RightToLeft = RightToLeft.No;
            btnCreateAcc.Size = new Size(237, 42);
            btnCreateAcc.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnCreateAcc.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnCreateAcc.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnCreateAcc.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnCreateAcc.StateCommon.Border.Rounding = 7F;
            btnCreateAcc.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnCreateAcc.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnCreateAcc.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCreateAcc.TabIndex = 4;
            btnCreateAcc.Values.DropDownArrowColor = Color.Empty;
            btnCreateAcc.Values.Text = "Create Account";
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(75, 305);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 14;
            label5.Text = "Password";
            // 
            // txtRegPass
            // 
            txtRegPass.Cursor = Cursors.IBeam;
            txtRegPass.Location = new Point(75, 322);
            txtRegPass.Margin = new Padding(3, 2, 3, 2);
            txtRegPass.Multiline = true;
            txtRegPass.Name = "txtRegPass";
            txtRegPass.PasswordChar = '*';
            txtRegPass.Size = new Size(260, 34);
            txtRegPass.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtRegPass.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtRegPass.StateCommon.Border.Rounding = 7F;
            txtRegPass.StateCommon.Content.Color1 = Color.White;
            txtRegPass.StateCommon.Content.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegPass.StateCommon.Content.Padding = new Padding(2, 8, 2, 2);
            txtRegPass.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRegPass.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(75, 250);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 12;
            label4.Text = "Username";
            // 
            // txtRegUser
            // 
            txtRegUser.Cursor = Cursors.IBeam;
            txtRegUser.Location = new Point(75, 268);
            txtRegUser.Margin = new Padding(3, 2, 3, 2);
            txtRegUser.Multiline = true;
            txtRegUser.Name = "txtRegUser";
            txtRegUser.Size = new Size(260, 34);
            txtRegUser.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtRegUser.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtRegUser.StateCommon.Border.Rounding = 7F;
            txtRegUser.StateCommon.Content.Color1 = Color.White;
            txtRegUser.StateCommon.Content.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegUser.StateCommon.Content.Padding = new Padding(2, 8, 2, 2);
            txtRegUser.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRegUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(75, 196);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // txtRegEmail
            // 
            txtRegEmail.Cursor = Cursors.IBeam;
            txtRegEmail.Location = new Point(75, 213);
            txtRegEmail.Margin = new Padding(3, 2, 3, 2);
            txtRegEmail.Multiline = true;
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(260, 35);
            txtRegEmail.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtRegEmail.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtRegEmail.StateCommon.Border.Rounding = 7F;
            txtRegEmail.StateCommon.Content.Color1 = Color.White;
            txtRegEmail.StateCommon.Content.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegEmail.StateCommon.Content.Padding = new Padding(2, 8, 2, 2);
            txtRegEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRegEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 139);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // txtRegName
            // 
            txtRegName.Cursor = Cursors.IBeam;
            txtRegName.Location = new Point(75, 156);
            txtRegName.Margin = new Padding(3, 2, 3, 2);
            txtRegName.Multiline = true;
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(260, 36);
            txtRegName.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtRegName.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtRegName.StateCommon.Border.Rounding = 7F;
            txtRegName.StateCommon.Content.Color1 = Color.White;
            txtRegName.StateCommon.Content.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegName.StateCommon.Content.Padding = new Padding(2, 8, 2, 2);
            txtRegName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRegName.TabIndex = 0;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.BackColor = Color.Transparent;
            lblSignup.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.ForeColor = Color.White;
            lblSignup.Location = new Point(142, 100);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(117, 37);
            lblSignup.TabIndex = 6;
            lblSignup.Text = "Sign Up";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 553);
            Controls.Add(pnlSignUp);
            Controls.Add(pnlLogin);
<<<<<<< HEAD
            Icon = (Icon)resources.GetObject("$this.Icon");
=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StateCommon.Back.Color1 = Color.FromArgb(30, 30, 38);
            StateCommon.Back.Color2 = Color.FromArgb(30, 30, 38);
<<<<<<< HEAD
            Text = "CyberBites";
=======
            Text = "LoginForm";
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pnlLogin).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlSignUp).EndInit();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonPanel pnlLogin;
        private Krypton.Toolkit.KryptonPanel pnlSignUp;
        private Krypton.Toolkit.KryptonTextBox txtLoginUser;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Label label1;
        private Label lblUser;
        private Krypton.Toolkit.KryptonButton btnShowSignup;
        private Krypton.Toolkit.KryptonTextBox txtLoginPass;
        private Label lblPass;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox txtRegPass;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtRegUser;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox txtRegEmail;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox txtRegName;
        private Label lblSignup;
        private Krypton.Toolkit.KryptonButton btnCreateAcc;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonLinkLabel linkShowLogin;
    }
}
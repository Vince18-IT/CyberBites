namespace CyberBites
{
    partial class AccountPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPage));
            pnlWallet = new Krypton.Toolkit.KryptonPanel();
            lblNameUser = new Krypton.Toolkit.KryptonLabel();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            btnUploadPhoto = new Krypton.Toolkit.KryptonButton();
            imgAvatar = new Krypton.Toolkit.KryptonPictureBox();
            label1 = new Label();
            label3 = new Label();
            lblAccManage = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            txtSeatno = new Krypton.Toolkit.KryptonTextBox();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            btnSaveChanges = new Krypton.Toolkit.KryptonButton();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblItemName = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pnlWallet).BeginInit();
            pnlWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWallet
            // 
            pnlWallet.Controls.Add(lblNameUser);
            pnlWallet.Controls.Add(btnLogout);
            pnlWallet.Controls.Add(btnUploadPhoto);
            pnlWallet.Controls.Add(imgAvatar);
            pnlWallet.Controls.Add(label1);
            pnlWallet.Controls.Add(label3);
            pnlWallet.Location = new Point(24, 106);
            pnlWallet.Margin = new Padding(3, 2, 3, 2);
            pnlWallet.Name = "pnlWallet";
            pnlWallet.Padding = new Padding(18, 15, 18, 15);
            pnlWallet.Size = new Size(393, 351);
            pnlWallet.StateCommon.Color1 = Color.FromArgb(40, 40, 50);
            pnlWallet.StateCommon.Color2 = Color.FromArgb(40, 40, 50);
            pnlWallet.TabIndex = 16;
            // 
            // lblNameUser
            // 
            lblNameUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNameUser.AutoSize = false;
            lblNameUser.Location = new Point(108, 207);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(175, 34);
            lblNameUser.StateCommon.ShortText.Color1 = Color.White;
            lblNameUser.StateCommon.ShortText.Color2 = Color.White;
            lblNameUser.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNameUser.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblNameUser.TabIndex = 24;
            lblNameUser.Values.Text = "";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(77, 271);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(248, 51);
            btnLogout.StateCommon.Back.Color1 = Color.Red;
            btnLogout.StateCommon.Back.Color2 = Color.Red;
            btnLogout.StateCommon.Border.Color1 = Color.Red;
            btnLogout.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnLogout.StateCommon.Border.Rounding = 10F;
            btnLogout.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogout.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnLogout.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.TabIndex = 23;
            btnLogout.Values.DropDownArrowColor = Color.Empty;
            btnLogout.Values.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Cursor = Cursors.Hand;
            btnUploadPhoto.Location = new Point(132, 135);
            btnUploadPhoto.Margin = new Padding(3, 2, 3, 2);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.RightToLeft = RightToLeft.No;
            btnUploadPhoto.Size = new Size(126, 34);
            btnUploadPhoto.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateCommon.Border.Rounding = 10F;
            btnUploadPhoto.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnUploadPhoto.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnUploadPhoto.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUploadPhoto.StatePressed.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StatePressed.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateTracking.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.StateTracking.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnUploadPhoto.TabIndex = 21;
            btnUploadPhoto.Values.DropDownArrowColor = Color.Empty;
            btnUploadPhoto.Values.Text = "Upload Photo";
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // imgAvatar
            // 
            imgAvatar.Anchor = AnchorStyles.Top;
            imgAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            imgAvatar.Image = (Image)resources.GetObject("imgAvatar.Image");
            imgAvatar.Location = new Point(134, 12);
            imgAvatar.Name = "imgAvatar";
            imgAvatar.Size = new Size(120, 120);
            imgAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            imgAvatar.TabIndex = 15;
            imgAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(240, 540);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 14;
            label1.Text = "Items";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(240, 518);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 13;
            label3.Text = "Subtotal";
            // 
            // lblAccManage
            // 
            lblAccManage.AutoSize = true;
            lblAccManage.BackColor = Color.Transparent;
            lblAccManage.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAccManage.ForeColor = Color.White;
            lblAccManage.Location = new Point(24, 11);
            lblAccManage.Name = "lblAccManage";
            lblAccManage.Size = new Size(300, 37);
            lblAccManage.TabIndex = 17;
            lblAccManage.Text = "Account Management";
            lblAccManage.DoubleClick += lblAccManage_DoubleClick;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLinkLabel1);
            kryptonPanel1.Controls.Add(txtPassword);
            kryptonPanel1.Controls.Add(txtSeatno);
            kryptonPanel1.Controls.Add(txtUsername);
            kryptonPanel1.Controls.Add(txtEmail);
            kryptonPanel1.Controls.Add(txtName);
            kryptonPanel1.Controls.Add(btnSaveChanges);
            kryptonPanel1.Controls.Add(label8);
            kryptonPanel1.Controls.Add(label7);
            kryptonPanel1.Controls.Add(label6);
            kryptonPanel1.Controls.Add(label5);
            kryptonPanel1.Controls.Add(lblItemName);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Location = new Point(449, 106);
            kryptonPanel1.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(18, 15, 18, 15);
            kryptonPanel1.Size = new Size(462, 436);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.TabIndex = 18;
            // 
            // kryptonLinkLabel1
            // 
            kryptonLinkLabel1.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            kryptonLinkLabel1.Location = new Point(298, 316);
            kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            kryptonLinkLabel1.OverrideNotVisited.ShortText.Color1 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.OverrideNotVisited.ShortText.Color2 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.OverrideVisited.ShortText.Color1 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.OverrideVisited.ShortText.Color2 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.Size = new Size(144, 26);
            kryptonLinkLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(0, 173, 181);
            kryptonLinkLabel1.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLinkLabel1.TabIndex = 5;
            kryptonLinkLabel1.Values.Text = "Change Password";
            kryptonLinkLabel1.LinkClicked += kryptonLinkLabel1_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(21, 310);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(271, 41);
            txtPassword.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtPassword.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtPassword.StateCommon.Border.Rounding = 8F;
            txtPassword.StateCommon.Border.Width = 2;
            txtPassword.StateCommon.Content.Color1 = Color.White;
            txtPassword.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtPassword.StateCommon.Content.Padding = new Padding(1);
            txtPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtPassword.TabIndex = 4;
            // 
            // txtSeatno
            // 
            txtSeatno.Cursor = Cursors.IBeam;
            txtSeatno.Location = new Point(21, 244);
            txtSeatno.Multiline = true;
            txtSeatno.Name = "txtSeatno";
            txtSeatno.ReadOnly = true;
            txtSeatno.Size = new Size(424, 41);
            txtSeatno.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtSeatno.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtSeatno.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtSeatno.StateCommon.Border.Rounding = 8F;
            txtSeatno.StateCommon.Border.Width = 2;
            txtSeatno.StateCommon.Content.Color1 = Color.White;
            txtSeatno.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtSeatno.StateCommon.Content.Padding = new Padding(1);
            txtSeatno.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtSeatno.TabIndex = 3;
            txtSeatno.DoubleClick += txtSeatno_DoubleClick;
            // 
            // txtUsername
            // 
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(21, 179);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(424, 41);
            txtUsername.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtUsername.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtUsername.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtUsername.StateCommon.Border.Rounding = 8F;
            txtUsername.StateCommon.Border.Width = 2;
            txtUsername.StateCommon.Content.Color1 = Color.White;
            txtUsername.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtUsername.StateCommon.Content.Padding = new Padding(1);
            txtUsername.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(21, 111);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(424, 41);
            txtEmail.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtEmail.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtEmail.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtEmail.StateCommon.Border.Rounding = 8F;
            txtEmail.StateCommon.Border.Width = 2;
            txtEmail.StateCommon.Content.Color1 = Color.White;
            txtEmail.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtEmail.StateCommon.Content.Padding = new Padding(1);
            txtEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(21, 44);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(424, 41);
            txtName.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtName.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtName.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtName.StateCommon.Border.Rounding = 8F;
            txtName.StateCommon.Border.Width = 2;
            txtName.StateCommon.Content.Color1 = Color.White;
            txtName.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtName.StateCommon.Content.Padding = new Padding(1);
            txtName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtName.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.Location = new Point(25, 373);
            btnSaveChanges.Margin = new Padding(3, 2, 3, 2);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.RightToLeft = RightToLeft.No;
            btnSaveChanges.Size = new Size(420, 51);
            btnSaveChanges.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateCommon.Border.Rounding = 10F;
            btnSaveChanges.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnSaveChanges.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnSaveChanges.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveChanges.StatePressed.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StatePressed.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateTracking.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.StateTracking.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Values.DropDownArrowColor = Color.Empty;
            btnSaveChanges.Values.Text = "SAVE CHANGES";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(23, 222);
            label8.Name = "label8";
            label8.Size = new Size(253, 19);
            label8.TabIndex = 19;
            label8.Text = "Seat Number (Double Click to Change)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(25, 288);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 18;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(24, 154);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 17;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(25, 88);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 16;
            label5.Text = "Email Address";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.DarkGray;
            lblItemName.Location = new Point(26, 17);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(46, 19);
            lblItemName.TabIndex = 15;
            lblItemName.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(380, 700);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 14;
            label2.Text = "Items";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(380, 678);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 13;
            label4.Text = "Subtotal";
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 38);
            Controls.Add(kryptonPanel1);
            Controls.Add(lblAccManage);
            Controls.Add(pnlWallet);
            Name = "AccountPage";
            Size = new Size(962, 562);
            ((System.ComponentModel.ISupportInitialize)pnlWallet).EndInit();
            pnlWallet.ResumeLayout(false);
            pnlWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlWallet;
        private Label label1;
        private Label label3;
        private Label lblAccManage;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label2;
        private Label label4;
        private Label lblItemName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Krypton.Toolkit.KryptonButton btnSaveChanges;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.KryptonTextBox txtSeatno;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonButton btnUploadPhoto;
        private Krypton.Toolkit.KryptonPictureBox imgAvatar;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonLabel lblNameUser;
    }
}

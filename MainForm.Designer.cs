namespace Krypton_Test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flwSidebar = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnNavHome = new Krypton.Toolkit.KryptonButton();
            btnNavCart = new Krypton.Toolkit.KryptonButton();
            btnNavTopUp = new Krypton.Toolkit.KryptonButton();
            btnNavAccount = new Krypton.Toolkit.KryptonButton();
            pnlMainContent = new Panel();
            imgTopAvatar = new Krypton.Toolkit.KryptonPictureBox();
            panel1 = new Panel();
            lblTopName = new Label();
            flwSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgTopAvatar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flwSidebar
            // 
            flwSidebar.BackColor = Color.Black;
            flwSidebar.Controls.Add(pictureBox1);
            flwSidebar.Controls.Add(label1);
            flwSidebar.Controls.Add(btnNavHome);
            flwSidebar.Controls.Add(btnNavCart);
            flwSidebar.Controls.Add(btnNavTopUp);
            flwSidebar.Controls.Add(btnNavAccount);
            flwSidebar.Dock = DockStyle.Left;
            flwSidebar.Location = new Point(0, 0);
            flwSidebar.Margin = new Padding(3, 2, 3, 2);
            flwSidebar.Name = "flwSidebar";
            flwSidebar.Size = new Size(228, 553);
            flwSidebar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 13);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 10;
            label1.Text = "CyberBites";
            // 
            // btnNavHome
            // 
            btnNavHome.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btnNavHome.Cursor = Cursors.Hand;
            btnNavHome.Dock = DockStyle.Top;
            btnNavHome.Location = new Point(3, 59);
            btnNavHome.Margin = new Padding(3, 2, 3, 11);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            btnNavHome.Size = new Size(225, 63);
            btnNavHome.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavHome.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNavHome.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavHome.StateCommon.Border.Width = 0;
            btnNavHome.StateCommon.Content.AdjacentGap = 5;
            btnNavHome.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnNavHome.StateCommon.Content.Image.ImageColorMap = Color.Black;
            btnNavHome.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnNavHome.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavHome.StateCommon.Content.Padding = new Padding(20, 0, 0, 0);
            btnNavHome.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavHome.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNavHome.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavHome.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavHome.StateNormal.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.GrayScale;
            btnNavHome.StateTracking.Back.Color1 = Color.FromArgb(45, 45, 55);
            btnNavHome.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavHome.StateTracking.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnNavHome.StateTracking.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnNavHome.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavHome.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnNavHome.StateTracking.Border.Rounding = 3F;
            btnNavHome.StateTracking.Border.Width = 5;
            btnNavHome.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNavHome.StateTracking.Content.ShortText.Color2 = Color.White;
            btnNavHome.TabIndex = 11;
            btnNavHome.Values.DropDownArrowColor = Color.Empty;
            btnNavHome.Values.Image = (Image)resources.GetObject("btnNavHome.Values.Image");
            btnNavHome.Values.Text = "Home";
            btnNavHome.Click += btnNavHome_Click;
            // 
            // btnNavCart
            // 
            btnNavCart.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btnNavCart.Cursor = Cursors.Hand;
            btnNavCart.Dock = DockStyle.Top;
            btnNavCart.Location = new Point(3, 135);
            btnNavCart.Margin = new Padding(3, 2, 3, 11);
            btnNavCart.Name = "btnNavCart";
            btnNavCart.Size = new Size(225, 63);
            btnNavCart.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavCart.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNavCart.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavCart.StateCommon.Border.Width = 0;
            btnNavCart.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnNavCart.StateCommon.Content.Image.ImageColorMap = Color.Black;
            btnNavCart.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnNavCart.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavCart.StateCommon.Content.Padding = new Padding(20, 0, 0, 0);
            btnNavCart.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavCart.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNavCart.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavCart.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavCart.StateNormal.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnNavCart.StateNormal.Content.Image.ImageColorMap = Color.Black;
            btnNavCart.StateNormal.Content.Image.ImageColorTo = Color.White;
            btnNavCart.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavCart.StateTracking.Back.Color1 = Color.FromArgb(45, 45, 55);
            btnNavCart.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavCart.StateTracking.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnNavCart.StateTracking.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnNavCart.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavCart.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnNavCart.StateTracking.Border.Rounding = 3F;
            btnNavCart.StateTracking.Border.Width = 5;
            btnNavCart.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNavCart.StateTracking.Content.ShortText.Color2 = Color.White;
            btnNavCart.TabIndex = 12;
            btnNavCart.Values.DropDownArrowColor = Color.Empty;
            btnNavCart.Values.Image = (Image)resources.GetObject("btnNavCart.Values.Image");
            btnNavCart.Values.Text = "Cart";
            btnNavCart.Click += btnNavCart_Click;
            // 
            // btnNavTopUp
            // 
            btnNavTopUp.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btnNavTopUp.Cursor = Cursors.Hand;
            btnNavTopUp.Dock = DockStyle.Top;
            btnNavTopUp.Location = new Point(3, 211);
            btnNavTopUp.Margin = new Padding(3, 2, 3, 11);
            btnNavTopUp.Name = "btnNavTopUp";
            btnNavTopUp.Size = new Size(225, 63);
            btnNavTopUp.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavTopUp.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNavTopUp.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavTopUp.StateCommon.Border.Width = 0;
            btnNavTopUp.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnNavTopUp.StateCommon.Content.Image.ImageColorMap = Color.Black;
            btnNavTopUp.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnNavTopUp.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavTopUp.StateCommon.Content.Padding = new Padding(20, 0, 0, 0);
            btnNavTopUp.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavTopUp.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNavTopUp.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavTopUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavTopUp.StateNormal.Content.Image.ImageColorMap = Color.Black;
            btnNavTopUp.StateNormal.Content.Image.ImageColorTo = Color.White;
            btnNavTopUp.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavTopUp.StateTracking.Back.Color1 = Color.FromArgb(45, 45, 55);
            btnNavTopUp.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavTopUp.StateTracking.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnNavTopUp.StateTracking.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnNavTopUp.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavTopUp.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnNavTopUp.StateTracking.Border.Rounding = 3F;
            btnNavTopUp.StateTracking.Border.Width = 5;
            btnNavTopUp.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNavTopUp.StateTracking.Content.ShortText.Color2 = Color.White;
            btnNavTopUp.TabIndex = 13;
            btnNavTopUp.Values.DropDownArrowColor = Color.Empty;
            btnNavTopUp.Values.Image = (Image)resources.GetObject("btnNavTopUp.Values.Image");
            btnNavTopUp.Values.Text = "Top-up";
            btnNavTopUp.Click += btnNavTopup_Click;
            // 
            // btnNavAccount
            // 
            btnNavAccount.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btnNavAccount.Cursor = Cursors.Hand;
            btnNavAccount.Dock = DockStyle.Top;
            btnNavAccount.Location = new Point(3, 287);
            btnNavAccount.Margin = new Padding(3, 2, 3, 11);
            btnNavAccount.Name = "btnNavAccount";
            btnNavAccount.Size = new Size(225, 63);
            btnNavAccount.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavAccount.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNavAccount.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavAccount.StateCommon.Border.Width = 0;
            btnNavAccount.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Normal;
            btnNavAccount.StateCommon.Content.Image.ImageColorMap = Color.Black;
            btnNavAccount.StateCommon.Content.Image.ImageColorTo = Color.White;
            btnNavAccount.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavAccount.StateCommon.Content.Padding = new Padding(20, 0, 0, 0);
            btnNavAccount.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavAccount.StateCommon.Content.ShortText.Color2 = Color.White;
            btnNavAccount.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavAccount.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnNavAccount.StateTracking.Back.Color1 = Color.FromArgb(45, 45, 55);
            btnNavAccount.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnNavAccount.StateTracking.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnNavAccount.StateTracking.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnNavAccount.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnNavAccount.StateTracking.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            btnNavAccount.StateTracking.Border.Rounding = 3F;
            btnNavAccount.StateTracking.Border.Width = 5;
            btnNavAccount.StateTracking.Content.ShortText.Color1 = Color.White;
            btnNavAccount.StateTracking.Content.ShortText.Color2 = Color.White;
            btnNavAccount.TabIndex = 14;
            btnNavAccount.Values.DropDownArrowColor = Color.Empty;
            btnNavAccount.Values.Image = (Image)resources.GetObject("btnNavAccount.Values.Image");
            btnNavAccount.Values.Text = "Account Profile";
            btnNavAccount.Click += btnNavAccount_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.Transparent;
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(228, 0);
            pnlMainContent.Margin = new Padding(3, 2, 3, 2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(981, 553);
            pnlMainContent.TabIndex = 3;
            // 
            // imgTopAvatar
            // 
            imgTopAvatar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            imgTopAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            imgTopAvatar.Image = (Image)resources.GetObject("imgTopAvatar.Image");
            imgTopAvatar.Location = new Point(8, -1);
            imgTopAvatar.Name = "imgTopAvatar";
            imgTopAvatar.Size = new Size(50, 50);
            imgTopAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            imgTopAvatar.TabIndex = 16;
            imgTopAvatar.TabStop = false;
            imgTopAvatar.Click += imgTopAvatar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 38);
            panel1.Controls.Add(lblTopName);
            panel1.Controls.Add(imgTopAvatar);
            panel1.Location = new Point(964, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 50);
            panel1.TabIndex = 5;
            // 
            // lblTopName
            // 
            lblTopName.BackColor = Color.Transparent;
            lblTopName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTopName.ForeColor = Color.White;
            lblTopName.Location = new Point(64, 13);
            lblTopName.Name = "lblTopName";
            lblTopName.Size = new Size(145, 25);
            lblTopName.TabIndex = 17;
            lblTopName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 553);
            Controls.Add(panel1);
            Controls.Add(pnlMainContent);
            Controls.Add(flwSidebar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlackDarkMode;
            StateCommon.Back.Color1 = Color.FromArgb(30, 30, 38);
            StateCommon.Back.Color2 = Color.FromArgb(30, 30, 38);
            Text = "CyberBites";
            flwSidebar.ResumeLayout(false);
            flwSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgTopAvatar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private FlowLayoutPanel flwSidebar;
        private PictureBox pictureBox1;
        private Label label1;
        private Krypton.Toolkit.KryptonButton btnNavHome;
        private Krypton.Toolkit.KryptonButton btnNavCart;
        private Krypton.Toolkit.KryptonButton btnNavTopUp;
        private Krypton.Toolkit.KryptonButton btnNavAccount;
        private Panel pnlMainContent;
        private Krypton.Toolkit.KryptonPictureBox imgTopAvatar;
        private Panel panel1;
        private Label lblTopName;
    }
}
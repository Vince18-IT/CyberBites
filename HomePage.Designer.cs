namespace Krypton_Test
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new Panel();
            lblBalance = new Label();
            txtSearchbar = new Krypton.Toolkit.KryptonTextBox();
            buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            flowLayoutPanel1 = new FlowLayoutPanel();
            itemCard1 = new ItemCard();
            itemCard2 = new ItemCard();
            itemCard3 = new ItemCard();
            itemCard4 = new ItemCard();
            itemCard5 = new ItemCard();
            itemCard6 = new ItemCard();
            itemCard7 = new ItemCard();
            itemCard8 = new ItemCard();
            itemCard10 = new ItemCard();
            itemCard9 = new ItemCard();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(txtSearchbar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 52);
            panel1.TabIndex = 0;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(406, 14);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(145, 25);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Balance : ₱0.00";
            lblBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearchbar
            // 
            txtSearchbar.Anchor = AnchorStyles.None;
            txtSearchbar.ButtonSpecs.Add(buttonSpecAny1);
            txtSearchbar.Location = new Point(68, 12);
            txtSearchbar.Margin = new Padding(3, 2, 3, 2);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Size = new Size(284, 32);
            txtSearchbar.StateCommon.Back.Color1 = Color.FromArgb(30, 30, 38);
            txtSearchbar.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtSearchbar.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtSearchbar.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            txtSearchbar.StateCommon.Border.Rounding = 15F;
            txtSearchbar.StateCommon.Content.Color1 = Color.White;
            txtSearchbar.StateCommon.Content.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchbar.StateCommon.Content.Padding = new Padding(5, -1, -1, -1);
            txtSearchbar.TabIndex = 0;
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            // 
            // buttonSpecAny1
            // 
            buttonSpecAny1.ColorMap = Color.Black;
            buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            buttonSpecAny1.Image = (Image)resources.GetObject("buttonSpecAny1.Image");
            buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.InputControl;
            buttonSpecAny1.UniqueName = "f902b4076a6248cfbbed3d6b87ada9ac";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(itemCard1);
            flowLayoutPanel1.Controls.Add(itemCard2);
            flowLayoutPanel1.Controls.Add(itemCard3);
            flowLayoutPanel1.Controls.Add(itemCard4);
            flowLayoutPanel1.Controls.Add(itemCard5);
            flowLayoutPanel1.Controls.Add(itemCard6);
            flowLayoutPanel1.Controls.Add(itemCard7);
            flowLayoutPanel1.Controls.Add(itemCard8);
            flowLayoutPanel1.Controls.Add(itemCard10);
            flowLayoutPanel1.Controls.Add(itemCard9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 52);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(18, 15, 18, 15);
            flowLayoutPanel1.Size = new Size(962, 510);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // itemCard1
            // 
            itemCard1.BackColor = Color.FromArgb(40, 40, 50);
            itemCard1.ItemImage = (Image)resources.GetObject("itemCard1.ItemImage");
            itemCard1.ItemName = "Pancit Canton";
            itemCard1.ItemPrice = "₱25.00";
            itemCard1.Location = new Point(66, 30);
            itemCard1.Margin = new Padding(48, 15, 18, 15);
            itemCard1.Name = "itemCard1";
            itemCard1.Size = new Size(181, 202);
            itemCard1.TabIndex = 0;
            // 
            // itemCard2
            // 
            itemCard2.BackColor = Color.FromArgb(40, 40, 50);
            itemCard2.ItemImage = (Image)resources.GetObject("itemCard2.ItemImage");
            itemCard2.ItemName = "Cup Noodles";
            itemCard2.ItemPrice = "₱30.00";
            itemCard2.Location = new Point(283, 30);
            itemCard2.Margin = new Padding(18, 15, 18, 15);
            itemCard2.Name = "itemCard2";
            itemCard2.Size = new Size(181, 202);
            itemCard2.TabIndex = 1;
            // 
            // itemCard3
            // 
            itemCard3.BackColor = Color.FromArgb(40, 40, 50);
            itemCard3.ItemImage = (Image)resources.GetObject("itemCard3.ItemImage");
            itemCard3.ItemName = "Siomai Rice";
            itemCard3.ItemPrice = "₱70.00";
            itemCard3.Location = new Point(500, 30);
            itemCard3.Margin = new Padding(18, 15, 18, 15);
            itemCard3.Name = "itemCard3";
            itemCard3.Size = new Size(181, 202);
            itemCard3.TabIndex = 2;
            itemCard3.Load += itemCard3_Load;
            // 
            // itemCard4
            // 
            itemCard4.BackColor = Color.FromArgb(40, 40, 50);
            itemCard4.ItemImage = (Image)resources.GetObject("itemCard4.ItemImage");
            itemCard4.ItemName = "Tempura (3pcs)";
            itemCard4.ItemPrice = "₱25.00";
            itemCard4.Location = new Point(717, 30);
            itemCard4.Margin = new Padding(18, 15, 18, 15);
            itemCard4.Name = "itemCard4";
            itemCard4.Size = new Size(181, 202);
            itemCard4.TabIndex = 3;
            // 
            // itemCard5
            // 
            itemCard5.BackColor = Color.FromArgb(40, 40, 50);
            itemCard5.ItemImage = (Image)resources.GetObject("itemCard5.ItemImage");
            itemCard5.ItemName = "French Fries";
            itemCard5.ItemPrice = "₱40.00";
            itemCard5.Location = new Point(66, 262);
            itemCard5.Margin = new Padding(48, 15, 18, 15);
            itemCard5.Name = "itemCard5";
            itemCard5.Size = new Size(181, 202);
            itemCard5.TabIndex = 4;
            // 
            // itemCard6
            // 
            itemCard6.BackColor = Color.FromArgb(40, 40, 50);
            itemCard6.ItemImage = (Image)resources.GetObject("itemCard6.ItemImage");
            itemCard6.ItemName = "Bottled Water";
            itemCard6.ItemPrice = "₱20.00";
            itemCard6.Location = new Point(283, 262);
            itemCard6.Margin = new Padding(18, 15, 18, 15);
            itemCard6.Name = "itemCard6";
            itemCard6.Size = new Size(181, 202);
            itemCard6.TabIndex = 5;
            // 
            // itemCard7
            // 
            itemCard7.BackColor = Color.FromArgb(40, 40, 50);
            itemCard7.ItemImage = (Image)resources.GetObject("itemCard7.ItemImage");
            itemCard7.ItemName = "Cobra Energy Drink";
            itemCard7.ItemPrice = "₱25.00";
            itemCard7.Location = new Point(500, 262);
            itemCard7.Margin = new Padding(18, 15, 18, 15);
            itemCard7.Name = "itemCard7";
            itemCard7.Size = new Size(181, 202);
            itemCard7.TabIndex = 6;
            // 
            // itemCard8
            // 
            itemCard8.BackColor = Color.FromArgb(40, 40, 50);
            itemCard8.ItemImage = (Image)resources.GetObject("itemCard8.ItemImage");
            itemCard8.ItemName = "Softdrinks";
            itemCard8.ItemPrice = "₱45.00";
            itemCard8.Location = new Point(717, 262);
            itemCard8.Margin = new Padding(18, 15, 18, 15);
            itemCard8.Name = "itemCard8";
            itemCard8.Size = new Size(181, 202);
            itemCard8.TabIndex = 7;
            // 
            // itemCard10
            // 
            itemCard10.BackColor = Color.FromArgb(40, 40, 50);
            itemCard10.ItemImage = (Image)resources.GetObject("itemCard10.ItemImage");
            itemCard10.ItemName = "Coffee";
            itemCard10.ItemPrice = "₱15.00";
            itemCard10.Location = new Point(66, 494);
            itemCard10.Margin = new Padding(48, 15, 18, 22);
            itemCard10.Name = "itemCard10";
            itemCard10.Size = new Size(181, 202);
            itemCard10.TabIndex = 9;
            // 
            // itemCard9
            // 
            itemCard9.BackColor = Color.FromArgb(40, 40, 50);
            itemCard9.ItemImage = (Image)resources.GetObject("itemCard9.ItemImage");
            itemCard9.ItemName = "Yakult";
            itemCard9.ItemPrice = "₱15.00";
            itemCard9.Location = new Point(283, 494);
            itemCard9.Margin = new Padding(18, 15, 18, 22);
            itemCard9.Name = "itemCard9";
            itemCard9.Size = new Size(181, 202);
            itemCard9.TabIndex = 8;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 38);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Size = new Size(962, 562);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox txtSearchbar;
        private FlowLayoutPanel flowLayoutPanel1;
        private ItemCard itemCard1;
        private ItemCard itemCard2;
        private ItemCard itemCard3;
        private ItemCard itemCard4;
        private ItemCard itemCard5;
        private ItemCard itemCard6;
        private ItemCard itemCard7;
        private ItemCard itemCard10;
        private ItemCard itemCard9;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ItemCard itemCard8;
        private Label lblBalance;
    }
}

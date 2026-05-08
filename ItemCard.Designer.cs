<<<<<<< HEAD
﻿namespace CyberBites
=======
﻿namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    partial class ItemCard
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
            picItemImage = new PictureBox();
            lblItemName = new Label();
            lblPrice = new Label();
            btnAddCart = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)picItemImage).BeginInit();
            SuspendLayout();
            // 
            // picItemImage
            // 
            picItemImage.Dock = DockStyle.Top;
            picItemImage.Location = new Point(0, 0);
            picItemImage.Margin = new Padding(3, 2, 3, 2);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(176, 112);
            picItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            picItemImage.TabIndex = 0;
            picItemImage.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.Left;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(2, 116);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(95, 21);
            lblItemName.TabIndex = 11;
            lblItemName.Text = "Item Name";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.LightGray;
            lblPrice.Location = new Point(3, 138);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 19);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "₱0.00";
            // 
            // btnAddCart
            // 
            btnAddCart.Cursor = Cursors.Hand;
            btnAddCart.Location = new Point(5, 162);
            btnAddCart.Margin = new Padding(3, 2, 3, 2);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.OverrideDefault.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnAddCart.OverrideDefault.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnAddCart.RightToLeft = RightToLeft.No;
            btnAddCart.Size = new Size(164, 28);
            btnAddCart.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnAddCart.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnAddCart.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnAddCart.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnAddCart.StateCommon.Border.Rounding = 7F;
            btnAddCart.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddCart.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddCart.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAddCart.TabIndex = 13;
            btnAddCart.Values.DropDownArrowColor = Color.Empty;
            btnAddCart.Values.Text = "Add";
            btnAddCart.Click += btnAddCart_Click;
            // 
            // ItemCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            Controls.Add(btnAddCart);
            Controls.Add(lblPrice);
            Controls.Add(lblItemName);
            Controls.Add(picItemImage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ItemCard";
            Size = new Size(176, 195);
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picItemImage;
        private Label lblItemName;
        private Label lblPrice;
       
        private Krypton.Toolkit.KryptonButton btnAddCart;
    }
}

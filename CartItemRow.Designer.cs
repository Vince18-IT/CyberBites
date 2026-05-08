<<<<<<< HEAD
﻿namespace CyberBites
=======
﻿namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    partial class CartItemRow
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
            picAddeditem = new Krypton.Toolkit.KryptonPictureBox();
            lblItemName = new Label();
            lblCartPrice = new Label();
            btnSubtract = new Krypton.Toolkit.KryptonButton();
            btnRemove = new Krypton.Toolkit.KryptonButton();
            btnAdd = new Krypton.Toolkit.KryptonButton();
            lblQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)picAddeditem).BeginInit();
            SuspendLayout();
            // 
            // picAddeditem
            // 
            picAddeditem.Location = new Point(4, 7);
            picAddeditem.Margin = new Padding(3, 2, 3, 2);
            picAddeditem.Name = "picAddeditem";
            picAddeditem.Size = new Size(60, 49);
            picAddeditem.SizeMode = PictureBoxSizeMode.Zoom;
            picAddeditem.TabIndex = 0;
            picAddeditem.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.Left;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(66, 12);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(83, 19);
            lblItemName.TabIndex = 12;
            lblItemName.Text = "Item Name";
            // 
            // lblCartPrice
            // 
            lblCartPrice.Anchor = AnchorStyles.Left;
            lblCartPrice.AutoSize = true;
            lblCartPrice.BackColor = Color.Transparent;
            lblCartPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartPrice.ForeColor = Color.FromArgb(0, 173, 181);
            lblCartPrice.Location = new Point(66, 29);
            lblCartPrice.Name = "lblCartPrice";
            lblCartPrice.Size = new Size(46, 19);
            lblCartPrice.TabIndex = 13;
            lblCartPrice.Text = "₱0.00";
            // 
            // btnSubtract
            // 
            btnSubtract.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.Location = new Point(474, 12);
            btnSubtract.Margin = new Padding(3, 2, 3, 2);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.OverrideDefault.Back.Color1 = Color.FromArgb(50, 50, 60);
            btnSubtract.OverrideDefault.Back.Color2 = Color.FromArgb(50, 50, 60);
            btnSubtract.Size = new Size(43, 32);
            btnSubtract.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            btnSubtract.StateCommon.Back.Color2 = Color.FromArgb(50, 50, 60);
            btnSubtract.StateCommon.Border.Color1 = Color.FromArgb(50, 50, 60);
            btnSubtract.StateCommon.Border.Color2 = Color.FromArgb(50, 50, 60);
            btnSubtract.StateCommon.Border.Rounding = 8F;
            btnSubtract.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSubtract.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSubtract.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubtract.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnSubtract.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnSubtract.TabIndex = 14;
            btnSubtract.Values.DropDownArrowColor = Color.Empty;
            btnSubtract.Values.Text = "-";
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.Location = new Point(644, 18);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.OverrideDefault.Back.Color1 = Color.FromArgb(85, 45, 45);
            btnRemove.OverrideDefault.Back.Color2 = Color.FromArgb(85, 45, 45);
            btnRemove.Size = new Size(112, 26);
            btnRemove.StateCommon.Back.Color1 = Color.FromArgb(85, 45, 45);
            btnRemove.StateCommon.Back.Color2 = Color.FromArgb(85, 45, 45);
            btnRemove.StateCommon.Border.Color1 = Color.FromArgb(85, 45, 45);
            btnRemove.StateCommon.Border.Color2 = Color.FromArgb(85, 45, 45);
            btnRemove.StateCommon.Border.Rounding = 8F;
            btnRemove.StateCommon.Content.ShortText.Color1 = Color.Red;
            btnRemove.StateCommon.Content.ShortText.Color2 = Color.Red;
            btnRemove.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnRemove.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnRemove.TabIndex = 15;
            btnRemove.Values.DropDownArrowColor = Color.Empty;
            btnRemove.Values.Text = "Remove";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(553, 12);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.OverrideDefault.Back.Color1 = Color.FromArgb(50, 50, 60);
            btnAdd.OverrideDefault.Back.Color2 = Color.FromArgb(50, 50, 60);
            btnAdd.Size = new Size(41, 32);
            btnAdd.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            btnAdd.StateCommon.Back.Color2 = Color.FromArgb(50, 50, 60);
            btnAdd.StateCommon.Border.Color1 = Color.FromArgb(50, 50, 60);
            btnAdd.StateCommon.Border.Color2 = Color.FromArgb(50, 50, 60);
            btnAdd.StateCommon.Border.Rounding = 8F;
            btnAdd.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAdd.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnAdd.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnAdd.TabIndex = 16;
            btnAdd.Values.DropDownArrowColor = Color.Empty;
            btnAdd.Values.Text = "+";
            btnAdd.Click += btnAdd_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(527, 20);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(17, 19);
            lblQuantity.TabIndex = 17;
            lblQuantity.Text = "1";
            // 
            // CartItemRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 50);
            Controls.Add(lblQuantity);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(btnSubtract);
            Controls.Add(lblCartPrice);
            Controls.Add(lblItemName);
            Controls.Add(picAddeditem);
            Margin = new Padding(5, 0, 0, 5);
            Name = "CartItemRow";
            Size = new Size(775, 60);
            ((System.ComponentModel.ISupportInitialize)picAddeditem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox picAddeditem;
        private Label lblItemName;
        private Label lblCartPrice;
        private Krypton.Toolkit.KryptonButton btnSubtract;
        private Krypton.Toolkit.KryptonButton btnRemove;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Label lblQuantity;
    }
}

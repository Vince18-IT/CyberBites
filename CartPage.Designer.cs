<<<<<<< HEAD
﻿namespace CyberBites
=======
﻿namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    partial class CartPage
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
            lblBalance = new Label();
            pnlCart = new Krypton.Toolkit.KryptonPanel();
            lblCartBalance = new Label();
            label3 = new Label();
            btnProceedCheckout = new Krypton.Toolkit.KryptonButton();
            lblTotal = new Label();
            lblItems = new Label();
            lblSubtotal = new Label();
            label2 = new Label();
            label1 = new Label();
            lblItemName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pnlCart).BeginInit();
            pnlCart.SuspendLayout();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = Color.Transparent;
            lblBalance.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(88, 18);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(149, 41);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Your Cart";
            // 
            // pnlCart
            // 
            pnlCart.Controls.Add(lblCartBalance);
            pnlCart.Controls.Add(label3);
            pnlCart.Controls.Add(btnProceedCheckout);
            pnlCart.Controls.Add(lblTotal);
            pnlCart.Controls.Add(lblItems);
            pnlCart.Controls.Add(lblSubtotal);
            pnlCart.Controls.Add(label2);
            pnlCart.Controls.Add(label1);
            pnlCart.Controls.Add(lblItemName);
            pnlCart.Controls.Add(flowLayoutPanel1);
            pnlCart.Location = new Point(88, 58);
            pnlCart.Margin = new Padding(3, 2, 3, 2);
            pnlCart.Name = "pnlCart";
            pnlCart.Padding = new Padding(18, 15, 18, 15);
            pnlCart.Size = new Size(826, 488);
            pnlCart.StateCommon.Color1 = Color.FromArgb(40, 40, 50);
            pnlCart.StateCommon.Color2 = Color.FromArgb(40, 40, 50);
            pnlCart.TabIndex = 8;
            // 
            // lblCartBalance
            // 
            lblCartBalance.BackColor = Color.Transparent;
            lblCartBalance.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCartBalance.ForeColor = Color.White;
            lblCartBalance.Location = new Point(580, 418);
            lblCartBalance.Name = "lblCartBalance";
            lblCartBalance.Size = new Size(232, 28);
            lblCartBalance.TabIndex = 20;
            lblCartBalance.Text = "₱0.00";
            lblCartBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 418);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 19;
            label3.Text = "Current Balance";
            // 
            // btnProceedCheckout
            // 
            btnProceedCheckout.Cursor = Cursors.Hand;
            btnProceedCheckout.Location = new Point(186, 448);
            btnProceedCheckout.Margin = new Padding(3, 2, 3, 2);
            btnProceedCheckout.Name = "btnProceedCheckout";
            btnProceedCheckout.OverrideDefault.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.OverrideDefault.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.RightToLeft = RightToLeft.No;
            btnProceedCheckout.Size = new Size(476, 34);
            btnProceedCheckout.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnProceedCheckout.StateCommon.Border.Rounding = 7F;
            btnProceedCheckout.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnProceedCheckout.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnProceedCheckout.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProceedCheckout.TabIndex = 18;
            btnProceedCheckout.Values.DropDownArrowColor = Color.Empty;
            btnProceedCheckout.Values.Text = "PROCEED TO CHECKOUT";
            btnProceedCheckout.Click += btnProceedCheckout_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 173, 181);
            lblTotal.Location = new Point(580, 393);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(229, 26);
            lblTotal.TabIndex = 17;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItems
            // 
            lblItems.BackColor = Color.Transparent;
            lblItems.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.ForeColor = Color.White;
            lblItems.Location = new Point(718, 375);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(90, 17);
            lblItems.TabIndex = 16;
            lblItems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(718, 353);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(90, 26);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 391);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 9;
            label2.Text = "Total";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(18, 375);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 14;
            label1.Text = "Items";
            // 
            // lblItemName
            // 
            lblItemName.Anchor = AnchorStyles.None;
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.Gray;
            lblItemName.Location = new Point(18, 353);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(62, 19);
            lblItemName.TabIndex = 13;
            lblItemName.Text = "Subtotal";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(18, 15);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(790, 330);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 38);
            Controls.Add(pnlCart);
            Controls.Add(lblBalance);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CartPage";
            Size = new Size(962, 562);
            ((System.ComponentModel.ISupportInitialize)pnlCart).EndInit();
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Krypton.Toolkit.KryptonPanel pnlCart;
        private Label label1;
        private Label lblItemName;
        private Label label2;
        private Label lblTotal;
        private Label lblItems;
        private Label lblSubtotal;
        private Krypton.Toolkit.KryptonButton btnProceedCheckout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCartBalance;
        private Label label3;
    }
}

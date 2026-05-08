<<<<<<< HEAD
﻿namespace CyberBites
=======
﻿namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    partial class SeatNumberModal
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatNumberModal));
=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnSaveSeatno = new Krypton.Toolkit.KryptonButton();
            txtSeatInput = new Krypton.Toolkit.KryptonTextBox();
            btnSaveChanges = new Krypton.Toolkit.KryptonButton();
            label = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnSaveSeatno);
            kryptonPanel1.Controls.Add(txtSeatInput);
            kryptonPanel1.Controls.Add(btnSaveChanges);
            kryptonPanel1.Controls.Add(label);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(18, 15, 18, 15);
            kryptonPanel1.Size = new Size(469, 333);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.TabIndex = 20;
            // 
            // btnSaveSeatno
            // 
            btnSaveSeatno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveSeatno.Cursor = Cursors.Hand;
            btnSaveSeatno.Location = new Point(149, 197);
            btnSaveSeatno.Margin = new Padding(3, 2, 3, 2);
            btnSaveSeatno.Name = "btnSaveSeatno";
            btnSaveSeatno.RightToLeft = RightToLeft.No;
            btnSaveSeatno.Size = new Size(181, 51);
            btnSaveSeatno.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveSeatno.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveSeatno.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnSaveSeatno.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnSaveSeatno.StateCommon.Border.Rounding = 10F;
            btnSaveSeatno.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnSaveSeatno.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnSaveSeatno.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveSeatno.TabIndex = 29;
            btnSaveSeatno.Values.DropDownArrowColor = Color.Empty;
            btnSaveSeatno.Values.Text = "Save";
            btnSaveSeatno.Click += btnSaveSeatno_Click;
            // 
            // txtSeatInput
            // 
            txtSeatInput.Cursor = Cursors.IBeam;
            txtSeatInput.Location = new Point(45, 116);
            txtSeatInput.Multiline = true;
            txtSeatInput.Name = "txtSeatInput";
            txtSeatInput.Size = new Size(393, 50);
            txtSeatInput.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtSeatInput.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtSeatInput.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtSeatInput.StateCommon.Border.Rounding = 8F;
            txtSeatInput.StateCommon.Border.Width = 2;
            txtSeatInput.StateCommon.Content.Color1 = Color.White;
            txtSeatInput.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtSeatInput.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtSeatInput.TabIndex = 28;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.Location = new Point(728, 813);
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
            btnSaveChanges.TabIndex = 20;
            btnSaveChanges.Values.DropDownArrowColor = Color.Empty;
            btnSaveChanges.Values.Text = "SAVE CHANGES";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(115, 59);
            label.Name = "label";
            label.Size = new Size(253, 30);
            label.TabIndex = 15;
            label.Text = "Input your Seat Number";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(749, 934);
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
            label4.Location = new Point(749, 912);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 13;
            label4.Text = "Subtotal";
            // 
            // SeatNumberModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 333);
            Controls.Add(kryptonPanel1);
<<<<<<< HEAD
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SeatNumberModal";
            Text = "Seat Number";
=======
            Name = "SeatNumberModal";
            Text = "SeatNumberModal";
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonTextBox txtSeatInput;
        private Krypton.Toolkit.KryptonButton btnSaveChanges;
        private Label label;
        private Label label2;
        private Label label4;
        private Krypton.Toolkit.KryptonButton btnSaveSeatno;
    }
}
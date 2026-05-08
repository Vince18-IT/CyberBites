namespace Krypton_Test
{
    partial class ChangePasswordModal
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            btnSave = new Krypton.Toolkit.KryptonButton();
            txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            txtCurrentPassword = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            btnSaveChanges = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            label = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnCancel);
            kryptonPanel1.Controls.Add(kryptonCheckBox1);
            kryptonPanel1.Controls.Add(btnSave);
            kryptonPanel1.Controls.Add(txtConfirmPassword);
            kryptonPanel1.Controls.Add(txtNewPassword);
            kryptonPanel1.Controls.Add(txtCurrentPassword);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(btnSaveChanges);
            kryptonPanel1.Controls.Add(label5);
            kryptonPanel1.Controls.Add(label);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Location = new Point(-1, -2);
            kryptonPanel1.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new Padding(18, 15, 18, 15);
            kryptonPanel1.Size = new Size(470, 337);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(40, 40, 50);
            kryptonPanel1.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(247, 265);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(181, 51);
            btnCancel.StateCommon.Back.Color1 = Color.DarkGray;
            btnCancel.StateCommon.Back.Color2 = Color.DarkGray;
            btnCancel.StateCommon.Border.Color1 = Color.DarkGray;
            btnCancel.StateCommon.Border.Color2 = Color.DarkGray;
            btnCancel.StateCommon.Border.Rounding = 10F;
            btnCancel.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnCancel.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnCancel.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.TabIndex = 31;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += kryptonButton1_Click;
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new Point(28, 235);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new Size(118, 25);
            kryptonCheckBox1.StateCommon.ShortText.Color1 = Color.White;
            kryptonCheckBox1.StateCommon.ShortText.Color2 = Color.White;
            kryptonCheckBox1.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCheckBox1.TabIndex = 30;
            kryptonCheckBox1.Values.Text = "Show Password";
            kryptonCheckBox1.CheckedChanged += kryptonCheckBox1_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(31, 265);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(181, 51);
            btnSave.StateCommon.Back.Color1 = Color.FromArgb(0, 173, 181);
            btnSave.StateCommon.Back.Color2 = Color.FromArgb(0, 173, 181);
            btnSave.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            btnSave.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            btnSave.StateCommon.Border.Rounding = 10F;
            btnSave.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnSave.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnSave.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSave.TabIndex = 29;
            btnSave.Values.DropDownArrowColor = Color.Empty;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnChangepass_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Cursor = Cursors.IBeam;
            txtConfirmPassword.Location = new Point(21, 189);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(424, 41);
            txtConfirmPassword.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtConfirmPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtConfirmPassword.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtConfirmPassword.StateCommon.Border.Rounding = 8F;
            txtConfirmPassword.StateCommon.Border.Width = 2;
            txtConfirmPassword.StateCommon.Content.Color1 = Color.White;
            txtConfirmPassword.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtConfirmPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtConfirmPassword.TabIndex = 28;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Cursor = Cursors.IBeam;
            txtNewPassword.Location = new Point(21, 121);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(424, 41);
            txtNewPassword.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtNewPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtNewPassword.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtNewPassword.StateCommon.Border.Rounding = 8F;
            txtNewPassword.StateCommon.Border.Width = 2;
            txtNewPassword.StateCommon.Content.Color1 = Color.White;
            txtNewPassword.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtNewPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtNewPassword.TabIndex = 27;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Cursor = Cursors.IBeam;
            txtCurrentPassword.Location = new Point(21, 48);
            txtCurrentPassword.Multiline = true;
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(424, 41);
            txtCurrentPassword.StateCommon.Back.Color1 = Color.FromArgb(50, 50, 60);
            txtCurrentPassword.StateCommon.Border.Color1 = Color.FromArgb(0, 173, 181);
            txtCurrentPassword.StateCommon.Border.Color2 = Color.FromArgb(0, 173, 181);
            txtCurrentPassword.StateCommon.Border.Rounding = 8F;
            txtCurrentPassword.StateCommon.Border.Width = 2;
            txtCurrentPassword.StateCommon.Content.Color1 = Color.White;
            txtCurrentPassword.StateCommon.Content.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtCurrentPassword.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCurrentPassword.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(20, 166);
            label1.Name = "label1";
            label1.Size = new Size(156, 19);
            label1.TabIndex = 21;
            label1.Text = "Confirm New Password";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.Location = new Point(377, 595);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(21, 94);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 16;
            label5.Text = "New Password";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.DarkGray;
            label.Location = new Point(21, 25);
            label.Name = "label";
            label.Size = new Size(119, 19);
            label.TabIndex = 15;
            label.Text = "Current Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(565, 818);
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
            label4.Location = new Point(565, 796);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 13;
            label4.Text = "Subtotal";
            // 
            // ChangePasswordModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 329);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label1;
        private Krypton.Toolkit.KryptonButton btnSaveChanges;
        private Label label5;
        private Label label;
        private Label label2;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private Krypton.Toolkit.KryptonTextBox txtCurrentPassword;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}
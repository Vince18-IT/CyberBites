using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;


namespace Krypton_Test
{
    public partial class ChangePasswordModal : KryptonForm
    {
        public ChangePasswordModal()
        {
            InitializeComponent();
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCheckBox1.Checked)
            {
                // '\0' is a special character that means "No Mask" (Show real text)
                txtCurrentPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                // Put the mask back on! (You can use '*' or '•')
                txtCurrentPassword.PasswordChar = '•';
                txtNewPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }
    }
}

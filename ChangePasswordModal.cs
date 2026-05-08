<<<<<<< HEAD
﻿using Krypton.Toolkit;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CyberBites
{
    public partial class ChangePasswordModal : KryptonForm
    {
        // We need this to know exactly which user to update in the database
        private string _targetUsername;

        // Update the constructor to accept the username
        public ChangePasswordModal(string username)
        {
            InitializeComponent();
            _targetUsername = username;

            // UI Polish: Start the blinking cursor in the Current Password box immediately
            this.ActiveControl = txtCurrentPassword;
=======
﻿using System;
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
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
        }

        private void btnChangepass_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string currentPass = txtCurrentPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            // 1. Basic Validation
            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("New password cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Database Update
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Security: We check BOTH the Username and the Current Password
                    string updateQuery = "UPDATE Users SET Password = @newPass WHERE Username = @user AND Password = @oldPass";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPass", newPass);
                        cmd.Parameters.AddWithValue("@user", _targetUsername); // Use the passed username
                        cmd.Parameters.AddWithValue("@oldPass", currentPass);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // This triggers if 'lee' doesn't match what is currently in the DB for this user
                            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }   
=======

        }
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // Toggle masking for all three boxes
            char maskChar = kryptonCheckBox1.Checked ? '\0' : '•';

            txtCurrentPassword.PasswordChar = maskChar;
            txtNewPassword.PasswordChar = maskChar;
            txtConfirmPassword.PasswordChar = maskChar;
        }
    }
}
=======
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
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

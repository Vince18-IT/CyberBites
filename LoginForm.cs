using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
<<<<<<< HEAD
using System.Data.SQLite;

namespace CyberBites
=======

namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtLoginUser.Text.Trim();
            string inputPass = txtLoginPass.Text;

<<<<<<< HEAD
            if (string.IsNullOrWhiteSpace(inputUser) || string.IsNullOrWhiteSpace(inputPass))
            {
                MessageBox.Show("Please enter both Username and Password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Temporary variables to hold the data after we close the database
            string dbFullName = "";
            string dbEmail = "";
            string dbUsername = "";
            string dbSeat = "";
            decimal dbWallet = 0.00m; // <-- Added the Wallet variable
            bool loginSuccess = false;

            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string loginQuery = "SELECT * FROM Users WHERE Username = @user AND Password = @pass";

                    using (SQLiteCommand cmd = new SQLiteCommand(loginQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", inputUser);
                        cmd.Parameters.AddWithValue("@pass", inputPass);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 1. Grab the data from the database
                                dbFullName = reader["FullName"].ToString();
                                dbEmail = reader["Email"].ToString();
                                dbUsername = reader["Username"].ToString();
                                dbSeat = reader["SeatNumber"] != DBNull.Value ? reader["SeatNumber"].ToString() : "";

                                // Grab their saved money from the row
                                dbWallet = Convert.ToDecimal(reader["WalletBalance"]);

                                loginSuccess = true;
                            }
                        }
                    } // The Reader closes here!
                } // The Connection closes here!
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 2. NOW we build the MainForm, completely free of any database locks!
            if (loginSuccess)
            {
                // Passed all FIVE pieces of data, including dbWallet
                MainForm appMain = new MainForm(dbFullName, dbEmail, dbUsername, dbSeat, dbWallet);
=======
            // Check if the input matches what is saved in our Fake Database
            if (inputUser == FakeDatabase.Username && inputPass == FakeDatabase.Password)
            {
                // IT MATCHES! Create the MainForm and hand over the saved data like a baton.
                MainForm appMain = new MainForm(FakeDatabase.FullName, FakeDatabase.Email, FakeDatabase.Username);
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
                appMain.FormClosed += (s, args) => Application.Exit();
                appMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again or create an account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
<<<<<<< HEAD
=======
                txtLoginUser.Clear();
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
                txtLoginPass.Clear();
            }
        }

        private void btnShowSignup_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlSignUp.Visible = true;
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlLogin.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlSignUp.Location = pnlLogin.Location;
            pnlSignUp.Visible = false;
            pnlLogin.Visible = true;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // 1. Grab the text from the UI
            string newFullName = txtRegName.Text.Trim();
            string newEmail = txtRegEmail.Text.Trim();
            string newUsername = txtRegUser.Text.Trim();
            string newPassword = txtRegPass.Text; // Never trim passwords!

            // 2. Strict UI Validation (Do not let them hit the database if fields are empty)
            if (string.IsNullOrWhiteSpace(newFullName) || string.IsNullOrWhiteSpace(newEmail) ||
                string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill out all fields before creating an account.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Connect to the SQLite Database
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // --- SECURITY CHECK: Does this Username or Email already exist? ---
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @user OR Email = @email";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        // We use Parameters (@user) to prevent SQL Injection hackers!
                        checkCmd.Parameters.AddWithValue("@user", newUsername);
                        checkCmd.Parameters.AddWithValue("@email", newEmail);

                        // ExecuteScalar returns the first column of the first row (the COUNT number)
                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            MessageBox.Show("That Username or Email is already taken! Please choose another.", "Account Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Stop the process right here!
                        }
                    }

                    // --- INSERTION: Safe to create the account ---
                    string insertQuery = @"
                INSERT INTO Users (FullName, Email, Username, Password, SeatNumber, WalletBalance) 
                VALUES (@fullName, @email, @user, @pass, @seat, @wallet)";

                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@fullName", newFullName);
                        insertCmd.Parameters.AddWithValue("@email", newEmail);
                        insertCmd.Parameters.AddWithValue("@user", newUsername);
                        insertCmd.Parameters.AddWithValue("@pass", newPassword);

                        // Set default empty values for a brand new user
                        insertCmd.Parameters.AddWithValue("@seat", "");
                        insertCmd.Parameters.AddWithValue("@wallet", 0.00m);

                        // ExecuteNonQuery is used for INSERT, UPDATE, and DELETE (returns the number of rows affected)
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account created successfully! Please log in with your new credentials.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Reset UI and send them back to the Login panel
                    pnlSignUp.Visible = false;
                    pnlLogin.Visible = true;

                    txtRegName.Clear();
                    txtRegEmail.Clear();
                    txtRegUser.Clear();
                    txtRegPass.Clear();
                }
                catch (Exception ex)
                {
                    // If the database crashes or is locked, tell the user instead of freezing the app!
                    MessageBox.Show("Database Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // The 'using' block automatically calls conn.Close() right here to free up the file!
=======
            FakeDatabase.FullName = txtRegName.Text.Trim();
            FakeDatabase.Email = txtRegEmail.Text.Trim();
            FakeDatabase.Username = txtRegUser.Text.Trim();
            FakeDatabase.Password = txtRegPass.Text;

            // Safety check: Make sure they didn't leave it blank
            if (string.IsNullOrWhiteSpace(FakeDatabase.FullName) || string.IsNullOrWhiteSpace(FakeDatabase.Username))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Account created successfully! Please log in with your new credentials.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Send them back to the Login screen
            // Send them back to the Login panel
            pnlSignUp.Visible = false;
            pnlLogin.Visible = true;

            // Optional: Clear the sign-up textboxes so they are empty for the next person
            txtRegName.Clear();
            txtRegEmail.Clear();
            txtRegUser.Clear();
            txtRegPass.Clear();
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
        }

        private void txtLoginPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Stop Windows from typing the invisible line break (and stops the annoying 'ding' sound!)
                e.SuppressKeyPress = true;

                // 2. Force the Login button to click itself
                btnLogin.PerformClick();
            }
        }

        private void txtLoginUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Stop Windows from typing the invisible line break (and stops the annoying 'ding' sound!)
                e.SuppressKeyPress = true;

                // 2. Force the Login button to click itself
                btnLogin.PerformClick();
            }
        }
    }
}

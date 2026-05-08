using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Krypton_Test
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

            // Check if the input matches what is saved in our Fake Database
            if (inputUser == FakeDatabase.Username && inputPass == FakeDatabase.Password)
            {
                // IT MATCHES! Create the MainForm and hand over the saved data like a baton.
                MainForm appMain = new MainForm(FakeDatabase.FullName, FakeDatabase.Email, FakeDatabase.Username);
                appMain.FormClosed += (s, args) => Application.Exit();
                appMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again or create an account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginUser.Clear();
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

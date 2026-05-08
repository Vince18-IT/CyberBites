using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Krypton_Test
{
    public partial class AccountPage : UserControl
    {
        public Action<Image> OnProfilePicChanged;
        public Action<string> OnProfileNameChanged;
        public AccountPage()
        {
            InitializeComponent();
            MakeCircular(imgAvatar);
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            ChangePasswordModal pwdModal = new ChangePasswordModal();


            pwdModal.ShowDialog();
        }

        public void LoadUserData(string fullName, string email, string username, string seatNum)
        {
            // Update the big display label
            lblNameUser.Text = $"{fullName}\n({username})";

            // Pre-fill all three text boxes!
            txtName.Text = fullName;
            txtEmail.Text = email;         // <-- New addition
            txtUsername.Text = username;
            txtSeatno.Text = seatNum;
        }

        private void MakeCircular(PictureBox picBox)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            // Draw an invisible ellipse over the box
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            // Tell the box to cut off anything outside that ellipse
            picBox.Region = new Region(path);
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Tell it to only look for image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select a Profile Picture";

            // If they pick an image and click OK...
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // SAFE WAY: Read the file as a stream so Windows doesn't lock it or crash
                    using (System.IO.FileStream stream = new System.IO.FileStream(openFileDialog.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        imgAvatar.Image = Image.FromStream(stream);
                    }

                    // Make sure it fits perfectly inside the box
                    imgAvatar.SizeMode = PictureBoxSizeMode.Zoom;

                    // THE MEGAPHONE: Tell the MainForm to update its mini-avatar too!
                    OnProfilePicChanged?.Invoke(imgAvatar.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load that image. Please try a different photo.\n\nError: " + ex.Message, "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter both a Name and a Username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // This updates the local page
            lblNameUser.Text = $"{fullName}\n({username})";

            // --- ADD THIS LINE: Shout the new name to the MainForm! ---
            OnProfileNameChanged?.Invoke(fullName);

            MessageBox.Show("Profile updated successfully!", "CyberBites Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateSeatDisplay(string seatNum)
        {
            txtSeatno.Text = seatNum; // Make sure this matches your Seat Number textbox name!
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 1. Create the new Login screen
                LoginForm login = new LoginForm();

                // --- ADD THIS MAGIC LINE ---
                // This tells the new login screen to assassinate any hidden ghost processes if it gets closed!
                login.FormClosed += (s, args) => Application.Exit();

                // 2. Show the login screen
                login.Show();

                // 3. Hide the current dashboard
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Hide();
                }
            }
        }

        private void txtSeatno_DoubleClick(object sender, EventArgs e)
        {
            SeatNumberModal seatModal = new SeatNumberModal();

            if (seatModal.ShowDialog() == DialogResult.OK)
            {
                // If they successfully saved a new seat, update the textbox to show it!
                txtSeatno.Text = FakeDatabase.SeatNumber;
            }
        }
    }
}

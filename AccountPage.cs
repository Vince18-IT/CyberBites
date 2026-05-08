using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Data.SQLite;
using System.IO;

namespace CyberBites
=======


namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    public partial class AccountPage : UserControl
    {
        public Action<Image> OnProfilePicChanged;
        public Action<string> OnProfileNameChanged;
<<<<<<< HEAD

=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
        public AccountPage()
        {
            InitializeComponent();
            MakeCircular(imgAvatar);
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ChangePasswordModal pwdModal = new ChangePasswordModal(txtUsername.Text);
=======
            ChangePasswordModal pwdModal = new ChangePasswordModal();


>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            pwdModal.ShowDialog();
        }

        public void LoadUserData(string fullName, string email, string username, string seatNum)
        {
            // Update the big display label
            lblNameUser.Text = $"{fullName}\n({username})";

<<<<<<< HEAD
            // Pre-fill all text boxes
            txtName.Text = fullName;
            txtEmail.Text = email;
            txtUsername.Text = username;
            txtSeatno.Text = seatNum;

            // --- GRAB PICTURE AND PASSWORD FROM DATABASE ---
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    // We changed this to select BOTH the picture and the password
                    string query = "SELECT ProfilePicture, Password FROM Users WHERE Username = @user";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If we found the user
                            {
                                // 1. Set up the Password Box
                                txtPassword.Text = reader["Password"].ToString(); // Change 'txtPassword' to your actual textbox name // This turns the text into black dots
                                txtPassword.ReadOnly = true; 

                                // 2. Load the Profile Picture
                                if (reader["ProfilePicture"] != DBNull.Value)
                                {
                                    byte[] photoBytes = (byte[])reader["ProfilePicture"];
                                    Image loadedImage = ByteArrayToImage(photoBytes);

                                    imgAvatar.Image = loadedImage;
                                    imgAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                                    OnProfilePicChanged?.Invoke(loadedImage);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not load user data: " + ex.Message);
                }
            }
        }

        // Tool 1: Converts an Image into raw database bytes
        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Clone the image so it doesn't lock the original file!
                Image imgClone = new Bitmap(imageIn);
                imgClone.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // Tool 2: Converts raw database bytes back into a visible Image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
=======
            // Pre-fill all three text boxes!
            txtName.Text = fullName;
            txtEmail.Text = email;         // <-- New addition
            txtUsername.Text = username;
            txtSeatno.Text = seatNum;
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
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
<<<<<<< HEAD
            // 1. Open the Windows File Explorer so they can pick a picture
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a Profile Picture";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 2. Load the picture they chose
                        Image selectedImage = Image.FromFile(ofd.FileName);

                        // 3. Convert it to bytes for the database
                        byte[] photoBytes = ImageToByteArray(selectedImage);

                        // 4. Save it directly to the SQLite Database
                        using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
                        {
                            conn.Open();
                            string updateQuery = "UPDATE Users SET ProfilePicture = @pic WHERE Username = @user";

                            using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@pic", photoBytes);

                                // Make sure you use whatever textbox/variable is holding their username on this page!
                                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 5. Success! Update the picture box on the screen
                        imgAvatar.Image = selectedImage;
                        imgAvatar.SizeMode = PictureBoxSizeMode.Zoom;

                        // 6. SHOUT to the MainForm to update the tiny top-right avatar!
                        OnProfilePicChanged?.Invoke(selectedImage);

                        MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
=======
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
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // 1. Grab the new name from the textbox
            string fullName = txtName.Text.Trim();
            string username = txtUsername.Text.Trim(); // We need this to find the correct row in the DB

            // Basic Validation
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter a Name.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. RUN THE SQL UPDATE: Save the new name to the Database
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    // We find the user by their fixed Username and update their Full Name
                    string updateQuery = "UPDATE Users SET FullName = @newName WHERE Username = @user";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", fullName);
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save changes to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the rest of the code if DB fails
                }
            }

            // 3. Update the UI
            // Updates the big "Name (Username)" label on the page
            lblNameUser.Text = $"{fullName}\n({username})";

            // Shout the new name to the MainForm so it can update the top-right welcome message!
=======
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
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
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

<<<<<<< HEAD
=======
                // --- ADD THIS MAGIC LINE ---
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
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
<<<<<<< HEAD
            // Grab the username and current seat straight from the textboxes on the screen!
            SeatNumberModal seatModal = new SeatNumberModal(txtUsername.Text, txtSeatno.Text);

            if (seatModal.ShowDialog() == DialogResult.OK)
            {
                // Update the textbox to show what they just saved in the database
                txtSeatno.Text = seatModal.SelectedSeat;
            }
        }

        private void lblAccManage_DoubleClick(object sender, EventArgs e)
        {
            new DbViewer().Show();
        }
    }
}
=======
            SeatNumberModal seatModal = new SeatNumberModal();

            if (seatModal.ShowDialog() == DialogResult.OK)
            {
                // If they successfully saved a new seat, update the textbox to show it!
                txtSeatno.Text = FakeDatabase.SeatNumber;
            }
        }
    }
}
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

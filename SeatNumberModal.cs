using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;


namespace CyberBites
{


    public partial class SeatNumberModal : KryptonForm
    {

        private string currentUser;

        // This acts as a messenger to hand the chosen seat back to the MainForm!
        public string SelectedSeat { get; private set; }

        public SeatNumberModal(string username, string lastKnownSeat)
        {
            InitializeComponent();
            currentUser = username;

            // Pre-fill the box with their last seat so they can just hit 'Save' if they didn't move PCs!
            txtSeatInput.Text = lastKnownSeat;
        }

        private void btnSaveSeatno_Click(object sender, EventArgs e)
        {
            string chosenSeat = txtSeatInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(chosenSeat))
            {
                MessageBox.Show("Please enter a valid Seat Number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Save it directly to the Database!
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE Users SET SeatNumber = @seat WHERE Username = @user";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@seat", chosenSeat);
                        cmd.Parameters.AddWithValue("@user", currentUser);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop them from proceeding if the database fails
                }
            }

            // 2. Set the public messenger variable
            SelectedSeat = chosenSeat;

            // 3. Tell Windows this was a success and close the modal
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

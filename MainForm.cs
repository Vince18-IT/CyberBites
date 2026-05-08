using System;
using System.Windows.Forms;
using Krypton.Toolkit;
<<<<<<< HEAD
using System.Data.SQLite; // Added for the Wallet Database Saving!

namespace CyberBites
=======

namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    public partial class MainForm : KryptonForm
    {
        private HomePage myHomePage;
        private CartPage myCartPage;
        private TopupPage myTopupPage;
<<<<<<< HEAD
        private AccountPage myAccountPage;
        private string globalUsername;
        private string globalSeat;
=======
        private AccountPage myAccountPage; // Added Topup instance
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

        // The "Bank" - This holds the money for the whole app
        private decimal walletBalance = 0.00m;

<<<<<<< HEAD
        // 1. Updated Constructor to accept startingBalance
        public MainForm(string loggedInFullName, string loggedInEmail, string loggedInUsername, string currentSeat, decimal startingBalance)
=======
        public MainForm(string loggedInFullName, string loggedInEmail, string loggedInUsername)
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
        {
            InitializeComponent();
            MakeCircular(imgTopAvatar);

<<<<<<< HEAD
            globalUsername = loggedInUsername;
            globalSeat = currentSeat;

            // 2. Set the global bank to their actual database money
            walletBalance = startingBalance;

            lblTopName.Text = loggedInFullName;

            // Initialize all pages once
=======
            lblTopName.Text = loggedInFullName;
            // 1. Initialize all pages once
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            myHomePage = new HomePage();
            myCartPage = new CartPage();
            myTopupPage = new TopupPage();
            myAccountPage = new AccountPage();
<<<<<<< HEAD

            // 3. Immediately update the UI so they see their money right when they log in
            myHomePage.UpdateBalanceDisplay(walletBalance);
            myTopupPage.UpdateDisplayBalance(walletBalance);
            myCartPage.UpdateBalanceDisplay(walletBalance);
            myTopupPage.UpdateAccountNameDisplay(loggedInFullName);
            // The Cart Matchmaker (Home -> Cart)
=======
            // 2. The Cart Matchmaker (Home -> Cart)
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            myHomePage.OnAddToCartClicked += (name, price, img) =>
            {
                myCartPage.AddItemToCart(name, price, img);
                MessageBox.Show($"{name} was added to your cart!", "Success");
            };

<<<<<<< HEAD
            myAccountPage.OnProfileNameChanged += (newName) =>
            {
                lblTopName.Text = newName;
                // 2. Add this line so the Top-up page updates if they change their name!
                myTopupPage.UpdateAccountNameDisplay(newName);
            };

            // --- THE NEW DATABASE TOP-UP MATCHMAKER ---
            myTopupPage.OnTopUpConfirmed += (foodAmount, pcAmount) =>
            {
                // Update local memory
                walletBalance += foodAmount;

                // Save to Database
                UpdateDatabaseWallet(walletBalance);

                // Tell the pages to update their labels
                myHomePage.UpdateBalanceDisplay(walletBalance);
                myTopupPage.UpdateDisplayBalance(walletBalance);
                myCartPage.UpdateBalanceDisplay(walletBalance);
            };

            // --- THE NEW DATABASE CHECKOUT MATCHMAKER ---
=======
            // 3. The Top-up Matchmaker (Topup -> Bank -> All Pages)
            myTopupPage.OnTopUpConfirmed += (foodAmount, pcAmount) =>
            {
                // Update the global bank account with the food credit
                walletBalance += foodAmount;

                // Tell the pages to update their labels
                myHomePage.UpdateBalanceDisplay(walletBalance);
                myTopupPage.UpdateDisplayBalance(walletBalance);

                // Optional: You could also track pcAmount separately if you have a timer!
            };

>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            myCartPage.OnCheckoutRequested += (totalToPay) =>
            {
                if (walletBalance >= totalToPay)
                {
<<<<<<< HEAD
                    // Deduct local memory
                    walletBalance -= totalToPay;

                    // Save to Database
                    UpdateDatabaseWallet(walletBalance);
=======
                    walletBalance -= totalToPay; // Deduct the money
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

                    // Update all balance labels across the app
                    myHomePage.UpdateBalanceDisplay(walletBalance);
                    myTopupPage.UpdateDisplayBalance(walletBalance);
<<<<<<< HEAD
                    myCartPage.UpdateBalanceDisplay(walletBalance);
=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a

                    return true; // Payment approved
                }
                return false; // Payment denied
            };

            myAccountPage.OnProfilePicChanged += (newImage) =>
            {
                // When AccountPage shouts a new image, update the mini top-right avatar!
                imgTopAvatar.Image = newImage;
                imgTopAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            };

            myAccountPage.OnProfileNameChanged += (newName) =>
            {
                lblTopName.Text = newName;
            };

<<<<<<< HEAD
            myAccountPage.LoadUserData(loggedInFullName, loggedInEmail, loggedInUsername, currentSeat);

            // Start the app on the Home Page
            LoadPage(myHomePage);

            this.Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Because this runs AFTER the form is visible, the dashboard will be beautifully blurred in the background!
            SeatNumberModal seatModal = new SeatNumberModal(globalUsername, globalSeat);
            seatModal.StartPosition = FormStartPosition.CenterScreen;

            while (seatModal.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("You must confirm your PC Seat to continue.", "Seat Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Update the Account Page UI
            myAccountPage.UpdateSeatDisplay(seatModal.SelectedSeat);
        }

        // --- THE DATABASE SAVING TOOL ---
        private void UpdateDatabaseWallet(decimal newTotal)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE Users SET WalletBalance = @bal WHERE Username = @user";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@bal", newTotal);
                        cmd.Parameters.AddWithValue("@user", globalUsername);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save balance to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
=======
            myAccountPage.LoadUserData(loggedInFullName, loggedInEmail, loggedInUsername, FakeDatabase.SeatNumber);

            // 4. Start the app on the Home Page
            LoadPage(myHomePage);

            while (string.IsNullOrEmpty(FakeDatabase.SeatNumber))
            {
                SeatNumberModal seatModal = new SeatNumberModal();
                seatModal.ShowDialog();
            }

            // Once they finally provide one, update the UI
            myAccountPage.UpdateSeatDisplay(FakeDatabase.SeatNumber);
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

        // --- Navigation ---

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            LoadPage(myHomePage);
        }

        private void btnNavCart_Click(object sender, EventArgs e)
        {
            LoadPage(myCartPage);
        }

        // Make sure your sidebar Top-up button is named btnNavTopup
        private void btnNavTopup_Click(object sender, EventArgs e)
        {
            LoadPage(myTopupPage);
        }

        private void LoadPage(UserControl page)
        {
            pnlMainContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(page);
        }

        private void btnNavAccount_Click(object sender, EventArgs e)
        {
            LoadPage(myAccountPage);
        }

        private void imgTopAvatar_Click(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Smoother transitions
                return cp;
            }
        }
    }
}
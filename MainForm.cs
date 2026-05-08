using System;
using System.Windows.Forms;
using Krypton.Toolkit;
using System.Data.SQLite; // Added for the Wallet Database Saving!

namespace CyberBites
{
    public partial class MainForm : KryptonForm
    {
        private HomePage myHomePage;
        private CartPage myCartPage;
        private TopupPage myTopupPage;
        private AccountPage myAccountPage;
        private string globalUsername;
        private string globalSeat;

        // The "Bank" - This holds the money for the whole app
        private decimal walletBalance = 0.00m;

        // 1. Updated Constructor to accept startingBalance
        public MainForm(string loggedInFullName, string loggedInEmail, string loggedInUsername, string currentSeat, decimal startingBalance)
        {
            InitializeComponent();
            MakeCircular(imgTopAvatar);

            globalUsername = loggedInUsername;
            globalSeat = currentSeat;

            // 2. Set the global bank to their actual database money
            walletBalance = startingBalance;

            lblTopName.Text = loggedInFullName;

            // Initialize all pages once
            myHomePage = new HomePage();
            myCartPage = new CartPage();
            myTopupPage = new TopupPage();
            myAccountPage = new AccountPage();

            // 3. Immediately update the UI so they see their money right when they log in
            myHomePage.UpdateBalanceDisplay(walletBalance);
            myTopupPage.UpdateDisplayBalance(walletBalance);
            myCartPage.UpdateBalanceDisplay(walletBalance);
            myTopupPage.UpdateAccountNameDisplay(loggedInFullName);
            // The Cart Matchmaker (Home -> Cart)
            myHomePage.OnAddToCartClicked += (name, price, img) =>
            {
                myCartPage.AddItemToCart(name, price, img);
                MessageBox.Show($"{name} was added to your cart!", "Success");
            };

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
            myCartPage.OnCheckoutRequested += (totalToPay) =>
            {
                if (walletBalance >= totalToPay)
                {
                    // Deduct local memory
                    walletBalance -= totalToPay;

                    // Save to Database
                    UpdateDatabaseWallet(walletBalance);

                    // Update all balance labels across the app
                    myHomePage.UpdateBalanceDisplay(walletBalance);
                    myTopupPage.UpdateDisplayBalance(walletBalance);
                    myCartPage.UpdateBalanceDisplay(walletBalance);

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
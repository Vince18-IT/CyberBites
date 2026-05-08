using System;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace Krypton_Test
{
    public partial class MainForm : KryptonForm
    {
        private HomePage myHomePage;
        private CartPage myCartPage;
        private TopupPage myTopupPage;
        private AccountPage myAccountPage; // Added Topup instance

        // The "Bank" - This holds the money for the whole app
        private decimal walletBalance = 0.00m;

        public MainForm(string loggedInFullName, string loggedInEmail, string loggedInUsername)
        {
            InitializeComponent();
            MakeCircular(imgTopAvatar);

            lblTopName.Text = loggedInFullName;
            // 1. Initialize all pages once
            myHomePage = new HomePage();
            myCartPage = new CartPage();
            myTopupPage = new TopupPage();
            myAccountPage = new AccountPage();
            // 2. The Cart Matchmaker (Home -> Cart)
            myHomePage.OnAddToCartClicked += (name, price, img) =>
            {
                myCartPage.AddItemToCart(name, price, img);
                MessageBox.Show($"{name} was added to your cart!", "Success");
            };

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

            myCartPage.OnCheckoutRequested += (totalToPay) =>
            {
                if (walletBalance >= totalToPay)
                {
                    walletBalance -= totalToPay; // Deduct the money

                    // Update all balance labels across the app
                    myHomePage.UpdateBalanceDisplay(walletBalance);
                    myTopupPage.UpdateDisplayBalance(walletBalance);

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
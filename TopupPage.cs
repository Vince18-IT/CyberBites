using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

<<<<<<< HEAD
namespace CyberBites
=======
namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    public partial class TopupPage : UserControl
    {
        public Action<decimal, decimal> OnTopUpConfirmed; // Food, PC Time

        private decimal currentFoodAmount = 0;
        private decimal currentPCAmount = 0;

        public TopupPage()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            // --- FOOD BUTTONS ---
            var foodButtons = new[] { btnFood50, btnFood100, btnFood200, btnFood500, btnFood1000 };
            foreach (var btn in foodButtons)
            {
                btn.Click += (s, e) =>
                {
                    var clickedBtn = (KryptonCheckButton)s;

                    // If the button is now UNCHECKED (meaning it was already active and we clicked it again)
                    if (!clickedBtn.Checked)
                    {
                        currentFoodAmount = 0;
                    }
                    else
                    {
                        // It's a new selection: uncheck the others
                        UncheckGroup(foodButtons, clickedBtn);
                        txtCustomFood.Text = "";
                        currentFoodAmount = decimal.Parse(clickedBtn.Values.Text.Replace("₱", ""));
                    }
                    UpdateSummary();
                };
            }

            // --- PC BUTTONS ---
            var pcButtons = new[] { btnPC20, btnPC50, btnPC100, btnPC150, btnPC200 };
            foreach (var btn in pcButtons)
            {
                btn.Click += (s, e) =>
                {
                    var clickedBtn = (KryptonCheckButton)s;

                    if (!clickedBtn.Checked)
                    {
                        currentPCAmount = 0;
                    }
                    else
                    {
                        UncheckGroup(pcButtons, clickedBtn);
                        txtCustomPC.Text = "";
                        currentPCAmount = decimal.Parse(clickedBtn.Values.Text.Replace("₱", ""));
                    }
                    UpdateSummary();
                };
            }
        }

        private void UncheckGroup(KryptonCheckButton[] group, KryptonCheckButton selected)
        {
            foreach (var btn in group)
            {
                // Only uncheck the buttons that AREN'T the one we just clicked
                if (btn != selected)
                {
                    btn.Checked = false;
                }
            }
        }

        // --- Handling Custom Input ---
        private void txtCustomFood_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomFood.Text))
            {
                currentFoodAmount = 0;
                UpdateSummary();
                return;
            }

            // 2. Otherwise, try to parse the number
            if (decimal.TryParse(txtCustomFood.Text, out decimal val))
            {
                // Uncheck all buttons because custom input is being used
                var foodButtons = new[] { btnFood50, btnFood100, btnFood200, btnFood500, btnFood1000 };
                UncheckGroup(foodButtons, null);

                currentFoodAmount = val;
                UpdateSummary();
            }
            else
            {
                // 3. If they typed something that isn't a number (like "abc"), reset to 0
                currentFoodAmount = 0;
                UpdateSummary();
            }
        }

        private void UpdateSummary()
        {
            lblFood.Text = $"₱{currentFoodAmount:N2}";
            lblPC.Text = $"₱{currentPCAmount:N2}";
            lblGrandTotal.Text = $"₱{(currentFoodAmount + currentPCAmount):N2}";
        }

        public void UpdateDisplayBalance(decimal newBalance)
        {
            lblCurrentBalance.Text = $"₱{newBalance:N2}";
        }
        private void ResetOrder()
        {
            // 1. Reset the numbers
            currentFoodAmount = 0;
            currentPCAmount = 0;

            // 2. Clear the labels
            lblFood.Text = "₱0.00";
            lblPC.Text = "₱0.00";
            lblGrandTotal.Text = "₱0.00";

            // 3. Clear the custom text boxes
            txtCustomFood.Text = "";
            txtCustomPC.Text = "";

            // 4. Uncheck ALL buttons
            var allButtons = new[] { btnFood50, btnFood100, btnFood200, btnFood500, btnFood1000,
                             btnPC20, btnPC50, btnPC100, btnPC150, btnPC200 };
            foreach (var btn in allButtons)
            {
                btn.Checked = false;
            }
        }

<<<<<<< HEAD
        public void UpdateAccountNameDisplay(string fullName)
        {
            // Change 'lblAccountName' to whatever you actually named the label under the ₱970.00!
            lblAccountName.Text = fullName;
        }

=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
        private void btnConfirmTopUp_Click(object sender, EventArgs e)
        {
            if (currentFoodAmount > 0 || currentPCAmount > 0)
            {
                // Shout to the MainForm!
                OnTopUpConfirmed?.Invoke(currentFoodAmount, currentPCAmount);

                MessageBox.Show("Transaction Successful!", "CyberBites");
                ResetOrder();
            }
            else
            {
                MessageBox.Show("Please select an amount first.", "Selection Required");
            }

        }

        private void txtCustomPC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomPC.Text))
            {
                currentPCAmount = 0;
                UpdateSummary();
                return;
            }

            // 2. Otherwise, try to parse the number
            if (decimal.TryParse(txtCustomPC.Text, out decimal val))
            {
                // Uncheck all buttons because custom input is being used
                var pcButtons = new[] { btnPC20, btnPC50, btnPC100, btnPC150, btnPC200 };
                UncheckGroup(pcButtons, null);
                currentPCAmount = val;
                UpdateSummary();
            }
            else
            {
                // 3. If they typed something that isn't a number (like "abc"), reset to 0
                currentPCAmount = 0;
                UpdateSummary();
            }
        }
    }
}

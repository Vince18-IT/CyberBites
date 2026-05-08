using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Krypton_Test
{
    public partial class CartPage : UserControl
    {

        public Func<decimal, bool> OnCheckoutRequested;
        public CartPage()
        {
            InitializeComponent();
        }

        public void UpdateBalanceDisplay(decimal currentBalance)
        {
            lblCartBalance.Text = $"₱{currentBalance:N2}";
        }

        private void btnProceedCheckout_Click(object sender, EventArgs e)
        {
            // 1. Get the current total as a number
            string totalStr = lblTotal.Text.Replace("₱", "").Replace("$", "").Trim();

            if (decimal.TryParse(totalStr, out decimal totalAmount) && totalAmount > 0)
            {
                // NEW: The MessageBox Confirmation!
                DialogResult result = MessageBox.Show(
                    $"Your total is ₱{totalAmount:N2}.\nDo you want to proceed with the payment?",
                    "Confirm Checkout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // If they click 'Yes', proceed with payment
                if (result == DialogResult.Yes)
                {
                    bool isPaid = OnCheckoutRequested?.Invoke(totalAmount) ?? false;

                    if (isPaid)
                    {
                        MessageBox.Show("Order Successful! Enjoy your meal.", "CyberBites");

                        // Clear the cart
                        flowLayoutPanel1.Controls.Clear();
                        CalculateTotal();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance! Please Top-up your account.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Your cart is empty!", "CyberBites");
            }
        }

        public void CalculateTotal()
        {
            decimal subtotal = 0;
            int totalItems = 0;

            // Loop through every control inside your FlowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                // Check if the control is actually a CartItemRow
                if (control is CartItemRow row)
                {
                    // Math: Price * Quantity
                    subtotal += (row.ItemPrice * row.Quantity);
                    totalItems += row.Quantity;
                }
            }

            // Update your labels! (Using "C2" automatically formats it as money like $0.00)
            lblSubtotal.Text = subtotal.ToString("C2");
            lblTotal.Text = subtotal.ToString("C2");

            // Update the item count label
            lblItems.Text = $"{totalItems} items";
        }

        public void AddItemToCart(string name, decimal price, Image img)
        {
            // 1. Create a brand new row from your blueprint
            CartItemRow newRow = new CartItemRow();

            // 2. Assign the data (including the new image!)
            newRow.ItemName = name;
            newRow.ItemPrice = price;
            newRow.ItemImage = img;

            // Update the actual labels inside the row so the user can see them
            // (Note: Replace lblItemName and lblPrice with whatever you named the labels inside your CartItemRow!)
            newRow.Controls.Find("lblItemName", true)[0].Text = name;
            newRow.Controls.Find("lblCartPrice", true)[0].Text = price.ToString("C2");

            // 3. Listen to the Megaphones!
            newRow.QuantityChanged += (s, e) => {
                CalculateTotal(); // If quantity changes, recalculate!
            };

            newRow.ItemRemoved += (s, e) => {
                flowLayoutPanel1.Controls.Remove(newRow); // Delete the row from the screen
                newRow.Dispose(); // Clear it from memory
                CalculateTotal(); // Recalculate!
            };

            // 4. Finally, drop it into the panel!
            flowLayoutPanel1.Controls.Add(newRow);

            // 5. Update the total right away
            CalculateTotal();
        }
    }
}

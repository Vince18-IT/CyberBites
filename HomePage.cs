using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Krypton_Test
{
    public partial class HomePage : UserControl
    {

        public Action<string, decimal, Image> OnAddToCartClicked;
        public HomePage()
        {
            InitializeComponent();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ItemCard card)
                {
                    // When a specific card shouts...
                    card.OnAddToCartClicked += (name, price, img) =>
                    {
                        // ...the HomePage immediately shouts it up to the MainForm!
                        this.OnAddToCartClicked?.Invoke(name, price, img);
                    };
                }
            }
        }

        private void itemCard3_Load(object sender, EventArgs e)
        {

        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearchbar.Text.ToLower();

            // 2. Loop through every single card inside your grid
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                // 3. Make sure the control we are looking at is actually an ItemCard
                if (control is ItemCard card)
                {
                    // 4. Check if the card's ItemName contains the typed text
                    if (card.ItemName.ToLower().Contains(searchQuery))
                    {
                        // It matches! Show the card.
                        card.Visible = true;
                    }
                    else
                    {
                        // It doesn't match! Hide the card.
                        card.Visible = false;
                    }
                }
            }
        }

        public void UpdateBalanceDisplay(decimal newBalance)
        {
            
            lblBalance.Text = $"Balance : ₱{newBalance:N2}";
        }
    }
}

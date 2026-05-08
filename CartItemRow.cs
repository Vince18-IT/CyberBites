using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

<<<<<<< HEAD
namespace CyberBites
=======
namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    public partial class CartItemRow : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ItemName { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal ItemPrice { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Quantity { get; set; } = 1;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image ItemImage
        {
            // Note: Change "pictureBox1" to whatever you actually named the 
            // picture box inside your CartItemRow designer!
            get { return picAddeditem.Image; }
            set { picAddeditem.Image = value; }
        }

        public event EventHandler QuantityChanged;
        public event EventHandler ItemRemoved;


        public CartItemRow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Quantity++;
            lblQuantity.Text = Quantity.ToString();

            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--; // Subtract 1
                lblQuantity.Text = Quantity.ToString(); // Update the label

                // Fire the megaphone!
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Fire the megaphone so the CartPage knows to delete this row!
            ItemRemoved?.Invoke(this, EventArgs.Empty);
        }
    }
}

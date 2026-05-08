using System;
using System.Collections.Generic;
using System.ComponentModel; // This allows us to use Designer attributes
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CyberBites
{
    public partial class ItemCard : UserControl
    {

        public Action<string, decimal, Image> OnAddToCartClicked;
        public ItemCard()
        {
            InitializeComponent();
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ItemPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image? ItemImage
        {
            get { return picItemImage.Image; }
            set { picItemImage.Image = value; }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            string priceText = lblPrice.Text.Replace("₱", "").Trim();

            if (decimal.TryParse(priceText, out decimal price))
            {
                
                OnAddToCartClicked?.Invoke(ItemName, price, ItemImage);
            }
        }
    }
}
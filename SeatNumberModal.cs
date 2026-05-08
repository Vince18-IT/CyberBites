using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;


namespace Krypton_Test
{
    public partial class SeatNumberModal : KryptonForm
    {
        public SeatNumberModal()
        {
            InitializeComponent();
        }

        private void btnSaveSeatno_Click(object sender, EventArgs e)
        {
            string chosenSeat = txtSeatInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(chosenSeat))
            {
                MessageBox.Show("Please enter a valid Seat Number.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Save it globally
            FakeDatabase.SeatNumber = chosenSeat;

            // 3. Tell Windows this modal was successful, then close it
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

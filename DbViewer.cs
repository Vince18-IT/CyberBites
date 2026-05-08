using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Krypton.Toolkit;


namespace CyberBites
{
    public partial class DbViewer : KryptonForm
    {
        public DbViewer()
        {
            InitializeComponent();
        }

        private void DbViewer_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users";

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;

                        // --- ADD THESE TWO LINES ---
                        // This tells Windows: "Hey, I've got new data, redraw the grid NOW!"
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viewer Error: " + ex.Message);
            }
        }
    }
}

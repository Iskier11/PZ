using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PZ.Forms
{
    public partial class Zolnierze : Form
    {
        string connectionString = @"Data Source=boksik.database.windows.net;Initial Catalog=Projekt_PZ;Persist Security Info=True;User ID=Mortem;Password=Kudlaty!";
        public Zolnierze()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {///polaczenie z baza danych
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "Select * from UZYTKOWNIK Where typ = 4";
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, sqlCon);
                DataTable data = new DataTable();
                sqlDA.Fill(data);
                ZolnierzeTABEL.AutoGenerateColumns = false;
                ZolnierzeTABEL.DataSource = data;

            }
        }
    }
}

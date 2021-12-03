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
    public partial class Bronie : Form
    {
        string connectionString = @"Data Source=boksik.database.windows.net;Initial Catalog=Projekt_PZ;Persist Security Info=True;User ID=Mortem;Password=Kudlaty!";
        public Bronie()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        { /// otwieranie polaczenia z baza danych 
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                /// polecenie SQL aby wybrac interesujacy fragment
                string query = "Select * from BRON Where ID_MAGAZYNU = 1";
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, sqlCon);
                DataTable data = new DataTable();
                sqlDA.Fill(data);
                ///wyswietlenie tabeli
                ZolnierzeTABEL.AutoGenerateColumns = false;
                ZolnierzeTABEL.DataSource = data;

            }
        }

        private void ZolnierzeTABEL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

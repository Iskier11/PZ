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
using System.Configuration;


namespace PZ
{

    public partial class Form1 : Form
        
    {
        public string danelogowania;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void przyciskzaloguj_Click(object sender, EventArgs e)
        {
            {
                //Connection String   
                SqlConnection con = new SqlConnection(@"Data Source=boksik.database.windows.net;Initial Catalog=Projekt_PZ;Persist Security Info=True;User ID=Mortem;Password=Kudlaty!");
                string query = "Select * from Logowanie Where loginID = '" + USERNAME.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
                
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Connection open here   
                
                if (dt.Rows.Count == 1)
                {
                    SqlCommand command = new SqlCommand("SELECT typ FROM Logowanie Where loginID = '" + USERNAME.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'", con);

                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    /// sprawdzanie danych logowania 

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        { //
                            if (1 == reader.GetInt32(0))/// wyrbanie typu pierwszego (DOwodca koompanii) 
                            {
                                DowodcaKP settingsForm = new DowodcaKP();   
                                settingsForm.Show();    ///wyswietlnie storny danego dowoddcy kompanii
                                DowodcaKP.danelogowania = USERNAME.Text;
                                this.Close();


                            }
                            else if (reader.GetInt32(0) == 2)           /// sprawdzenie czy
                            {
                                Oficer settingsForm = new Oficer();
                                settingsForm.Show();    ///wyswietlnie storny oficera
                                Oficer.danelogowania = USERNAME.Text;
                                this.Close();
                            }
                            else if (reader.GetInt32(0) == 3)
                            {
                                sluzba_dyzurna settingsForm = new sluzba_dyzurna();
                                settingsForm.Show();        ///wyswietlnie storny sluzby dyzurnej
                                sluzba_dyzurna.danelogowania = USERNAME.Text;
                                this.Close();
                            }
                            else if (reader.GetInt32(0) == 4)
                            {
                                zolnierz settingsForm = new zolnierz();
                                settingsForm.Show();         ///wyswietlnie storny zolneirza
                                zolnierz.danelogowania = USERNAME.Text;
                                this.Close();
                            }

                        }
                        reader.Close();
                    }
                    else
                    {
                        Console.WriteLine("No rows found."); 
                    }
                    reader.Close();

                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password"); /// komunikat wyswietlanny w przypadku blednego logowania
                }
            }


        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


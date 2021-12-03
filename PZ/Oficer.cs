using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PZ
{
    public partial class Oficer : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        internal static string danelogowania;

        public Oficer()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    // currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                    previousBtn.ForeColor = Color.Snow;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Paneldesktop.Controls.Add(childForm);
            this.Paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPowitanie.Text = childForm.Text;

        }
        private void Oficer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
            this.Hide();
        }
        private void DowodcaKP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Stornagl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Strona_glowna(), sender);

        }

        private void Raport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Raporty(), sender);

        }

        private void Magazyny_Click(object sender, EventArgs e)
        {
          //  OpenChildForm(new Forms.Bronie(), sender);
        }

        private void Alaram_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);


        }

    }
}

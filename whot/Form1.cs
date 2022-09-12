using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void informatyk_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
                egzamin_combobox.Items.Clear();
                egzamin_combobox.Items.Add("INF.02");
                egzamin_combobox.Items.Add("INF.03");
        }

        private void programista_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
                egzamin_combobox.Items.Clear();
                egzamin_combobox.Items.Add("INF.03");
                egzamin_combobox.Items.Add("INF.04");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"[A-Z]{1,}");
            Regex rg2 = new Regex(@"^[A-Z]{1,}[\s1-9]{1,}[\/]{1}[1-9]{1,}$");
            var nazwisko = nazwisko_input.Text;
            var imie = imie_input.Text;
            var data_ur = data_ur_input.Text;
                var miejsce_ur = miejsce_ur_input.Text;
                var pesel = pesel_input.Text;
            var miejscowosc = miejscowosc_input.Text;
            var ulica = ulica_input.Text;
            var kod_pocztowy = kod_pocztowy_input.Text;
            var poczta = poczta_input.Text;
            var nr_tel = nr_tel_input.Text;
            

            if (!rg.IsMatch(nazwisko))
            {
                MessageBox.Show("Nazwisko musi byc z duzych liter","WARNING");
            }
            else if (!rg.IsMatch(imie))
            {
                MessageBox.Show("Imie musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(miejsce_ur))
            {
                MessageBox.Show("Miejsce urodzenia musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(miejscowosc))
            {
                MessageBox.Show("Miejscowosc musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(poczta))
            {
                MessageBox.Show("Poczta musi byc z duzych liter", "WARNING");
            }
            else if (!rg2.IsMatch(ulica))
            {
                MessageBox.Show("ulica musi byc z duzych liter, zawierac numer oraz '/'", "WARNING");
            }

        }

        private void ulica_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void egzamin_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tekst = egzamin_combobox.Text;
            if(tekst == "INF.03")
            {
                egzamin_nazwa_label.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych ";
            }
            else if(tekst == "INF.02")
            {
                egzamin_nazwa_label.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
            }
            else
            {
                egzamin_nazwa_label.Text = "Projektowanie, programowanie i testowanie aplikacji.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pisemna_checkbox.Enabled = false;
            praktyczna_checkbox.Enabled = false;
            pisemna_checkbox.Checked = false;
            praktyczna_checkbox.Checked = false;    
        }

        private void po_raz_kolejny_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            pisemna_checkbox.Enabled = true;
            praktyczna_checkbox.Enabled = true;
        }
    }
}

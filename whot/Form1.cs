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
        public void test_reszta(){
            Regex rg = new Regex(@"[A-Z]{1,}");
            Regex rg2 = new Regex(@"^[A-Z]{1,}[\s1-9]{1,}[\/]{1}[1-9]{1,}$");
            Regex rg3 = new Regex(@"^\+[0-9]{2}[\s]*[0-9]{3}[\s]*[0-9]{3}[\s]*[0-9]{3}$");
            Regex rg4 = new Regex(@"^\+[0-9{2}[\s]*[0-9]{2}[\s]+[0-9]{7}$");
            string nazwisko = nazwisko_input.Text;
            var data_ur = data_ur_input.Text;
            var miejsce_ur = miejsce_ur_input.Text;
            var miejscowosc = miejscowosc_input.Text;
            var ulica = ulica_input.Text;
            var kod_pocztowy = kod_pocztowy_input.Text;
            var poczta = poczta_input.Text;
            var nr_tel = nr_tel_input.Text;
            var mail = mail_input.Text;
            string imie = imie_input.Text;
            var pesel = imie_input.Text;
            if (nazwisko != "" || imie != "" || data_ur != "" || miejsce_ur != "" || pesel != "" || miejscowosc != "" || ulica != "" || kod_pocztowy != "" || poczta != "" || nr_tel != "" || mail != "")
            {
                BackColor = Color.Red;
                MessageBox.Show("Pola nie mogą być puste", "WARNING");
            }
            else if (!rg.IsMatch(nazwisko))
            {
                nazwisko_input.BackColor = Color.Red;
                MessageBox.Show("Nazwisko musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(imie))
            {
                imie_input.BackColor = Color.Red;
                MessageBox.Show("Imie musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(miejsce_ur))
            {
                miejsce_ur_input.BackColor = Color.Red;
                MessageBox.Show("Miejsce urodzenia musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(miejscowosc))
            {
                miejscowosc_input.BackColor = Color.Red;
                MessageBox.Show("Miejscowosc musi byc z duzych liter", "WARNING");
            }
            else if (!rg.IsMatch(poczta))
            {
                poczta_input.BackColor = Color.Red;
                MessageBox.Show("Poczta musi byc z duzych liter", "WARNING");
            }
            else if (!rg2.IsMatch(ulica))
            {
                ulica_input.BackColor = Color.Red;
                MessageBox.Show("ulica musi byc z duzych liter, zawierac numer oraz '/'", "WARNING");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var pesel = pesel_input.Text;
            string imie = imie_input.Text;

            var last_number = pesel[9];
            
            if (imie.EndsWith("a") && last_number%2 == 0)
            {
                pesel_input.BackColor = Color.Red;
                imie_input.BackColor = Color.Red;
                MessageBox.Show("Imie kończące się na 'A' musi mieć parzysta przedostatnią liczbę.", "WARNING");
            }
            else if(!imie.EndsWith("a") && last_number%2 == 1)
            {
                pesel_input.BackColor = Color.Red;
                imie_input.BackColor = Color.Red;
                MessageBox.Show("Imie nie kończące się na 'A' musi mieć nieparzystą przedostatnią liczbę.", "WARNING");
            }
            else
            {
                
                MessageBox.Show("Pesel lub imie są podane nieprawidłowo","WARNING");
            }


        }

        private void ulica_input_TextChanged(object sender, EventArgs e)
        {
            ulica_input.BackColor = Color.White;
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

        private void nazwisko_input_TextChanged(object sender, EventArgs e)
        {
            nazwisko_input.BackColor = Color.White;
        }

        private void imie_input_TextChanged(object sender, EventArgs e)
        {
            imie_input.BackColor = Color.White;
        }

        private void miejsce_ur_input_TextChanged(object sender, EventArgs e)
        {
            miejsce_ur_input.BackColor = Color.White;
        }

        private void pesel_input_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void miejscowosc_input_TextChanged(object sender, EventArgs e)
        {
            miejscowosc_input.BackColor = Color.White;
        }

        private void poczta_input_TextChanged(object sender, EventArgs e)
        {
            poczta_input.BackColor = Color.White;
        }

        private void nr_tel_input_TextChanged(object sender, EventArgs e)
        {
            nr_tel_input.BackColor = Color.White;
        }

        private void mail_input_TextChanged(object sender, EventArgs e)
        {
            mail_input.BackColor = Color.White;
        }

        private void pesel_input_TextChanged(object sender, EventArgs e)
        {
            pesel_input.BackColor = Color.White;
        }
    }
}

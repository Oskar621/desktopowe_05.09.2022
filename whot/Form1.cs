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

        }

        private void programista_radiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"[A-Z]{1,}");
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

            if (rg.IsMatch(nazwisko))
            {

            }
                
        }
    }
}

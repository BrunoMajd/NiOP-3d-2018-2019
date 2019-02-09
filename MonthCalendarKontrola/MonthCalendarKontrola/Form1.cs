using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
            //messagebox u slucaju da korisnik nije odabrao vise dana od 1
            if (ts.Days < 1)
            {
                MessageBox.Show("Tipkom SHIFT ili držanjem lijeve tipke miša odaberite željeni opseg datuma usluge.");
                return;
            }
            //messsagebox o trajanju dana rezervacije
            MessageBox.Show("Rezervirali ste usluge u trajanju od " + ts.Days.ToString() + "dana.", "Rezervacija");
            // messagebox o pocetku i zavrsetku rezervacije
            MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString());
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ime programa: Month Calendar Kontrola \n Ime i Prezime: Bruno Majdenic, 3d\n Datum: 9.2.2019.");
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n https://creativecommons.org/licenses/by-nc-sa/4.0/ \n Davatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }
    }
}

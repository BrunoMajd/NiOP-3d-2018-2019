using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRezervacija_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DateTime dt1 = dateTimePickerDatum.Value;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Datum leta je :\n");
            sb1.Append(dt1.ToShortDateString() + "\n");
            DateTime dt2 = dateTimePickerVrijeme.Value;
            sb1.Append("Vrijeme polaska je u :\n");
            sb1.Append(dt2.ToShortTimeString());
            richTextBox1.AppendText(sb1.ToString());
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ime programa: DateTime Picker \n Ime i Prezime: Bruno Majdenic, 3d\n Datum: 9.2.2019.");
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n https://creativecommons.org/licenses/by-nc-sa/4.0/ \n Davatelj licence dopušta umnožavanje, distribuiranje i priopćavanje djela javnosti. Zauzvrat primatelji licence moraju imenovanjem priznati i označiti izvornog autora.");
        }
    }
}

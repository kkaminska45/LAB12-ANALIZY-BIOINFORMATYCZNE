using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB12_ANALIZY_BIOINFORMATYCZNE.Form2;

namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    public partial class Form4 : Form
    {
        private Sesja aktualnaSesja;

        public Form4(Sesja sesja)
        {
            InitializeComponent();
            aktualnaSesja = sesja;
            labelWstawNazweSesji.Text = aktualnaSesja.Tytul;
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Wpis
        {
            public string Opis { get; set; }
            public string SciezkaZalacznika { get; set; }
            public DateTime DataDodania { get; set; }
        }
        private string sciezkaZalacznika = "";
        private void btnDodajZalacznik_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki danych (*.fasta;*.csv;*.png)|*.fasta;*.csv;*.png|Wszystkie pliki|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaZalacznika = dialog.FileName;
                MessageBox.Show("Załącznik dodany: " + Path.GetFileName(sciezkaZalacznika));
            }
        }

        private void btnZapiszWpis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxOpis.Text))
            {
                MessageBox.Show("Wpis musi mieć opis!");
                return;
            }

            Wpis nowyWpis = new Wpis
            {
                Opis = richTextBoxOpis.Text,
                SciezkaZalacznika = sciezkaZalacznika,
                DataDodania = DateTime.Now
            };
            DatabaseHelper.DodajWpis(aktualnaSesja.IdSesji, nowyWpis);

            aktualnaSesja.Wpisy.Add(nowyWpis);

            MessageBox.Show("Wpis dodany do sesji!");
            this.Close();
        }
    }
}

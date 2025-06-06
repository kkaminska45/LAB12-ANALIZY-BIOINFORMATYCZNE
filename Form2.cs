using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB12_ANALIZY_BIOINFORMATYCZNE.Form4;

namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPowrotDoGlownegoFormsa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class Sesja
        {
            public string IdSesji { get; set; }
            public string Tytul { get; set; }
            public DateTime DataUtworzenia { get; set; }
            public List<Wpis> Wpisy { get; set; } = new();

        }

        public static class SesjeRepo
        {
            public static List<Sesja> ListaSesji { get; set; } = new List<Sesja>();
        }

        private void btnDodajTytulData_Click(object sender, EventArgs e)
        {
            string tytul = textBoxTytul.Text;
            DateTime data = dateTimePickerDataSesji.Value;

            if (!string.IsNullOrWhiteSpace(tytul))
            {
                int numer = SesjeRepo.ListaSesji.Count + 1; 
                string idGenerowane = $"{numer.ToString("D5")}SA";

                Sesja nowaSesja = new Sesja
                {
                    IdSesji = idGenerowane,
                    Tytul = tytul,
                    DataUtworzenia = data
                };
                DatabaseHelper.DodajSesje(nowaSesja);


                SesjeRepo.ListaSesji.Add(nowaSesja);

                MessageBox.Show($"Sesja dodana! ID: {idGenerowane}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaj tytuł sesji.");
            }
        }
    }
}

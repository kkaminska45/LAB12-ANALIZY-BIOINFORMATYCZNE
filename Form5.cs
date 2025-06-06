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
    public partial class Form5 : Form
    {
        private Sesja aktualnaSesja;

        public Form5(Sesja sesja)
        {
            InitializeComponent();
            aktualnaSesja = sesja;
            labelTytulWpisy.Text = sesja.Tytul;
            WyswietlWpisy();
        }

        private void btnPowrotWpisy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WyswietlWpisy()
        {
            dataGridViewWpisy.Rows.Clear();

            foreach (var wpis in aktualnaSesja.Wpisy)
            {
                string typZalacznika = string.IsNullOrEmpty(wpis.SciezkaZalacznika)
                    ? "brak"
                    : Path.GetExtension(wpis.SciezkaZalacznika).ToLower();

                string skroconyOpis = wpis.Opis.Length > 30 ? wpis.Opis.Substring(0, 30) + "..." : wpis.Opis;

                dataGridViewWpisy.Rows.Add(wpis.DataDodania.ToString("yyyy-MM-dd HH:mm"), skroconyOpis, typZalacznika);
            }
        }

        private void btnZobaczWpis_Click(object sender, EventArgs e)
        {
            if (dataGridViewWpisy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz wpis.");
                return;
            }

            int index = dataGridViewWpisy.SelectedRows[0].Index;
            var wpis = aktualnaSesja.Wpisy[index];

            labelTytulWpisy.Text = aktualnaSesja.Tytul;
            richTextBoxOpisWpisu.Text = wpis.Opis;

            string sciezka = wpis.SciezkaZalacznika;
            labelTypWpisy.Text = string.IsNullOrEmpty(sciezka) ? "brak" : Path.GetExtension(sciezka);

            pictureBoxZalacznik.Visible = false;
            dataGridViewCSV.Visible = false;
            richTextBoxFasta.Visible = false;

            if (!string.IsNullOrEmpty(sciezka) && File.Exists(sciezka))
            {
                string ext = Path.GetExtension(sciezka).ToLower();

                if (ext == ".png" || ext == ".jpg")
                {
                    pictureBoxZalacznik.Image = Image.FromFile(sciezka);
                    pictureBoxZalacznik.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxZalacznik.Visible = true;
                }
                else if (ext == ".csv")
                {
                    var dt = new DataTable();
                    using (var reader = new StreamReader(sciezka))
                    {
                        string headerLine = reader.ReadLine();
                        if (headerLine != null)
                        {
                            var headers = headerLine.Split(',');
                            foreach (var h in headers)
                                dt.Columns.Add(h);

                            int rowLimit = 10;
                            int rowCount = 0;
                            while (!reader.EndOfStream && rowCount < rowLimit)
                            {
                                var row = reader.ReadLine().Split(',');
                                dt.Rows.Add(row);
                                rowCount++;
                            }
                        }
                    }

                    dataGridViewCSV.DataSource = dt;
                    dataGridViewCSV.Visible = true;
                }
                else if (ext == ".fasta")
                {
                    var lines = File.ReadLines(sciezka).Take(10);
                    richTextBoxFasta.Text = string.Join("\n", lines);
                    richTextBoxFasta.Visible = true;
                }
                else
                {
                    MessageBox.Show("Nieobsługiwany typ załącznika.");
                }
            }
        }

        private void btnUsunWpis_Click(object sender, EventArgs e)
        {
            if (dataGridViewWpisy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz wpis do usunięcia.");
                return;
            }
            int index = dataGridViewWpisy.SelectedRows[0].Index;
            if (index < 0 || index >= aktualnaSesja.Wpisy.Count)
            {
                MessageBox.Show("Nieprawidłowy indeks wpisu.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć wybrany wpis?",
                                                "Potwierdzenie usunięcia",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                aktualnaSesja.Wpisy.RemoveAt(index);

                WyswietlWpisy();

                richTextBoxOpisWpisu.Clear();
                pictureBoxZalacznik.Image = null;
                pictureBoxZalacznik.Visible = false;
                dataGridViewCSV.Visible = false;
                dataGridViewCSV.DataSource = null;
                richTextBoxFasta.Clear();
                richTextBoxFasta.Visible = false;
                labelTypWpisy.Text = "";

                MessageBox.Show("Wpis został usunięty.");
            }
        }
    }
}

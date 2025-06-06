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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }

        private void btnPowrotZListy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WyswietlSesje(List<Sesja> lista)
        {
            dataGridViewSesje.Rows.Clear();

            foreach (var sesja in lista)
            {
                string datyWpisow = string.Join("\n", sesja.Wpisy.Select(w => w.DataDodania.ToString("yyyy-MM-dd")));
                dataGridViewSesje.Rows.Add(sesja.IdSesji, sesja.Tytul, sesja.DataUtworzenia.ToShortDateString(), datyWpisow);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WyswietlSesje(SesjeRepo.ListaSesji);
            dataGridViewSesje.Columns["Wpisy"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewSesje.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            var sesje = DatabaseHelper.PobierzSesje();
            dataGridViewSesje.Rows.Clear();
            foreach (var sesja in sesje)
            {
                dataGridViewSesje.Rows.Add(sesja.IdSesji, sesja.Tytul, sesja.DataUtworzenia);
            }
        }

        private void textBoxWyszukaj_TextChanged(object sender, EventArgs e)
        {
            string fraza = textBoxWyszukaj.Text.ToLower();

            var filtrowane = SesjeRepo.ListaSesji.Where(s =>
                s.Tytul.ToLower().Contains(fraza) ||
                s.IdSesji.ToLower().Contains(fraza) ||
                s.DataUtworzenia.ToShortDateString().Contains(fraza)
            ).ToList();

            WyswietlSesje(filtrowane);
        }

        private void btnDodajWpis_Click(object sender, EventArgs e)
        {
            if (dataGridViewSesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz sesję, do której chcesz dodać wpis.");
                return;
            }

            string idSesji = dataGridViewSesje.SelectedRows[0].Cells[0].Value.ToString();
            var wybranaSesja = SesjeRepo.ListaSesji.FirstOrDefault(s => s.IdSesji == idSesji);

            if (wybranaSesja != null)
            {
                var Form4 = new Form4(wybranaSesja);
                Form4.ShowDialog();
                WyswietlSesje(SesjeRepo.ListaSesji);
            }
        }

        private void btnUsunSesje_Click(object sender, EventArgs e)
        {
            if (dataGridViewSesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz sesję do usunięcia.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną sesję?",
                                                "Potwierdzenie usunięcia",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string idSesji = dataGridViewSesje.SelectedRows[0].Cells[0].Value.ToString();

                var sesjaDoUsuniecia = SesjeRepo.ListaSesji.FirstOrDefault(s => s.IdSesji == idSesji);
                if (sesjaDoUsuniecia != null)
                {
                    SesjeRepo.ListaSesji.Remove(sesjaDoUsuniecia);

                    WyswietlSesje(SesjeRepo.ListaSesji);

                    MessageBox.Show("Sesja została usunięta.");
                }
            }
        }

        private void btnZobaczWpis_Click(object sender, EventArgs e)
        {
            if (dataGridViewSesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz sesję, aby zobaczyć wpisy.");
                return;
            }

            string idSesji = dataGridViewSesje.SelectedRows[0].Cells[0].Value.ToString();

            var wybranaSesja = SesjeRepo.ListaSesji.FirstOrDefault(s => s.IdSesji == idSesji);

            if (wybranaSesja != null)
            {
                Form5 formWpisy = new Form5(wybranaSesja);
                formWpisy.ShowDialog();
            }
        }

        private void btnGenerujPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewSesje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz sesję do eksportu.");
                return;
            }

            string idSesji = dataGridViewSesje.SelectedRows[0].Cells[0].Value.ToString();
            var sesja = SesjeRepo.ListaSesji.FirstOrDefault(s => s.IdSesji == idSesji);

            if (sesja == null)
            {
                MessageBox.Show("Nie znaleziono wybranej sesji.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Plik PDF (*.pdf)|*.pdf",
                FileName = $"Raport_{sesja.IdSesji}.pdf"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    var textFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    doc.Add(new Paragraph($"Raport sesji: {sesja.Tytul}", titleFont));
                    doc.Add(new Paragraph($"Data utworzenia: {sesja.DataUtworzenia.ToShortDateString()}", textFont));
                    doc.Add(new Paragraph(" "));

                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                    foreach (var wpis in sesja.Wpisy)
                    {
                        doc.Add(new Paragraph($"Data wpisu: {wpis.DataDodania}", boldFont));
                        doc.Add(new Paragraph("Opis:", boldFont));
                        doc.Add(new Paragraph(wpis.Opis, textFont));

                        if (!string.IsNullOrEmpty(wpis.SciezkaZalacznika) && File.Exists(wpis.SciezkaZalacznika))
                        {
                            string ext = Path.GetExtension(wpis.SciezkaZalacznika).ToLower();
                            doc.Add(new Paragraph($"Załącznik: {Path.GetFileName(wpis.SciezkaZalacznika)} ({ext})", boldFont));
                            doc.Add(new Paragraph(" "));

                            if (ext == ".jpg" || ext == ".png")
                            {
                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(wpis.SciezkaZalacznika);
                                img.ScaleToFit(400f, 400f);
                                img.SpacingBefore = 10f;
                                img.SpacingAfter = 10f;
                                doc.Add(img);
                                doc.Add(new Paragraph(" "));
                            }
                            else if (ext == ".csv")
                            {
                                var lines = File.ReadLines(wpis.SciezkaZalacznika).Take(10).ToList();
                                if (lines.Count > 0)
                                {
                                    PdfPTable table = new PdfPTable(lines[0].Split(',').Length);

                                    foreach (var line in lines)
                                    {
                                        var cells = line.Split(',');
                                        foreach (var cell in cells)
                                        {
                                            table.AddCell(cell);
                                        }
                                    }

                                    doc.Add(new Paragraph("Fragment pliku CSV:", boldFont));
                                    doc.Add(new Paragraph(" "));
                                    doc.Add(table);
                                    doc.Add(new Paragraph(" "));
                                }
                            }
                            else if (ext == ".fasta")
                            {
                                var lines = File.ReadLines(wpis.SciezkaZalacznika).Take(10);
                                doc.Add(new Paragraph("Fragment pliku FASTA:", boldFont));
                                foreach (var line in lines)
                                {
                                    doc.Add(new Paragraph(line, textFont));
                                }
                            }
                            else
                            {
                                doc.Add(new Paragraph("Nieobsługiwany typ załącznika.", textFont));
                            }
                        }
                        else
                        {
                            doc.Add(new Paragraph("Brak załącznika.", textFont));
                        }

                        doc.NewPage();
                    }

                    doc.Close();
                }

                MessageBox.Show("PDF został wygenerowany pomyślnie.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy generowaniu PDF: " + ex.Message);
            }
        }
    }
}

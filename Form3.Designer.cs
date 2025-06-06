namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridViewSesje = new DataGridView();
            IdSesji = new DataGridViewTextBoxColumn();
            Tytul = new DataGridViewTextBoxColumn();
            DataUtworzenia = new DataGridViewTextBoxColumn();
            Wpisy = new DataGridViewTextBoxColumn();
            btnDodajWpis = new Button();
            btnZobaczWpis = new Button();
            btnGenerujPDF = new Button();
            btnUsunSesje = new Button();
            btnPowrotZListy = new Button();
            label2 = new Label();
            textBoxWyszukaj = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSesje).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(163, 18);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista twoich sesji:";
            // 
            // dataGridViewSesje
            // 
            dataGridViewSesje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSesje.Columns.AddRange(new DataGridViewColumn[] { IdSesji, Tytul, DataUtworzenia, Wpisy });
            dataGridViewSesje.Location = new Point(24, 58);
            dataGridViewSesje.Name = "dataGridViewSesje";
            dataGridViewSesje.RowHeadersWidth = 51;
            dataGridViewSesje.Size = new Size(553, 285);
            dataGridViewSesje.TabIndex = 1;
            // 
            // IdSesji
            // 
            IdSesji.HeaderText = "ID ";
            IdSesji.MinimumWidth = 6;
            IdSesji.Name = "IdSesji";
            IdSesji.Width = 125;
            // 
            // Tytul
            // 
            Tytul.HeaderText = "Tytuł";
            Tytul.MinimumWidth = 6;
            Tytul.Name = "Tytul";
            Tytul.Width = 125;
            // 
            // DataUtworzenia
            // 
            DataUtworzenia.HeaderText = "Data utworzenia";
            DataUtworzenia.MinimumWidth = 6;
            DataUtworzenia.Name = "DataUtworzenia";
            DataUtworzenia.Width = 125;
            // 
            // Wpisy
            // 
            Wpisy.HeaderText = "Wpisy";
            Wpisy.MinimumWidth = 6;
            Wpisy.Name = "Wpisy";
            Wpisy.Width = 125;
            // 
            // btnDodajWpis
            // 
            btnDodajWpis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajWpis.Location = new Point(617, 85);
            btnDodajWpis.Name = "btnDodajWpis";
            btnDodajWpis.Size = new Size(167, 29);
            btnDodajWpis.TabIndex = 2;
            btnDodajWpis.Text = "Dodaj wpis";
            btnDodajWpis.UseVisualStyleBackColor = true;
            btnDodajWpis.Click += btnDodajWpis_Click;
            // 
            // btnZobaczWpis
            // 
            btnZobaczWpis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZobaczWpis.Location = new Point(617, 130);
            btnZobaczWpis.Name = "btnZobaczWpis";
            btnZobaczWpis.Size = new Size(167, 29);
            btnZobaczWpis.TabIndex = 3;
            btnZobaczWpis.Text = "Przeglądaj wpisy";
            btnZobaczWpis.UseVisualStyleBackColor = true;
            btnZobaczWpis.Click += btnZobaczWpis_Click;
            // 
            // btnGenerujPDF
            // 
            btnGenerujPDF.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnGenerujPDF.Location = new Point(617, 175);
            btnGenerujPDF.Name = "btnGenerujPDF";
            btnGenerujPDF.Size = new Size(167, 29);
            btnGenerujPDF.TabIndex = 4;
            btnGenerujPDF.Text = "Wygeneruj raport .pdf";
            btnGenerujPDF.UseVisualStyleBackColor = true;
            btnGenerujPDF.Click += btnGenerujPDF_Click;
            // 
            // btnUsunSesje
            // 
            btnUsunSesje.Location = new Point(617, 221);
            btnUsunSesje.Name = "btnUsunSesje";
            btnUsunSesje.Size = new Size(167, 29);
            btnUsunSesje.TabIndex = 5;
            btnUsunSesje.Text = "Usuń sesję";
            btnUsunSesje.UseVisualStyleBackColor = true;
            btnUsunSesje.Click += btnUsunSesje_Click;
            // 
            // btnPowrotZListy
            // 
            btnPowrotZListy.Location = new Point(617, 269);
            btnPowrotZListy.Name = "btnPowrotZListy";
            btnPowrotZListy.Size = new Size(167, 29);
            btnPowrotZListy.TabIndex = 6;
            btnPowrotZListy.Text = "Powrót";
            btnPowrotZListy.UseVisualStyleBackColor = true;
            btnPowrotZListy.Click += btnPowrotZListy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(34, 355);
            label2.Name = "label2";
            label2.Size = new Size(206, 18);
            label2.TabIndex = 7;
            label2.Text = "Wyszukaj po nazwie/dacie/ID:";
            // 
            // textBoxWyszukaj
            // 
            textBoxWyszukaj.Location = new Point(246, 350);
            textBoxWyszukaj.Name = "textBoxWyszukaj";
            textBoxWyszukaj.Size = new Size(206, 27);
            textBoxWyszukaj.TabIndex = 8;
            textBoxWyszukaj.TextChanged += textBoxWyszukaj_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 387);
            Controls.Add(textBoxWyszukaj);
            Controls.Add(label2);
            Controls.Add(btnPowrotZListy);
            Controls.Add(btnUsunSesje);
            Controls.Add(btnGenerujPDF);
            Controls.Add(btnZobaczWpis);
            Controls.Add(btnDodajWpis);
            Controls.Add(dataGridViewSesje);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sesje";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSesje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewSesje;
        private Button btnDodajWpis;
        private Button btnZobaczWpis;
        private Button btnGenerujPDF;
        private Button btnUsunSesje;
        private Button btnPowrotZListy;
        private Label label2;
        private TextBox textBoxWyszukaj;
        private DataGridViewTextBoxColumn IdSesji;
        private DataGridViewTextBoxColumn Tytul;
        private DataGridViewTextBoxColumn DataUtworzenia;
        private DataGridViewTextBoxColumn Wpisy;
    }
}
namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    partial class Form5
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
            richTextBoxOpisWpisu = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridViewWpisy = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Opis = new DataGridViewTextBoxColumn();
            Zalacznik = new DataGridViewTextBoxColumn();
            label4 = new Label();
            labelTytulWpisy = new Label();
            label5 = new Label();
            labelTypWpisy = new Label();
            label6 = new Label();
            btnZobaczWpis = new Button();
            btnPowrotWpisy = new Button();
            pictureBoxZalacznik = new PictureBox();
            dataGridViewCSV = new DataGridView();
            richTextBoxFasta = new RichTextBox();
            btnUsunWpis = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWpisy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZalacznik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(68, 23);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista wpisów:";
            // 
            // richTextBoxOpisWpisu
            // 
            richTextBoxOpisWpisu.Location = new Point(60, 396);
            richTextBoxOpisWpisu.Name = "richTextBoxOpisWpisu";
            richTextBoxOpisWpisu.Size = new Size(248, 140);
            richTextBoxOpisWpisu.TabIndex = 2;
            richTextBoxOpisWpisu.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-11, 306);
            label2.Name = "label2";
            label2.Size = new Size(867, 20);
            label2.TabIndex = 3;
            label2.Text = "_______________________________________________________________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 9F);
            label3.Location = new Point(12, 348);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 4;
            label3.Text = "Tytuł sesji:";
            // 
            // dataGridViewWpisy
            // 
            dataGridViewWpisy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWpisy.Columns.AddRange(new DataGridViewColumn[] { Data, Opis, Zalacznik });
            dataGridViewWpisy.Location = new Point(24, 54);
            dataGridViewWpisy.Name = "dataGridViewWpisy";
            dataGridViewWpisy.RowHeadersWidth = 51;
            dataGridViewWpisy.Size = new Size(428, 227);
            dataGridViewWpisy.TabIndex = 5;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.Width = 125;
            // 
            // Opis
            // 
            Opis.HeaderText = "Opis (skrócony)";
            Opis.MinimumWidth = 6;
            Opis.Name = "Opis";
            Opis.Width = 125;
            // 
            // Zalacznik
            // 
            Zalacznik.HeaderText = "Załącznik";
            Zalacznik.MinimumWidth = 6;
            Zalacznik.Name = "Zalacznik";
            Zalacznik.Width = 125;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 9F);
            label4.Location = new Point(12, 396);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 6;
            label4.Text = "Opis:";
            // 
            // labelTytulWpisy
            // 
            labelTytulWpisy.AutoSize = true;
            labelTytulWpisy.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTytulWpisy.Location = new Point(103, 348);
            labelTytulWpisy.Name = "labelTytulWpisy";
            labelTytulWpisy.Size = new Size(42, 18);
            labelTytulWpisy.TabIndex = 7;
            labelTytulWpisy.Text = "tytuł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Constantia", 9F);
            label5.Location = new Point(371, 348);
            label5.Name = "label5";
            label5.Size = new Size(106, 18);
            label5.TabIndex = 8;
            label5.Text = "Typ załącznika:";
            // 
            // labelTypWpisy
            // 
            labelTypWpisy.AutoSize = true;
            labelTypWpisy.Font = new Font("Constantia", 9F);
            labelTypWpisy.Location = new Point(492, 348);
            labelTypWpisy.Name = "labelTypWpisy";
            labelTypWpisy.Size = new Size(28, 18);
            labelTypWpisy.TabIndex = 9;
            labelTypWpisy.Text = "typ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 9F);
            label6.Location = new Point(371, 379);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 10;
            label6.Text = "Załącznik:";
            // 
            // btnZobaczWpis
            // 
            btnZobaczWpis.Location = new Point(492, 73);
            btnZobaczWpis.Name = "btnZobaczWpis";
            btnZobaczWpis.Size = new Size(137, 29);
            btnZobaczWpis.TabIndex = 11;
            btnZobaczWpis.Text = "Zobacz wpis";
            btnZobaczWpis.UseVisualStyleBackColor = true;
            btnZobaczWpis.Click += btnZobaczWpis_Click;
            // 
            // btnPowrotWpisy
            // 
            btnPowrotWpisy.Location = new Point(492, 108);
            btnPowrotWpisy.Name = "btnPowrotWpisy";
            btnPowrotWpisy.Size = new Size(137, 29);
            btnPowrotWpisy.TabIndex = 12;
            btnPowrotWpisy.Text = "Powrót";
            btnPowrotWpisy.UseVisualStyleBackColor = true;
            btnPowrotWpisy.Click += btnPowrotWpisy_Click;
            // 
            // pictureBoxZalacznik
            // 
            pictureBoxZalacznik.Location = new Point(371, 408);
            pictureBoxZalacznik.Name = "pictureBoxZalacznik";
            pictureBoxZalacznik.Size = new Size(228, 128);
            pictureBoxZalacznik.TabIndex = 13;
            pictureBoxZalacznik.TabStop = false;
            // 
            // dataGridViewCSV
            // 
            dataGridViewCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCSV.Location = new Point(371, 400);
            dataGridViewCSV.Name = "dataGridViewCSV";
            dataGridViewCSV.RowHeadersWidth = 51;
            dataGridViewCSV.Size = new Size(258, 136);
            dataGridViewCSV.TabIndex = 14;
            // 
            // richTextBoxFasta
            // 
            richTextBoxFasta.Location = new Point(371, 400);
            richTextBoxFasta.Name = "richTextBoxFasta";
            richTextBoxFasta.Size = new Size(258, 140);
            richTextBoxFasta.TabIndex = 15;
            richTextBoxFasta.Text = "";
            // 
            // btnUsunWpis
            // 
            btnUsunWpis.Location = new Point(492, 143);
            btnUsunWpis.Name = "btnUsunWpis";
            btnUsunWpis.Size = new Size(137, 29);
            btnUsunWpis.TabIndex = 16;
            btnUsunWpis.Text = "Usuń wpis";
            btnUsunWpis.UseVisualStyleBackColor = true;
            btnUsunWpis.Click += btnUsunWpis_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 566);
            Controls.Add(btnUsunWpis);
            Controls.Add(richTextBoxFasta);
            Controls.Add(dataGridViewCSV);
            Controls.Add(pictureBoxZalacznik);
            Controls.Add(btnPowrotWpisy);
            Controls.Add(btnZobaczWpis);
            Controls.Add(label6);
            Controls.Add(labelTypWpisy);
            Controls.Add(label5);
            Controls.Add(labelTytulWpisy);
            Controls.Add(label4);
            Controls.Add(dataGridViewWpisy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxOpisWpisu);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Wpisy";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWpisy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZalacznik).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxOpisWpisu;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewWpisy;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Opis;
        private DataGridViewTextBoxColumn Zalacznik;
        private Label label4;
        private Label labelTytulWpisy;
        private Label label5;
        private Label labelTypWpisy;
        private Label label6;
        private Button btnZobaczWpis;
        private Button btnPowrotWpisy;
        private PictureBox pictureBoxZalacznik;
        private DataGridView dataGridViewCSV;
        private RichTextBox richTextBoxFasta;
        private Button btnUsunWpis;
    }
}
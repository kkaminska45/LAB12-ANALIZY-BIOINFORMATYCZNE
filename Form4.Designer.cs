namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    partial class Form4
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
            btnDodajZalacznik = new Button();
            label2 = new Label();
            richTextBoxOpis = new RichTextBox();
            btnZapiszWpis = new Button();
            btnPowrot = new Button();
            labelWstawNazweSesji = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 0;
            label1.Text = "Dodaj wpis do swojej sesji:";
            // 
            // btnDodajZalacznik
            // 
            btnDodajZalacznik.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajZalacznik.Location = new Point(107, 204);
            btnDodajZalacznik.Name = "btnDodajZalacznik";
            btnDodajZalacznik.Size = new Size(195, 29);
            btnDodajZalacznik.TabIndex = 1;
            btnDodajZalacznik.Text = "Dodaj załącznik";
            btnDodajZalacznik.UseVisualStyleBackColor = true;
            btnDodajZalacznik.Click += btnDodajZalacznik_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 2;
            label2.Text = "Opis:";
            // 
            // richTextBoxOpis
            // 
            richTextBoxOpis.Location = new Point(77, 69);
            richTextBoxOpis.Name = "richTextBoxOpis";
            richTextBoxOpis.Size = new Size(251, 120);
            richTextBoxOpis.TabIndex = 3;
            richTextBoxOpis.Text = "";
            // 
            // btnZapiszWpis
            // 
            btnZapiszWpis.Location = new Point(353, 83);
            btnZapiszWpis.Name = "btnZapiszWpis";
            btnZapiszWpis.Size = new Size(94, 29);
            btnZapiszWpis.TabIndex = 4;
            btnZapiszWpis.Text = "Zapisz";
            btnZapiszWpis.UseVisualStyleBackColor = true;
            btnZapiszWpis.Click += btnZapiszWpis_Click;
            // 
            // btnPowrot
            // 
            btnPowrot.Location = new Point(353, 118);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(94, 29);
            btnPowrot.TabIndex = 5;
            btnPowrot.Text = "Powrót";
            btnPowrot.UseVisualStyleBackColor = true;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // labelWstawNazweSesji
            // 
            labelWstawNazweSesji.AutoSize = true;
            labelWstawNazweSesji.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWstawNazweSesji.Location = new Point(289, 23);
            labelWstawNazweSesji.Name = "labelWstawNazweSesji";
            labelWstawNazweSesji.Size = new Size(135, 28);
            labelWstawNazweSesji.TabIndex = 6;
            labelWstawNazweSesji.Text = "nazwa sesji";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 253);
            Controls.Add(labelWstawNazweSesji);
            Controls.Add(btnPowrot);
            Controls.Add(btnZapiszWpis);
            Controls.Add(richTextBoxOpis);
            Controls.Add(label2);
            Controls.Add(btnDodajZalacznik);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Wpis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDodajZalacznik;
        private Label label2;
        private RichTextBox richTextBoxOpis;
        private Button btnZapiszWpis;
        private Button btnPowrot;
        private Label labelWstawNazweSesji;
    }
}
namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            textBoxTytul = new TextBox();
            dateTimePickerDataSesji = new DateTimePicker();
            btnDodajTytulData = new Button();
            btnPowrotDoGlownegoFormsa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(67, 29);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Dodawanie sesji:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 1;
            label2.Text = "Wprowadź tytuł:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(19, 134);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 2;
            label3.Text = "Wybierz datę:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Location = new Point(154, 82);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(250, 27);
            textBoxTytul.TabIndex = 3;
            // 
            // dateTimePickerDataSesji
            // 
            dateTimePickerDataSesji.Location = new Point(154, 127);
            dateTimePickerDataSesji.Name = "dateTimePickerDataSesji";
            dateTimePickerDataSesji.Size = new Size(250, 27);
            dateTimePickerDataSesji.TabIndex = 4;
            // 
            // btnDodajTytulData
            // 
            btnDodajTytulData.Location = new Point(38, 197);
            btnDodajTytulData.Name = "btnDodajTytulData";
            btnDodajTytulData.Size = new Size(129, 29);
            btnDodajTytulData.TabIndex = 5;
            btnDodajTytulData.Text = "Dodaj";
            btnDodajTytulData.UseVisualStyleBackColor = true;
            btnDodajTytulData.Click += btnDodajTytulData_Click;
            // 
            // btnPowrotDoGlownegoFormsa
            // 
            btnPowrotDoGlownegoFormsa.Location = new Point(246, 197);
            btnPowrotDoGlownegoFormsa.Name = "btnPowrotDoGlownegoFormsa";
            btnPowrotDoGlownegoFormsa.Size = new Size(129, 29);
            btnPowrotDoGlownegoFormsa.TabIndex = 6;
            btnPowrotDoGlownegoFormsa.Text = "Powrót";
            btnPowrotDoGlownegoFormsa.UseVisualStyleBackColor = true;
            btnPowrotDoGlownegoFormsa.Click += btnPowrotDoGlownegoFormsa_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 247);
            Controls.Add(btnPowrotDoGlownegoFormsa);
            Controls.Add(btnDodajTytulData);
            Controls.Add(dateTimePickerDataSesji);
            Controls.Add(textBoxTytul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nowa sesja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTytul;
        private DateTimePicker dateTimePickerDataSesji;
        private Button btnDodajTytulData;
        private Button btnPowrotDoGlownegoFormsa;
    }
}
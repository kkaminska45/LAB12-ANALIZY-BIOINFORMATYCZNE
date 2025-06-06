namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNowaSesja = new Button();
            btnListaSesji = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnNowaSesja
            // 
            btnNowaSesja.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNowaSesja.Location = new Point(61, 39);
            btnNowaSesja.Name = "btnNowaSesja";
            btnNowaSesja.Size = new Size(314, 42);
            btnNowaSesja.TabIndex = 0;
            btnNowaSesja.Text = "Dodaj nową sesję";
            btnNowaSesja.UseVisualStyleBackColor = true;
            btnNowaSesja.Click += btnNowaSesja_Click;
            // 
            // btnListaSesji
            // 
            btnListaSesji.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnListaSesji.Location = new Point(61, 98);
            btnListaSesji.Name = "btnListaSesji";
            btnListaSesji.Size = new Size(312, 42);
            btnListaSesji.TabIndex = 1;
            btnListaSesji.Text = "Lista istniejących sesji";
            btnListaSesji.UseVisualStyleBackColor = true;
            btnListaSesji.Click += btnListaSesji_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(21, 153);
            label1.Name = "label1";
            label1.Size = new Size(374, 18);
            label1.TabIndex = 2;
            label1.Text = "Prosty notatnik desktopowy do dokumentowania analiz ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(21, 173);
            label2.Name = "label2";
            label2.Size = new Size(252, 18);
            label2.TabIndex = 3;
            label2.Text = "bioinformatycznych i molekularnych.\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(21, 204);
            label3.Name = "label3";
            label3.Size = new Size(370, 36);
            label3.TabIndex = 4;
            label3.Text = "Twórz sesje, dodawaj opisy, załączniki i generuj raporty \r\nPDF z wynikami.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 259);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListaSesji);
            Controls.Add(btnNowaSesja);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notatnik analityczny";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNowaSesja;
        private Button btnListaSesji;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

using static LAB12_ANALIZY_BIOINFORMATYCZNE.Form2;

namespace LAB12_ANALIZY_BIOINFORMATYCZNE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNowaSesja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 tworzenieSesji = new Form2();
            tworzenieSesji.ShowDialog();
            this.Show();
        }

        private void btnListaSesji_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 listaSesji = new Form3();
            listaSesji.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
            SesjeRepo.ListaSesji = DatabaseHelper.PobierzSesje();
        }
    }
}

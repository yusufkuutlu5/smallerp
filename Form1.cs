namespace smallerpuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value < 30)
            {
                label1.Text = "Sistem dosyalarý okunuyor...";
            }
            else if (progressBar1.Value <60)
            {
                label1.Text = "Stok verileri yükleniyor...";
            }
            else if (progressBar1.Value <90)
            {
                label1.Text = "FIFO maliyetleri hesaplanýyor...";
            }
            else
            {
                label1.Text = "Sistem hazýr! Giriþ yapýlýyor.";
            }
            if (progressBar1.Value >=100)
            {
                timer1.Stop();
                AnaMenu anaForm = new AnaMenu();
                anaForm.Show();
                this.Hide();
            }
        }
    }
}

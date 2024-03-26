namespace checkedbutton
{
    public partial class Form1 : Form
    {
        string tümbuton = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ErkekButon.Checked)
            {
                tümbuton += ("Cinsiyet: Erkek\n");
            }
            else if (KadýnButon.Checked)
            {
                tümbuton += ("Cinsiyet: Kadýn\n");
            }
            else
            {
                tümbuton += ("Cinsiyet: Diðer\n");

            }

            if (bilgiButon.Checked)
            {
                tümbuton += "--Bilgisayar\n";
            }
            if (telButon.Checked)
            {
                tümbuton += "--Telefon\n";
            }
            if (tabletButon.Checked)
            {
                tümbuton += "--Tablet\n";
            }

            MessageBox.Show(tümbuton, "Seçimler: ");
        }
    }
}

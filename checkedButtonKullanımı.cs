namespace checkedbutton
{
    public partial class Form1 : Form
    {
        string t�mbuton = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ErkekButon.Checked)
            {
                t�mbuton += ("Cinsiyet: Erkek\n");
            }
            else if (Kad�nButon.Checked)
            {
                t�mbuton += ("Cinsiyet: Kad�n\n");
            }
            else
            {
                t�mbuton += ("Cinsiyet: Di�er\n");

            }

            if (bilgiButon.Checked)
            {
                t�mbuton += "--Bilgisayar\n";
            }
            if (telButon.Checked)
            {
                t�mbuton += "--Telefon\n";
            }
            if (tabletButon.Checked)
            {
                t�mbuton += "--Tablet\n";
            }

            MessageBox.Show(t�mbuton, "Se�imler: ");
        }
    }
}

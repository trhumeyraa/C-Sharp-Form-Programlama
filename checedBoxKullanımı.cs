namespace checkedbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (y�zde18.Checked == true || y�zde25.Checked == true)
                {
                    int sayi = Convert.ToInt32(textBox1.Text);
                    double sonuc1 = (sayi * 18) / 100;
                    double sonuc2 = (sayi * 25) / 100;

                    if (y�zde18.Checked == true )
                    {
                        MessageBox.Show(Convert.ToString(sonuc1));
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToString(sonuc2));
                    }
                }
                else
                {
                    MessageBox.Show("se�im yap�n�z.");
                }
            }
            else
            {
                MessageBox.Show("de�er giriniz.");
            }
        }
    }
}

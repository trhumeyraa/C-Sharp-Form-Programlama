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
                if (yüzde18.Checked == true || yüzde25.Checked == true)
                {
                    int sayi = Convert.ToInt32(textBox1.Text);
                    double sonuc1 = (sayi * 18) / 100;
                    double sonuc2 = (sayi * 25) / 100;

                    if (yüzde18.Checked == true )
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
                    MessageBox.Show("seçim yapýnýz.");
                }
            }
            else
            {
                MessageBox.Show("deðer giriniz.");
            }
        }
    }
}

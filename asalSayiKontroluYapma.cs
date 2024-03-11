namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int kontrol = 0;
            for(int i = 1; i<sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    kontrol++;
                }
            }
            if (kontrol !=0)
            {
                MessageBox.Show("degil");
            }
            else
            {
                MessageBox.Show("asal");
            }
            }
        }
    }


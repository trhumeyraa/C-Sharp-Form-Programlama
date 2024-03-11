namespace asalSayiBulma
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
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi_k = 0, sayi_b = 0;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                for (int i = sayi_k+1; i < sayi_b; i++)
                {
                    int sayac = 0;
                    for (int j = 2 ; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac++;
                        }
                    }

                        if (sayac == 0)
                        {
                        listBox1.Items.Add(Convert.ToString(i));
                        }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


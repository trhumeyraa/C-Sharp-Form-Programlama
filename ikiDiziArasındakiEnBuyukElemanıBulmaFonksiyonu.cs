using System.Windows.Forms;

namespace enBuyukFonsk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public int fnk_dizi(int[] a, int[] b)
        {

            int dizi_b = a[0];

            for (int j = 1; j < a.Length; j++)
            {
                if (dizi_b < a[j])
                {
                    dizi_b = a[j];

                }
            }

            int dizi_b2 = b[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (dizi_b2 < b[i])
                {
                    dizi_b2 = b[i];

                }
            }

            if (dizi_b > dizi_b2)
            {
                return dizi_b;
            }

            else
            {
                return dizi_b2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    int sayi1 = Convert.ToInt32(textBox3.Text);
                    int sayi2 = Convert.ToInt32(textBox4.Text);
                    int sayi_k = 0, sayi_b = 0;

                    int boyut = Convert.ToInt32(textBox2.Text);
                 
                    int[] dizi1 = new int[boyut];
                    int[] dizi2 = new int[boyut];

                    if (sayi1 < sayi2)
                    {
                        sayi_k = sayi1;
                        sayi_b = sayi2;
                    }
                    else
                    {
                        sayi_b = sayi1;
                        sayi_k = sayi2;
                    }


                    listBox1.Items.Clear();
                    for (int i = 0; i < boyut; i++)
                    {
                        Random rnd = new Random();
                        dizi1[i] = rnd.Next((sayi_k + 1), (sayi_b - 1));
                        listBox1.Items.Add(dizi1[i]);

                    }
                    listBox2.Items.Clear();
                    for (int j = 0; j < boyut; j++)
                    {
                        Random acb = new Random();
                        dizi2[j] = acb.Next((sayi_k + 1), (sayi_b - 1));
                        listBox2.Items.Add(dizi2[j]);

                    }
                    int eb = fnk_dizi(dizi1, dizi2);
                    textBox5.Text = (Convert.ToString(fnk_dizi(dizi1, dizi2)));
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

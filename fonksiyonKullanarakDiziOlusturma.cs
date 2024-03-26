namespace besParametre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int fnk_dizi(int[] a)
        {

            int dizi_k = a[0];

            for (int j = 1; j < a.Length; j++)
            {
                if (dizi_k > a[j])
                {
                    dizi_k = a[j];

                }
            }

            return dizi_k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sayi_k = 0, sayi_b = 0;
                int boyut = Convert.ToInt32(textBox3.Text);
                int[] dizi = new int[boyut];

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
                    dizi[i] = rnd.Next((sayi_k + 1), (sayi_b - 1));
                    listBox1.Items.Add(dizi[i]);

                }
                int ek = fnk_dizi(dizi);
                textBox4.Text=(Convert.ToString(fnk_dizi(dizi)));
            }
        }
    }
} 
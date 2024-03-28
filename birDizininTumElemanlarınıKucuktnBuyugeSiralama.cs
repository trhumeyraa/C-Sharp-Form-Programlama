namespace diziKüçüktenBüyüge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] fnk_Kucuk_Buyuk(int[] dizi)
        {
           
           listBox1.Items.Clear();
            int en_k,temp;

            for (int i = 0; i < dizi.Length; i++)
            {
                en_k = i;
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[en_k] > dizi[j])
                    {
                        en_k = j;
                    }
                }
                temp = dizi[i];
                dizi[i] = dizi[en_k];
                dizi[en_k] = temp;

                listBox1.Items.Add(dizi[i]);
            }
            
            return dizi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int sayi_k = 0, sayi_b = 0;
                int boyut = Convert.ToInt32(textBox3.Text);
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
                    dizi2[i] = rnd.Next((sayi_k + 1), sayi_b );
                    listBox2.Items.Add(dizi2[i]);
                }

                
                fnk_Kucuk_Buyuk(dizi2);
                
            }
        }
    }
}


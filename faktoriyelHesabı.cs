namespace faktoriyelHesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private int fnk_hesabi(int b)
        {
            int carpim = 1;
            
            for (int i = 1; i <=b; i++)
            {
                carpim = i* carpim;
            }
            return carpim;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);   
            int sonuc= fnk_hesabi(sayi1);
            MessageBox.Show(Convert.ToString(sonuc));
        }
    }
}

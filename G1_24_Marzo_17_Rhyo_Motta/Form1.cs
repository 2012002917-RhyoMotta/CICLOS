namespace G1_24_Marzo_17_Rhyo_Motta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int num1 = int.Parse(textBox1.Text);
            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejer ejer = new Ejer();
            ejer.ShowDialog();
            this.Close();
        }
    }
}

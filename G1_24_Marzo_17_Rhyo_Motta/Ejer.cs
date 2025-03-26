using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace G1_24_Marzo_17_Rhyo_Motta
{
    public partial class Ejer : Form
    {
        public Ejer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int cont2 = 1;
            int num2 = int.Parse(textBox1.Text);
            while (cont2 < 11)
            {
                int multi;
                multi = num2 * cont2;

                dataGridView1.Rows.Add(num2, cont2, multi);
                cont2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejer2 ejer = new Ejer2();
            ejer.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_24_Marzo_17_Rhyo_Motta
{
    public partial class Ejer2 : Form
    {
        public Ejer2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont2 = 1;
            int num2 = int.Parse(textBox1.Text);

            do
            {
                int multi;
                multi = num2 * cont2;

                //Agregar los Datos en el DataGribView
                dataGridView1.Rows.Add(num2, cont2, multi);
                cont2++;
            } while (cont2 < 11);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecEjer ejer = new SecEjer();
            ejer.ShowDialog();
        }
    }
}

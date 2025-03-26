using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace G1_24_Marzo_17_Rhyo_Motta
{
    public partial class SecEjer : Form
    {
        public SecEjer()
        {
            InitializeComponent();
        }

        private int[,] matriz1;
        private int[,] matriz2;

        private void button1_Click(object sender, EventArgs e)
        {
            matriz1 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz1[f, c] = Convert.ToInt32(Interaction.InputBox("Ingrese un Número: "));
                    dataGridView1.Rows.Add(matriz1[f, c]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matriz2 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz2[f, c] = Convert.ToInt32(Interaction.InputBox("Ingrese un Número: "));
                    dataGridView1.Rows.Add(matriz2[f, c]);
                }
            }
        }
        //cambios
        private int[,] suma;
        private void button3_Click(object sender, EventArgs e)
        {
            suma = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    suma[f, c] = matriz1[f, c] + matriz2[f, c];
                    dataGridView1.Rows.Add(suma[f, c]);
                }
            }
        }
    }
}

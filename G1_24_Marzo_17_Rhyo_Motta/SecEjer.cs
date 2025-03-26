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

        int[] vector1 = new int[3];
        int[] vector2 = new int[3];
        int[] vectorSum = new int[3];

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (dgvVectors.RowCount != 3) dgvVectors.Rows.Add();
                vector1[i] = int.Parse(Interaction.InputBox($"Ingrese el valor {i + 1} del vector 1:"));
                dgvVectors.Rows[i].Cells[0].Value = (vector1[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (dgvVectors.RowCount != 3) dgvVectors.Rows.Add();
                vector2[i] = int.Parse(Interaction.InputBox($"Ingrese el valor {i + 1} del vector 2:"));
                dgvVectors.Rows[i].Cells[1].Value = (vector2[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (dgvVectors.RowCount != 3) dgvVectors.Rows.Add();
                vectorSum[i] = vector1[i] + vector2[i];
                dgvVectors.Rows[i].Cells[2].Value = (vectorSum[i].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SecEjer2 ejer = new SecEjer2();
            ejer.ShowDialog();
            this.Close();
        }
    }
}

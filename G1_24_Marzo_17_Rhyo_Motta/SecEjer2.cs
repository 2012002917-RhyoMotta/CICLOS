using Microsoft.VisualBasic;
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
    public partial class SecEjer2 : Form
    {
        public SecEjer2()
        {
            InitializeComponent();
        }

        int[,] matrix1 = new int[3, 3];
        int[,] matrix2 = new int[3, 3];
        int[,] matrixResult = new int[3, 3];

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dgvMatrix.Rows[i].Cells[0].Value = null;
                if (dgvMatrix.RowCount != 3) dgvMatrix.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = int.Parse(Interaction.InputBox($"Ingrese el valor [{i + 1},{j + 1}] de la matriz 1:"));
                    dgvMatrix.Rows[i].Cells[0].Value += $"[{matrix1[i, j]}] ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dgvMatrix.Rows[i].Cells[1].Value = null;
                if (dgvMatrix.RowCount != 3) dgvMatrix.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    matrix2[i, j] = int.Parse(Interaction.InputBox($"Ingrese el valor [{i + 1},{j + 1}] de la matriz 2:"));
                    dgvMatrix.Rows[i].Cells[1].Value += $"[{matrix2[i, j]}] ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dgvMatrix.Rows[i].Cells[2].Value = null;
                if (dgvMatrix.RowCount != 3) dgvMatrix.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    matrixResult[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    dgvMatrix.Rows[i].Cells[2].Value += $"[{matrixResult[i, j]}] ";
                }
            }

        }
    }
}

namespace G1_24_Marzo_17_Rhyo_Motta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Numeros = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite un valor:";
            // 
            // button1
            // 
            button1.Location = new Point(211, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "VER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numeros, Multi, Total });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(12, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(341, 242);
            dataGridView1.TabIndex = 3;
            // 
            // Numeros
            // 
            Numeros.HeaderText = "numero";
            Numeros.Name = "Numeros";
            // 
            // Multi
            // 
            Multi.HeaderText = "multiplicacion";
            Multi.Name = "Multi";
            // 
            // Total
            // 
            Total.HeaderText = "total";
            Total.Name = "Total";
            // 
            // button2
            // 
            button2.Location = new Point(292, 6);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 4;
            button2.Text = "Ejer 1.1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 280);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 5;
            label2.Text = "Rhyo Donato Motta Pérez VB 17";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 301);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CICLOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numeros;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn Total;
        private Button button2;
        private Label label2;
    }
}

namespace G1_24_Marzo_17_Rhyo_Motta
{
    partial class Ejer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Numeros = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(292, 12);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 9;
            button2.Text = "Ejer 1.2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numeros, Multi, Total });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(341, 291);
            dataGridView1.TabIndex = 8;
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
            // textBox1
            // 
            textBox1.Location = new Point(105, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(211, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "VER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Digite un valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 338);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 10;
            label2.Text = "Rhyo Donato Motta Pérez VB 17";
            // 
            // Ejer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 361);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Ejer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejer 1.1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numeros;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn Total;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
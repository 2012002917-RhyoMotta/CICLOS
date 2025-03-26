namespace G1_24_Marzo_17_Rhyo_Motta
{
    partial class SecEjer2
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
            dgvMatrix = new DataGridView();
            Matriz1 = new DataGridViewTextBoxColumn();
            Matriz2 = new DataGridViewTextBoxColumn();
            mul = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            SuspendLayout();
            // 
            // dgvMatrix
            // 
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Columns.AddRange(new DataGridViewColumn[] { Matriz1, Matriz2, mul });
            dgvMatrix.Enabled = false;
            dgvMatrix.Location = new Point(12, 41);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.Size = new Size(343, 150);
            dgvMatrix.TabIndex = 3;
            // 
            // Matriz1
            // 
            Matriz1.HeaderText = "Matriz 1";
            Matriz1.Name = "Matriz1";
            // 
            // Matriz2
            // 
            Matriz2.HeaderText = "Matriz 2";
            Matriz2.Name = "Matriz2";
            // 
            // mul
            // 
            mul.HeaderText = "Multiplicacion";
            mul.Name = "mul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 7;
            label1.Text = "Rhyo Donato Motta Pérez VB 17";
            // 
            // button3
            // 
            button3.Location = new Point(263, 12);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 4;
            button3.Text = "MULTIPLICAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(144, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Matriz 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Matriz 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SecEjer2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 217);
            Controls.Add(dgvMatrix);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SecEjer2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejer 2.2";
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMatrix;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Matriz1;
        private DataGridViewTextBoxColumn Matriz2;
        private DataGridViewTextBoxColumn mul;
    }
}
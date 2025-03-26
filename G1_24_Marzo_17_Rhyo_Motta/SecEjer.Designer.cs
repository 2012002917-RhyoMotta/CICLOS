namespace G1_24_Marzo_17_Rhyo_Motta
{
    partial class SecEjer
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
            dgvVectors = new DataGridView();
            Vector1 = new DataGridViewTextBoxColumn();
            Vector2 = new DataGridViewTextBoxColumn();
            sum = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVectors).BeginInit();
            SuspendLayout();
            // 
            // dgvVectors
            // 
            dgvVectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVectors.Columns.AddRange(new DataGridViewColumn[] { Vector1, Vector2, sum });
            dgvVectors.Enabled = false;
            dgvVectors.Location = new Point(12, 41);
            dgvVectors.Name = "dgvVectors";
            dgvVectors.Size = new Size(343, 150);
            dgvVectors.TabIndex = 0;
            // 
            // Vector1
            // 
            Vector1.HeaderText = "Vector 1";
            Vector1.Name = "Vector1";
            // 
            // Vector2
            // 
            Vector2.HeaderText = "Vector 2";
            Vector2.Name = "Vector2";
            // 
            // sum
            // 
            sum.HeaderText = "Suma";
            sum.Name = "sum";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Vector 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(142, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Vector 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(280, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "SUMAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 194);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 2;
            label1.Text = "Rhyo Donato Motta Pérez VB 17";
            // 
            // button4
            // 
            button4.Location = new Point(280, 190);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "Ejer 2.2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SecEjer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 217);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvVectors);
            Name = "SecEjer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejer 2.1";
            ((System.ComponentModel.ISupportInitialize)dgvVectors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVectors;
        private Button button1;
        private DataGridViewTextBoxColumn Vector1;
        private DataGridViewTextBoxColumn Vector2;
        private DataGridViewTextBoxColumn sum;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}
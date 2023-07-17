namespace appFd.condicionales
{
    partial class _10
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
            lblNotas = new Label();
            lblNotamayor = new Label();
            lblNotamenor = new Label();
            txtNotas = new TextBox();
            txtnotamayor = new TextBox();
            txtnotamenor = new TextBox();
            lblpromedioA = new Label();
            txtpromedioA = new TextBox();
            btnCalcular = new Button();
            lblpromedio = new Label();
            txtpromedio = new TextBox();
            SuspendLayout();
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(140, 60);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(51, 20);
            lblNotas.TabIndex = 0;
            lblNotas.Text = "Notas:";
            // 
            // lblNotamayor
            // 
            lblNotamayor.AutoSize = true;
            lblNotamayor.Location = new Point(49, 122);
            lblNotamayor.Name = "lblNotamayor";
            lblNotamayor.Size = new Size(158, 20);
            lblNotamayor.TabIndex = 0;
            lblNotamayor.Text = "Nota eliminada mayor";
            // 
            // lblNotamenor
            // 
            lblNotamenor.AutoSize = true;
            lblNotamenor.Location = new Point(49, 184);
            lblNotamenor.Name = "lblNotamenor";
            lblNotamenor.Size = new Size(159, 20);
            lblNotamenor.TabIndex = 0;
            lblNotamenor.Text = "Nota eliminada menor";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(209, 60);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(124, 27);
            txtNotas.TabIndex = 1;
            txtNotas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnotamayor
            // 
            txtnotamayor.Location = new Point(209, 119);
            txtnotamayor.Name = "txtnotamayor";
            txtnotamayor.Size = new Size(124, 27);
            txtnotamayor.TabIndex = 2;
            txtnotamayor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnotamenor
            // 
            txtnotamenor.Location = new Point(209, 181);
            txtnotamenor.Name = "txtnotamenor";
            txtnotamenor.Size = new Size(124, 27);
            txtnotamenor.TabIndex = 3;
            txtnotamenor.TextAlign = HorizontalAlignment.Right;
            // 
            // lblpromedioA
            // 
            lblpromedioA.AutoSize = true;
            lblpromedioA.Location = new Point(30, 242);
            lblpromedioA.Name = "lblpromedioA";
            lblpromedioA.Size = new Size(161, 20);
            lblpromedioA.TabIndex = 2;
            lblpromedioA.Text = "Promedio aprobatorio:";
            // 
            // txtpromedioA
            // 
            txtpromedioA.Location = new Point(209, 242);
            txtpromedioA.Name = "txtpromedioA";
            txtpromedioA.Size = new Size(124, 27);
            txtpromedioA.TabIndex = 4;
            txtpromedioA.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 367);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 26);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblpromedio
            // 
            lblpromedio.AutoSize = true;
            lblpromedio.Location = new Point(114, 302);
            lblpromedio.Name = "lblpromedio";
            lblpromedio.Size = new Size(77, 20);
            lblpromedio.TabIndex = 2;
            lblpromedio.Text = "Promedio:";
            // 
            // txtpromedio
            // 
            txtpromedio.Location = new Point(209, 299);
            txtpromedio.Name = "txtpromedio";
            txtpromedio.Size = new Size(124, 27);
            txtpromedio.TabIndex = 4;
            txtpromedio.TextAlign = HorizontalAlignment.Right;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 445);
            Controls.Add(btnCalcular);
            Controls.Add(lblpromedio);
            Controls.Add(lblpromedioA);
            Controls.Add(txtpromedio);
            Controls.Add(txtpromedioA);
            Controls.Add(txtnotamenor);
            Controls.Add(txtnotamayor);
            Controls.Add(txtNotas);
            Controls.Add(lblNotamenor);
            Controls.Add(lblNotamayor);
            Controls.Add(lblNotas);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNotas;
        private Label lblNotamayor;
        private Label lblNotamenor;
        private TextBox txtNotas;
        private TextBox txtnotamayor;
        private TextBox txtnotamenor;
        private Label lblpromedioA;
        private TextBox txtpromedioA;
        private Button btnCalcular;
        private Label lblpromedio;
        private TextBox txtpromedio;
    }
}
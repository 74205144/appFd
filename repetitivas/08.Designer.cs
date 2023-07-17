namespace appFd.repetitivas
{
    partial class _08
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
            lblnumero = new Label();
            lblpotencia = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(29, 43);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(66, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero:";
            // 
            // lblpotencia
            // 
            lblpotencia.AutoSize = true;
            lblpotencia.Location = new Point(29, 98);
            lblpotencia.Name = "lblpotencia";
            lblpotencia.Size = new Size(68, 20);
            lblpotencia.TabIndex = 0;
            lblpotencia.Text = "Potencia:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 95);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(108, 27);
            textBox2.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveBorder;
            btnCalcular.Location = new Point(74, 147);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 198);
            Controls.Add(btnCalcular);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblpotencia);
            Controls.Add(lblnumero);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private Label lblpotencia;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCalcular;
    }
}
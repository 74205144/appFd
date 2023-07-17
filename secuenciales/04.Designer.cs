namespace appFd.secuenciales
{
    partial class _04
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
            lblPies = new Label();
            lblPulgadas = new Label();
            txtpies = new TextBox();
            txtpulgadas = new TextBox();
            lblestaturametros = new Label();
            txtestaturametros = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(107, 43);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(38, 20);
            lblPies.TabIndex = 0;
            lblPies.Text = "Pies:";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(77, 97);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(72, 20);
            lblPulgadas.TabIndex = 0;
            lblPulgadas.Text = "Pulgadas:";
            // 
            // txtpies
            // 
            txtpies.Location = new Point(167, 40);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(123, 27);
            txtpies.TabIndex = 1;
            // 
            // txtpulgadas
            // 
            txtpulgadas.Location = new Point(167, 94);
            txtpulgadas.Name = "txtpulgadas";
            txtpulgadas.Size = new Size(123, 27);
            txtpulgadas.TabIndex = 2;
            // 
            // lblestaturametros
            // 
            lblestaturametros.AutoSize = true;
            lblestaturametros.Location = new Point(34, 163);
            lblestaturametros.Name = "lblestaturametros";
            lblestaturametros.Size = new Size(115, 20);
            lblestaturametros.TabIndex = 0;
            lblestaturametros.Text = "Estatura Metros:";
            // 
            // txtestaturametros
            // 
            txtestaturametros.Location = new Point(167, 160);
            txtestaturametros.Name = "txtestaturametros";
            txtestaturametros.ReadOnly = true;
            txtestaturametros.Size = new Size(123, 27);
            txtestaturametros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveBorder;
            btnCalcular.Location = new Point(107, 219);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 31);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 274);
            Controls.Add(btnCalcular);
            Controls.Add(lblestaturametros);
            Controls.Add(txtestaturametros);
            Controls.Add(txtpulgadas);
            Controls.Add(txtpies);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPies;
        private Label lblPulgadas;
        private TextBox txtpies;
        private TextBox txtpulgadas;
        private Label lblestaturametros;
        private TextBox txtestaturametros;
        private Button btnCalcular;
    }
}
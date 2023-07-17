namespace appFd.secuenciales
{
    partial class _02
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
            lblMetros = new Label();
            lblCentimetros = new Label();
            lblPulgadas = new Label();
            lblPies = new Label();
            txtMetros = new TextBox();
            txtCentimetros = new TextBox();
            txtPulgadas = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtYardas = new TextBox();
            lblYardas = new Label();
            txtPies = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(76, 63);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(58, 20);
            lblMetros.TabIndex = 0;
            lblMetros.Text = "Metros:";
            // 
            // lblCentimetros
            // 
            lblCentimetros.AutoSize = true;
            lblCentimetros.Location = new Point(76, 108);
            lblCentimetros.Name = "lblCentimetros";
            lblCentimetros.Size = new Size(92, 20);
            lblCentimetros.TabIndex = 0;
            lblCentimetros.Text = "Centimetros:";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(76, 153);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(72, 20);
            lblPulgadas.TabIndex = 0;
            lblPulgadas.Text = "Pulgadas:";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(76, 198);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(38, 20);
            lblPies.TabIndex = 0;
            lblPies.Text = "Pies:";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(176, 63);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(92, 27);
            txtMetros.TabIndex = 1;
            txtMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(176, 108);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(92, 27);
            txtCentimetros.TabIndex = 2;
            txtCentimetros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(176, 153);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(92, 27);
            txtPulgadas.TabIndex = 3;
            txtPulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(173, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(92, 27);
            textBox5.TabIndex = 1;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(176, 239);
            txtYardas.Name = "txtYardas";
            txtYardas.Size = new Size(92, 27);
            txtYardas.TabIndex = 5;
            txtYardas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(76, 243);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(55, 20);
            lblYardas.TabIndex = 0;
            lblYardas.Text = "Yardas:";
            // 
            // txtPies
            // 
            txtPies.Location = new Point(176, 198);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(92, 27);
            txtPies.TabIndex = 4;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(122, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(97, 31);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 401);
            Controls.Add(btnCalcular);
            Controls.Add(txtYardas);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtPies);
            Controls.Add(txtPulgadas);
            Controls.Add(txtCentimetros);
            Controls.Add(txtMetros);
            Controls.Add(lblYardas);
            Controls.Add(lblPies);
            Controls.Add(lblPulgadas);
            Controls.Add(lblCentimetros);
            Controls.Add(lblMetros);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetros;
        private Label lblCentimetros;
        private Label lblPulgadas;
        private Label lblPies;
        private TextBox txtMetros;
        private TextBox txtCentimetros;
        private TextBox txtPulgadas;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtYardas;
        private Label lblYardas;
        private TextBox txtPies;
        private Button btnCalcular;
    }
}
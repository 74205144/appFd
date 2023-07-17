namespace appFd.secuenciales
{
    partial class _09
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
            lblNumero = new Label();
            lblSuma = new Label();
            txtNumero = new TextBox();
            txtSuma = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(70, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(70, 122);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(49, 20);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "Suma:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(142, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(111, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(142, 119);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(111, 27);
            txtSuma.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 199);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 35);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 270);
            Controls.Add(btnCalcular);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblSuma;
        private TextBox txtNumero;
        private TextBox txtSuma;
        private Button btnCalcular;
    }
}
namespace appFd.condicionales
{
    partial class _12
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
            lblDia = new Label();
            txtNumero = new TextBox();
            txtDia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(26, 41);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(26, 98);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(32, 20);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(104, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(111, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(104, 95);
            txtDia.Name = "txtDia";
            txtDia.ReadOnly = true;
            txtDia.Size = new Size(111, 27);
            txtDia.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(66, 168);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 27);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 223);
            Controls.Add(btnCalcular);
            Controls.Add(txtDia);
            Controls.Add(txtNumero);
            Controls.Add(lblDia);
            Controls.Add(lblNumero);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblDia;
        private TextBox txtNumero;
        private TextBox txtDia;
        private Button btnCalcular;
    }
}
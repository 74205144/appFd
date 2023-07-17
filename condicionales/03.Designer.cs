namespace appFd.condicionales
{
    partial class _03
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
            lblRpta = new Label();
            txtNumero = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(36, 38);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(36, 108);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(43, 20);
            lblRpta.TabIndex = 0;
            lblRpta.Text = "Rpta:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(118, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(134, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(118, 105);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(134, 27);
            txtRpta.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(87, 191);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 28);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 262);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Controls.Add(lblRpta);
            Controls.Add(lblNumero);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblRpta;
        private TextBox txtNumero;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}
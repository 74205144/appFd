namespace appFd.repetitivas
{
    partial class _07
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
            lblFactorial = new Label();
            txtnumero = new TextBox();
            txtfactorial = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(39, 41);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(39, 97);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(68, 20);
            lblFactorial.TabIndex = 0;
            lblFactorial.Text = "Factorial:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(113, 36);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(91, 27);
            txtnumero.TabIndex = 1;
            // 
            // txtfactorial
            // 
            txtfactorial.Location = new Point(113, 94);
            txtfactorial.Name = "txtfactorial";
            txtfactorial.ReadOnly = true;
            txtfactorial.Size = new Size(91, 27);
            txtfactorial.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.AppWorkspace;
            btnCalcular.Location = new Point(68, 159);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 224);
            Controls.Add(btnCalcular);
            Controls.Add(txtfactorial);
            Controls.Add(txtnumero);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblFactorial;
        private TextBox txtnumero;
        private TextBox txtfactorial;
        private Button btnCalcular;
    }
}
namespace appFd.repetitivas
{
    partial class _06
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
            txtNumero = new TextBox();
            txtRpta = new TextBox();
            lbltabla = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(41, 30);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(66, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(113, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(115, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(77, 76);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.Size = new Size(151, 196);
            txtRpta.TabIndex = 2;
            // 
            // lbltabla
            // 
            lbltabla.AutoSize = true;
            lbltabla.Location = new Point(24, 79);
            lbltabla.Name = "lbltabla";
            lbltabla.Size = new Size(47, 20);
            lbltabla.TabIndex = 0;
            lbltabla.Text = "Tabla:";
            lbltabla.Click += label2_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Location = new Point(113, 278);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 319);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Controls.Add(lbltabla);
            Controls.Add(lblnumero);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtNumero;
        private TextBox txtRpta;
        private Label lbltabla;
        private Button btnCalcular;
    }
}
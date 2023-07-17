namespace appFd.secuenciales
{
    partial class _19
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
            lblRadio = new Label();
            txtMonto = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(72, 51);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(56, 20);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(152, 48);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(122, 27);
            txtMonto.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(88, 92);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(186, 171);
            txtRpta.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(120, 288);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 356);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtMonto);
            Controls.Add(lblRadio);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private TextBox txtMonto;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}
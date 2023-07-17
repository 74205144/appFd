namespace appFd.condicionales
{
    partial class _39
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
            lblHorasausencia = new Label();
            lblMalost = new Label();
            lblBuenost = new Label();
            txtHorasausencia = new TextBox();
            txtBuenosT = new TextBox();
            txtMalosT = new TextBox();
            lblRpta = new Label();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblHorasausencia
            // 
            lblHorasausencia.AutoSize = true;
            lblHorasausencia.Location = new Point(29, 46);
            lblHorasausencia.Name = "lblHorasausencia";
            lblHorasausencia.Size = new Size(112, 20);
            lblHorasausencia.TabIndex = 0;
            lblHorasausencia.Text = "Horas ausencia:";
            // 
            // lblMalost
            // 
            lblMalost.AutoSize = true;
            lblMalost.Location = new Point(29, 110);
            lblMalost.Name = "lblMalost";
            lblMalost.Size = new Size(112, 20);
            lblMalost.TabIndex = 0;
            lblMalost.Text = "Tornillos Malos:";
            // 
            // lblBuenost
            // 
            lblBuenost.AutoSize = true;
            lblBuenost.Location = new Point(29, 178);
            lblBuenost.Name = "lblBuenost";
            lblBuenost.Size = new Size(120, 20);
            lblBuenost.TabIndex = 0;
            lblBuenost.Text = "Tornillos Buenos:";
            // 
            // txtHorasausencia
            // 
            txtHorasausencia.Location = new Point(147, 39);
            txtHorasausencia.Name = "txtHorasausencia";
            txtHorasausencia.Size = new Size(73, 27);
            txtHorasausencia.TabIndex = 1;
            // 
            // txtBuenosT
            // 
            txtBuenosT.Location = new Point(147, 175);
            txtBuenosT.Name = "txtBuenosT";
            txtBuenosT.Size = new Size(73, 27);
            txtBuenosT.TabIndex = 1;
            // 
            // txtMalosT
            // 
            txtMalosT.Location = new Point(147, 103);
            txtMalosT.Name = "txtMalosT";
            txtMalosT.Size = new Size(73, 27);
            txtMalosT.TabIndex = 1;
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(29, 249);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(43, 20);
            lblRpta.TabIndex = 3;
            lblRpta.Text = "Rpta:";
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(111, 246);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(109, 27);
            txtRpta.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(84, 312);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 25);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _39
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 373);
            Controls.Add(btnCalcular);
            Controls.Add(lblRpta);
            Controls.Add(txtMalosT);
            Controls.Add(txtRpta);
            Controls.Add(txtBuenosT);
            Controls.Add(txtHorasausencia);
            Controls.Add(lblBuenost);
            Controls.Add(lblMalost);
            Controls.Add(lblHorasausencia);
            Name = "_39";
            Text = "_39";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHorasausencia;
        private Label lblMalost;
        private Label lblBuenost;
        private TextBox txtHorasausencia;
        private TextBox txtBuenosT;
        private TextBox txtMalosT;
        private Label lblRpta;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}
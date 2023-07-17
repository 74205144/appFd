namespace appFd.secuenciales
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
            lblRadio = new Label();
            lblAltura = new Label();
            lblArealateral = new Label();
            lblAreabase = new Label();
            lblAreatotal = new Label();
            txtRadio = new TextBox();
            txtAreabase = new TextBox();
            txtAltura = new TextBox();
            txtAreatotal = new TextBox();
            txtArealateral = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(54, 44);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(51, 20);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(54, 99);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            // 
            // lblArealateral
            // 
            lblArealateral.AutoSize = true;
            lblArealateral.Location = new Point(54, 156);
            lblArealateral.Name = "lblArealateral";
            lblArealateral.Size = new Size(92, 20);
            lblArealateral.TabIndex = 0;
            lblArealateral.Text = "Area Lateral:";
            // 
            // lblAreabase
            // 
            lblAreabase.AutoSize = true;
            lblAreabase.Location = new Point(54, 210);
            lblAreabase.Name = "lblAreabase";
            lblAreabase.Size = new Size(78, 20);
            lblAreabase.TabIndex = 0;
            lblAreabase.Text = "Area Base:";
            // 
            // lblAreatotal
            // 
            lblAreatotal.AutoSize = true;
            lblAreatotal.Location = new Point(54, 265);
            lblAreatotal.Name = "lblAreatotal";
            lblAreatotal.Size = new Size(80, 20);
            lblAreatotal.TabIndex = 0;
            lblAreatotal.Text = "Area Total:";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(152, 41);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(98, 27);
            txtRadio.TabIndex = 1;
            // 
            // txtAreabase
            // 
            txtAreabase.Location = new Point(152, 207);
            txtAreabase.Name = "txtAreabase";
            txtAreabase.Size = new Size(98, 27);
            txtAreabase.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(152, 96);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(98, 27);
            txtAltura.TabIndex = 2;
            // 
            // txtAreatotal
            // 
            txtAreatotal.Location = new Point(152, 262);
            txtAreatotal.Name = "txtAreatotal";
            txtAreatotal.Size = new Size(98, 27);
            txtAreatotal.TabIndex = 5;
            // 
            // txtArealateral
            // 
            txtArealateral.Location = new Point(152, 153);
            txtArealateral.Name = "txtArealateral";
            txtArealateral.Size = new Size(98, 27);
            txtArealateral.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 323);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 27);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 372);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtAreatotal);
            Controls.Add(txtArealateral);
            Controls.Add(txtAreabase);
            Controls.Add(txtRadio);
            Controls.Add(lblAreatotal);
            Controls.Add(lblAreabase);
            Controls.Add(lblArealateral);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private Label lblArealateral;
        private Label lblAreabase;
        private Label lblAreatotal;
        private TextBox txtRadio;
        private TextBox txtAreabase;
        private TextBox txtAltura;
        private TextBox txtAreatotal;
        private TextBox txtArealateral;
        private Button btnCalcular;
    }
}
namespace appFd.condicionales
{
    partial class _27
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
            lblMontototal = new Label();
            lblSaldobruto = new Label();
            lblDescuento = new Label();
            lblSueldoneto = new Label();
            lblRegalopolo = new Label();
            txtMontototal = new TextBox();
            txtSueldobruto = new TextBox();
            txtDescuento = new TextBox();
            txtSueldoneto = new TextBox();
            txtRegalopolo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMontototal
            // 
            lblMontototal.AutoSize = true;
            lblMontototal.Location = new Point(55, 35);
            lblMontototal.Name = "lblMontototal";
            lblMontototal.Size = new Size(93, 20);
            lblMontototal.TabIndex = 0;
            lblMontototal.Text = "Monto Total:";
            // 
            // lblSaldobruto
            // 
            lblSaldobruto.AutoSize = true;
            lblSaldobruto.Location = new Point(55, 99);
            lblSaldobruto.Name = "lblSaldobruto";
            lblSaldobruto.Size = new Size(98, 20);
            lblSaldobruto.TabIndex = 0;
            lblSaldobruto.Text = "Sueldo bruto:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(55, 162);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento:";
            // 
            // lblSueldoneto
            // 
            lblSueldoneto.AutoSize = true;
            lblSueldoneto.Location = new Point(55, 221);
            lblSueldoneto.Name = "lblSueldoneto";
            lblSueldoneto.Size = new Size(95, 20);
            lblSueldoneto.TabIndex = 0;
            lblSueldoneto.Text = "Sueldo Neto:";
            // 
            // lblRegalopolo
            // 
            lblRegalopolo.AutoSize = true;
            lblRegalopolo.Location = new Point(55, 288);
            lblRegalopolo.Name = "lblRegalopolo";
            lblRegalopolo.Size = new Size(92, 20);
            lblRegalopolo.TabIndex = 0;
            lblRegalopolo.Text = "Regalo Polo:";
            // 
            // txtMontototal
            // 
            txtMontototal.Location = new Point(176, 32);
            txtMontototal.Name = "txtMontototal";
            txtMontototal.Size = new Size(127, 27);
            txtMontototal.TabIndex = 1;
            // 
            // txtSueldobruto
            // 
            txtSueldobruto.Location = new Point(176, 99);
            txtSueldobruto.Name = "txtSueldobruto";
            txtSueldobruto.Size = new Size(127, 27);
            txtSueldobruto.TabIndex = 2;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(176, 159);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(127, 27);
            txtDescuento.TabIndex = 3;
            // 
            // txtSueldoneto
            // 
            txtSueldoneto.Location = new Point(176, 218);
            txtSueldoneto.Name = "txtSueldoneto";
            txtSueldoneto.Size = new Size(127, 27);
            txtSueldoneto.TabIndex = 4;
            // 
            // txtRegalopolo
            // 
            txtRegalopolo.Location = new Point(176, 285);
            txtRegalopolo.Name = "txtRegalopolo";
            txtRegalopolo.Size = new Size(127, 27);
            txtRegalopolo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 368);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 34);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _27
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 441);
            Controls.Add(btnCalcular);
            Controls.Add(txtRegalopolo);
            Controls.Add(txtSueldoneto);
            Controls.Add(txtDescuento);
            Controls.Add(txtSueldobruto);
            Controls.Add(txtMontototal);
            Controls.Add(lblRegalopolo);
            Controls.Add(lblSueldoneto);
            Controls.Add(lblDescuento);
            Controls.Add(lblSaldobruto);
            Controls.Add(lblMontototal);
            Name = "_27";
            Text = "_27";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMontototal;
        private Label lblSaldobruto;
        private Label lblDescuento;
        private Label lblSueldoneto;
        private Label lblRegalopolo;
        private TextBox txtMontototal;
        private TextBox txtSueldobruto;
        private TextBox txtDescuento;
        private TextBox txtSueldoneto;
        private TextBox txtRegalopolo;
        private Button btnCalcular;
    }
}
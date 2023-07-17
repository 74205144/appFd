namespace appFd.condicionales
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
            lblimporte = new Label();
            lbldescuento = new Label();
            lbltotalapagar = new Label();
            lblncaramelos = new Label();
            txtimporte = new TextBox();
            txtdescuento = new TextBox();
            txttotalpagar = new TextBox();
            txtncaramelos = new TextBox();
            lblproducto = new Label();
            txtproducto = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // lblimporte
            // 
            lblimporte.AutoSize = true;
            lblimporte.Location = new Point(56, 81);
            lblimporte.Name = "lblimporte";
            lblimporte.Size = new Size(65, 20);
            lblimporte.TabIndex = 0;
            lblimporte.Text = "Importe:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(39, 127);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(82, 20);
            lbldescuento.TabIndex = 0;
            lbldescuento.Text = "Descuento:";
            // 
            // lbltotalapagar
            // 
            lbltotalapagar.AutoSize = true;
            lbltotalapagar.Location = new Point(26, 170);
            lbltotalapagar.Name = "lbltotalapagar";
            lbltotalapagar.Size = new Size(98, 20);
            lbltotalapagar.TabIndex = 0;
            lbltotalapagar.Text = "total a pagar:";
            // 
            // lblncaramelos
            // 
            lblncaramelos.AutoSize = true;
            lblncaramelos.Location = new Point(26, 219);
            lblncaramelos.Name = "lblncaramelos";
            lblncaramelos.Size = new Size(95, 20);
            lblncaramelos.TabIndex = 0;
            lblncaramelos.Text = "N caramelos:";
            // 
            // txtimporte
            // 
            txtimporte.Location = new Point(137, 79);
            txtimporte.Name = "txtimporte";
            txtimporte.ReadOnly = true;
            txtimporte.Size = new Size(96, 27);
            txtimporte.TabIndex = 1;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(137, 127);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.ReadOnly = true;
            txtdescuento.Size = new Size(96, 27);
            txtdescuento.TabIndex = 1;
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(137, 170);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.ReadOnly = true;
            txttotalpagar.Size = new Size(96, 27);
            txttotalpagar.TabIndex = 1;
            // 
            // txtncaramelos
            // 
            txtncaramelos.Location = new Point(137, 219);
            txtncaramelos.Name = "txtncaramelos";
            txtncaramelos.ReadOnly = true;
            txtncaramelos.Size = new Size(96, 27);
            txtncaramelos.TabIndex = 1;
            // 
            // lblproducto
            // 
            lblproducto.AutoSize = true;
            lblproducto.Location = new Point(49, 37);
            lblproducto.Name = "lblproducto";
            lblproducto.Size = new Size(72, 20);
            lblproducto.TabIndex = 2;
            lblproducto.Text = "Producto:";
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(137, 34);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(96, 27);
            txtproducto.TabIndex = 1;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.ActiveBorder;
            btncalcular.Location = new Point(75, 276);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(92, 27);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "C&alcular";
            btncalcular.UseVisualStyleBackColor = false;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 326);
            Controls.Add(btncalcular);
            Controls.Add(lblproducto);
            Controls.Add(txtncaramelos);
            Controls.Add(txttotalpagar);
            Controls.Add(txtdescuento);
            Controls.Add(txtproducto);
            Controls.Add(txtimporte);
            Controls.Add(lblncaramelos);
            Controls.Add(lbltotalapagar);
            Controls.Add(lbldescuento);
            Controls.Add(lblimporte);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblimporte;
        private Label lbldescuento;
        private Label lbltotalapagar;
        private Label lblncaramelos;
        private TextBox txtimporte;
        private TextBox txtdescuento;
        private TextBox txttotalpagar;
        private TextBox txtncaramelos;
        private Label lblproducto;
        private TextBox txtproducto;
        private Button btncalcular;
    }
}
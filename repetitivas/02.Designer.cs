namespace appFd.repetitivas
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
            lblMultiplicando = new Label();
            lblProducto = new Label();
            lblMultiplicador = new Label();
            txtMultiplicando = new TextBox();
            txtMultiplicador = new TextBox();
            txtProducto = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblMultiplicando
            // 
            lblMultiplicando.AutoSize = true;
            lblMultiplicando.Location = new Point(33, 39);
            lblMultiplicando.Name = "lblMultiplicando";
            lblMultiplicando.Size = new Size(104, 20);
            lblMultiplicando.TabIndex = 0;
            lblMultiplicando.Text = "Multiplicando:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(33, 149);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // lblMultiplicador
            // 
            lblMultiplicador.AutoSize = true;
            lblMultiplicador.Location = new Point(33, 96);
            lblMultiplicador.Name = "lblMultiplicador";
            lblMultiplicador.Size = new Size(101, 20);
            lblMultiplicador.TabIndex = 0;
            lblMultiplicador.Text = "Multiplicador:";
            // 
            // txtMultiplicando
            // 
            txtMultiplicando.Location = new Point(140, 36);
            txtMultiplicando.Name = "txtMultiplicando";
            txtMultiplicando.Size = new Size(129, 27);
            txtMultiplicando.TabIndex = 1;
            // 
            // txtMultiplicador
            // 
            txtMultiplicador.Location = new Point(140, 93);
            txtMultiplicador.Name = "txtMultiplicador";
            txtMultiplicador.Size = new Size(129, 27);
            txtMultiplicador.TabIndex = 1;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(140, 146);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(129, 27);
            txtProducto.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(92, 222);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 2;
            button1.Text = "C&alcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 286);
            Controls.Add(button1);
            Controls.Add(txtProducto);
            Controls.Add(txtMultiplicador);
            Controls.Add(txtMultiplicando);
            Controls.Add(lblMultiplicador);
            Controls.Add(lblProducto);
            Controls.Add(lblMultiplicando);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMultiplicando;
        private Label lblProducto;
        private Label lblMultiplicador;
        private TextBox txtMultiplicando;
        private TextBox txtMultiplicador;
        private TextBox txtProducto;
        private Button button1;
    }
}
namespace appFd.repetitivas
{
    partial class _09
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
            lblAltura = new Label();
            lblancho = new Label();
            label3 = new Label();
            txtaltura = new TextBox();
            txtancho = new TextBox();
            textBox3 = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(76, 47);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            // 
            // lblancho
            // 
            lblancho.AutoSize = true;
            lblancho.Location = new Point(76, 89);
            lblancho.Name = "lblancho";
            lblancho.Size = new Size(54, 20);
            lblancho.TabIndex = 0;
            lblancho.Text = "Ancho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 129);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 0;
            label3.Text = "Rectangulo:";
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(143, 43);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(104, 27);
            txtaltura.TabIndex = 1;
            // 
            // txtancho
            // 
            txtancho.Location = new Point(143, 86);
            txtancho.Name = "txtancho";
            txtancho.Size = new Size(104, 27);
            txtancho.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 167);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(168, 165);
            textBox3.TabIndex = 3;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.ActiveCaption;
            btncalcular.Location = new Point(94, 358);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(92, 26);
            btncalcular.TabIndex = 4;
            btncalcular.Text = "C&alcular";
            btncalcular.UseVisualStyleBackColor = false;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 403);
            Controls.Add(btncalcular);
            Controls.Add(textBox3);
            Controls.Add(txtancho);
            Controls.Add(txtaltura);
            Controls.Add(label3);
            Controls.Add(lblancho);
            Controls.Add(lblAltura);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltura;
        private Label lblancho;
        private Label label3;
        private TextBox txtaltura;
        private TextBox txtancho;
        private TextBox textBox3;
        private Button btncalcular;
    }
}
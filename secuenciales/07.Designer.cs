namespace appFd.secuenciales
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
            lblarea = new Label();
            lblbase = new Label();
            lblaltura = new Label();
            lblareatotal = new Label();
            txtarea = new TextBox();
            lblperimetro = new Label();
            textBox2 = new TextBox();
            txtbase = new TextBox();
            txtaltura = new TextBox();
            txtareatotal = new TextBox();
            txtperimetro = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.Location = new Point(62, 31);
            lblarea.Name = "lblarea";
            lblarea.Size = new Size(43, 20);
            lblarea.TabIndex = 0;
            lblarea.Text = "Area:";
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Location = new Point(62, 78);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(43, 20);
            lblbase.TabIndex = 0;
            lblbase.Text = "Base:";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(53, 129);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(52, 20);
            lblaltura.TabIndex = 0;
            lblaltura.Text = "Altura:";
            // 
            // lblareatotal
            // 
            lblareatotal.AutoSize = true;
            lblareatotal.Location = new Point(29, 178);
            lblareatotal.Name = "lblareatotal";
            lblareatotal.Size = new Size(78, 20);
            lblareatotal.TabIndex = 0;
            lblareatotal.Text = "Area total:";
            // 
            // txtarea
            // 
            txtarea.Location = new Point(111, 28);
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(103, 27);
            txtarea.TabIndex = 1;
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Location = new Point(29, 224);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(76, 20);
            lblperimetro.TabIndex = 0;
            lblperimetro.Text = "Perimetro:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(103, 27);
            textBox2.TabIndex = 1;
            // 
            // txtbase
            // 
            txtbase.Location = new Point(111, 71);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(103, 27);
            txtbase.TabIndex = 2;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(111, 126);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(103, 27);
            txtaltura.TabIndex = 3;
            // 
            // txtareatotal
            // 
            txtareatotal.Location = new Point(111, 175);
            txtareatotal.Name = "txtareatotal";
            txtareatotal.ReadOnly = true;
            txtareatotal.Size = new Size(103, 27);
            txtareatotal.TabIndex = 4;
            // 
            // txtperimetro
            // 
            txtperimetro.Location = new Point(111, 221);
            txtperimetro.Name = "txtperimetro";
            txtperimetro.ReadOnly = true;
            txtperimetro.Size = new Size(103, 27);
            txtperimetro.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Location = new Point(83, 271);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 27);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 317);
            Controls.Add(btnCalcular);
            Controls.Add(txtperimetro);
            Controls.Add(txtareatotal);
            Controls.Add(txtaltura);
            Controls.Add(txtbase);
            Controls.Add(textBox2);
            Controls.Add(txtarea);
            Controls.Add(lblperimetro);
            Controls.Add(lblareatotal);
            Controls.Add(lblaltura);
            Controls.Add(lblbase);
            Controls.Add(lblarea);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblarea;
        private Label lblbase;
        private Label lblaltura;
        private Label lblareatotal;
        private TextBox txtarea;
        private Label lblperimetro;
        private TextBox textBox2;
        private TextBox txtbase;
        private TextBox txtaltura;
        private TextBox txtareatotal;
        private TextBox txtperimetro;
        private Button btnCalcular;
    }
}
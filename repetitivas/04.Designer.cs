namespace appFd.repetitivas
{
    partial class _04
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
            lblmultiplos = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(39, 39);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(66, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero:";
            // 
            // lblmultiplos
            // 
            lblmultiplos.AutoSize = true;
            lblmultiplos.Location = new Point(31, 93);
            lblmultiplos.Name = "lblmultiplos";
            lblmultiplos.Size = new Size(74, 20);
            lblmultiplos.TabIndex = 0;
            lblmultiplos.Text = "Multiplos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 90);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(105, 27);
            textBox2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Location = new Point(83, 156);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 24);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 206);
            Controls.Add(btnCalcular);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblmultiplos);
            Controls.Add(lblnumero);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private Label lblmultiplos;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCalcular;
    }
}
namespace appFd.secuenciales
{
    partial class _10
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
            lblrpta = new Label();
            btncalcular = new Button();
            txtnumero = new TextBox();
            txtrpta = new TextBox();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(46, 65);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(66, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero:";
            // 
            // lblrpta
            // 
            lblrpta.AutoSize = true;
            lblrpta.Location = new Point(69, 115);
            lblrpta.Name = "lblrpta";
            lblrpta.Size = new Size(43, 20);
            lblrpta.TabIndex = 0;
            lblrpta.Text = "Rpta:";
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.GradientActiveCaption;
            btncalcular.Location = new Point(84, 172);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(100, 26);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "C&alcular";
            btncalcular.UseVisualStyleBackColor = false;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(121, 62);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(100, 27);
            txtnumero.TabIndex = 1;
            // 
            // txtrpta
            // 
            txtrpta.Location = new Point(121, 112);
            txtrpta.Name = "txtrpta";
            txtrpta.ReadOnly = true;
            txtrpta.Size = new Size(100, 27);
            txtrpta.TabIndex = 2;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 252);
            Controls.Add(txtrpta);
            Controls.Add(txtnumero);
            Controls.Add(btncalcular);
            Controls.Add(lblrpta);
            Controls.Add(lblnumero);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private Label lblrpta;
        private Button btncalcular;
        private TextBox txtnumero;
        private TextBox txtrpta;
    }
}
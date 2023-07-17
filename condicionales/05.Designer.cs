namespace appFd.condicionales
{
    partial class _05
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
            button1 = new Button();
            txtnumero = new TextBox();
            txtrpta = new TextBox();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(43, 48);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(66, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero:";
            // 
            // lblrpta
            // 
            lblrpta.AutoSize = true;
            lblrpta.Location = new Point(43, 95);
            lblrpta.Name = "lblrpta";
            lblrpta.Size = new Size(43, 20);
            lblrpta.TabIndex = 0;
            lblrpta.Text = "Rpta:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(75, 148);
            button1.Name = "button1";
            button1.Size = new Size(81, 29);
            button1.TabIndex = 3;
            button1.Text = "C&alcular";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(115, 45);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(67, 27);
            txtnumero.TabIndex = 1;
            // 
            // txtrpta
            // 
            txtrpta.Location = new Point(92, 92);
            txtrpta.Name = "txtrpta";
            txtrpta.ReadOnly = true;
            txtrpta.Size = new Size(90, 27);
            txtrpta.TabIndex = 2;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 205);
            Controls.Add(txtrpta);
            Controls.Add(txtnumero);
            Controls.Add(button1);
            Controls.Add(lblrpta);
            Controls.Add(lblnumero);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private Label lblrpta;
        private Button button1;
        private TextBox txtnumero;
        private TextBox txtrpta;
    }
}
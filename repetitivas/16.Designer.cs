namespace appFd.repetitivas
{
    partial class _16
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
            lblTexto = new Label();
            lblRpta = new Label();
            txtTexto = new TextBox();
            txtRpta = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(52, 41);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(48, 20);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto:";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(52, 104);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(43, 20);
            lblRpta.TabIndex = 0;
            lblRpta.Text = "Rpta:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(128, 37);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(126, 27);
            txtTexto.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(128, 101);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(126, 27);
            txtRpta.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(100, 169);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 2;
            button1.Text = "C&alcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 237);
            Controls.Add(button1);
            Controls.Add(txtRpta);
            Controls.Add(txtTexto);
            Controls.Add(lblRpta);
            Controls.Add(lblTexto);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Label lblRpta;
        private TextBox txtTexto;
        private TextBox txtRpta;
        private Button button1;
    }
}
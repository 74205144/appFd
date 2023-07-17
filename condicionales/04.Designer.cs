namespace appFd.condicionales
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
            lblnota1 = new Label();
            lblnota2 = new Label();
            lblnota3 = new Label();
            lblpromediofinal = new Label();
            btncalcular = new Button();
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            txtnota3 = new TextBox();
            txtpromediofinal = new TextBox();
            SuspendLayout();
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.Location = new Point(74, 37);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(53, 20);
            lblnota1.TabIndex = 0;
            lblnota1.Text = "Nota1:";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(74, 87);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(53, 20);
            lblnota2.TabIndex = 0;
            lblnota2.Text = "Nota2:";
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.Location = new Point(74, 138);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(53, 20);
            lblnota3.TabIndex = 0;
            lblnota3.Text = "Nota3:";
            // 
            // lblpromediofinal
            // 
            lblpromediofinal.AutoSize = true;
            lblpromediofinal.Location = new Point(15, 190);
            lblpromediofinal.Name = "lblpromediofinal";
            lblpromediofinal.Size = new Size(112, 20);
            lblpromediofinal.TabIndex = 0;
            lblpromediofinal.Text = "Promedio Final:";
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.AppWorkspace;
            btncalcular.Location = new Point(87, 234);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(99, 31);
            btncalcular.TabIndex = 5;
            btncalcular.Text = "C&alcular";
            btncalcular.UseVisualStyleBackColor = false;
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(147, 32);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(102, 27);
            txtnota1.TabIndex = 1;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(147, 84);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(102, 27);
            txtnota2.TabIndex = 2;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(147, 135);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(102, 27);
            txtnota3.TabIndex = 3;
            // 
            // txtpromediofinal
            // 
            txtpromediofinal.BackColor = SystemColors.ButtonFace;
            txtpromediofinal.Location = new Point(147, 187);
            txtpromediofinal.Name = "txtpromediofinal";
            txtpromediofinal.ReadOnly = true;
            txtpromediofinal.Size = new Size(102, 27);
            txtpromediofinal.TabIndex = 4;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 279);
            Controls.Add(txtpromediofinal);
            Controls.Add(txtnota3);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Controls.Add(btncalcular);
            Controls.Add(lblpromediofinal);
            Controls.Add(lblnota3);
            Controls.Add(lblnota2);
            Controls.Add(lblnota1);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnota1;
        private Label lblnota2;
        private Label lblnota3;
        private Label lblpromediofinal;
        private Button btncalcular;
        private TextBox txtnota1;
        private TextBox txtnota2;
        private TextBox txtnota3;
        private TextBox txtpromediofinal;
    }
}
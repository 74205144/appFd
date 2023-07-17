namespace appFd.condicionales
{
    partial class _01
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
            lblUnidades = new Label();
            txtUnidades = new TextBox();
            txtRpta = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(46, 33);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(74, 20);
            lblUnidades.TabIndex = 0;
            lblUnidades.Text = "Unidades:";
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(154, 30);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(125, 27);
            txtUnidades.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(75, 77);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(184, 145);
            txtRpta.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(97, 246);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 32);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 314);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtUnidades);
            Controls.Add(lblUnidades);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnidades;
        private TextBox txtUnidades;
        private TextBox txtRpta;
        private Button btnCalcular;
    }
}
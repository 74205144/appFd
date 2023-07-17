namespace appFd.condicionales
{
    partial class _23
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
            label1 = new Label();
            label2 = new Label();
            txtmatematica = new TextBox();
            txtfisica = new TextBox();
            btnCalcular = new Button();
            txtRpta = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 58);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Matematica:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 100);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "Fisica:";
            // 
            // txtmatematica
            // 
            txtmatematica.Location = new Point(146, 55);
            txtmatematica.Name = "txtmatematica";
            txtmatematica.Size = new Size(104, 27);
            txtmatematica.TabIndex = 1;
            // 
            // txtfisica
            // 
            txtfisica.Location = new Point(146, 97);
            txtfisica.Name = "txtfisica";
            txtfisica.Size = new Size(104, 27);
            txtfisica.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 295);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 28);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(52, 151);
            txtRpta.Multiline = true;
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(198, 118);
            txtRpta.TabIndex = 3;
            // 
            // _23
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 349);
            Controls.Add(txtRpta);
            Controls.Add(btnCalcular);
            Controls.Add(txtfisica);
            Controls.Add(txtmatematica);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "_23";
            Text = "_23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtmatematica;
        private TextBox txtfisica;
        private Button btnCalcular;
        private TextBox txtRpta;
    }
}
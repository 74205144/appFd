namespace appFd.repetitivas
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
            lblDividendo = new Label();
            lblDivisor = new Label();
            lblCociente = new Label();
            lblResiduo = new Label();
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            txtCociente = new TextBox();
            txtResiduo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDividendo
            // 
            lblDividendo.AutoSize = true;
            lblDividendo.Location = new Point(44, 43);
            lblDividendo.Name = "lblDividendo";
            lblDividendo.Size = new Size(81, 20);
            lblDividendo.TabIndex = 0;
            lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(44, 93);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(58, 20);
            lblDivisor.TabIndex = 0;
            lblDivisor.Text = "Divisor:";
            // 
            // lblCociente
            // 
            lblCociente.AutoSize = true;
            lblCociente.Location = new Point(44, 142);
            lblCociente.Name = "lblCociente";
            lblCociente.Size = new Size(70, 20);
            lblCociente.TabIndex = 0;
            lblCociente.Text = "Cociente:";
            // 
            // lblResiduo
            // 
            lblResiduo.AutoSize = true;
            lblResiduo.Location = new Point(44, 192);
            lblResiduo.Name = "lblResiduo";
            lblResiduo.Size = new Size(65, 20);
            lblResiduo.TabIndex = 0;
            lblResiduo.Text = "Residuo:";
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(146, 40);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(99, 27);
            txtDividendo.TabIndex = 1;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(146, 90);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(99, 27);
            txtDivisor.TabIndex = 1;
            // 
            // txtCociente
            // 
            txtCociente.Location = new Point(146, 139);
            txtCociente.Name = "txtCociente";
            txtCociente.ReadOnly = true;
            txtCociente.Size = new Size(99, 27);
            txtCociente.TabIndex = 1;
            // 
            // txtResiduo
            // 
            txtResiduo.Location = new Point(146, 189);
            txtResiduo.Name = "txtResiduo";
            txtResiduo.ReadOnly = true;
            txtResiduo.Size = new Size(99, 27);
            txtResiduo.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(104, 255);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 32);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 318);
            Controls.Add(btnCalcular);
            Controls.Add(txtResiduo);
            Controls.Add(txtCociente);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            Controls.Add(lblResiduo);
            Controls.Add(lblCociente);
            Controls.Add(lblDivisor);
            Controls.Add(lblDividendo);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDividendo;
        private Label lblDivisor;
        private Label lblCociente;
        private Label lblResiduo;
        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private TextBox txtCociente;
        private TextBox txtResiduo;
        private Button btnCalcular;
    }
}
namespace appFd.secuenciales
{
    partial class _03
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
            lblkm = new Label();
            lblpies = new Label();
            lblmillas = new Label();
            txtKm = new TextBox();
            txtpies = new TextBox();
            txtmillas = new TextBox();
            lblyardas = new Label();
            txtyardas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblkm
            // 
            lblkm.AutoSize = true;
            lblkm.Location = new Point(30, 53);
            lblkm.Name = "lblkm";
            lblkm.Size = new Size(84, 20);
            lblkm.TabIndex = 0;
            lblkm.Text = "Kilometros:";
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Location = new Point(76, 110);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(38, 20);
            lblpies.TabIndex = 0;
            lblpies.Text = "Pies:";
            // 
            // lblmillas
            // 
            lblmillas.AutoSize = true;
            lblmillas.Location = new Point(63, 167);
            lblmillas.Name = "lblmillas";
            lblmillas.Size = new Size(51, 20);
            lblmillas.TabIndex = 0;
            lblmillas.Text = "Millas:";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(132, 51);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(116, 27);
            txtKm.TabIndex = 1;
            // 
            // txtpies
            // 
            txtpies.Location = new Point(132, 107);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(116, 27);
            txtpies.TabIndex = 2;
            // 
            // txtmillas
            // 
            txtmillas.Location = new Point(132, 164);
            txtmillas.Name = "txtmillas";
            txtmillas.Size = new Size(116, 27);
            txtmillas.TabIndex = 3;
            // 
            // lblyardas
            // 
            lblyardas.AutoSize = true;
            lblyardas.Location = new Point(63, 224);
            lblyardas.Name = "lblyardas";
            lblyardas.Size = new Size(55, 20);
            lblyardas.TabIndex = 0;
            lblyardas.Text = "Yardas:";
            // 
            // txtyardas
            // 
            txtyardas.Location = new Point(132, 221);
            txtyardas.Name = "txtyardas";
            txtyardas.ReadOnly = true;
            txtyardas.Size = new Size(116, 27);
            txtyardas.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(113, 279);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 35);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 350);
            Controls.Add(btnCalcular);
            Controls.Add(txtyardas);
            Controls.Add(txtmillas);
            Controls.Add(txtpies);
            Controls.Add(txtKm);
            Controls.Add(lblyardas);
            Controls.Add(lblmillas);
            Controls.Add(lblpies);
            Controls.Add(lblkm);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblkm;
        private Label lblpies;
        private Label lblmillas;
        private TextBox txtKm;
        private TextBox txtpies;
        private TextBox txtmillas;
        private Label lblyardas;
        private TextBox txtyardas;
        private Button btnCalcular;
    }
}
namespace appFd.secuenciales
{
    partial class _06
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
            lblvolumen = new Label();
            txtArea = new TextBox();
            txtvolumen = new TextBox();
            lblRadio = new Label();
            lblaltura = new Label();
            txtradio = new TextBox();
            txtalturatotal = new TextBox();
            lblalturatotal = new Label();
            lblvolumentotal = new Label();
            volumentotal = new TextBox();
            txtaltura = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.Location = new Point(79, 24);
            lblarea.Name = "lblarea";
            lblarea.Size = new Size(43, 20);
            lblarea.TabIndex = 0;
            lblarea.Text = "Area:";
            // 
            // lblvolumen
            // 
            lblvolumen.AutoSize = true;
            lblvolumen.Location = new Point(52, 67);
            lblvolumen.Name = "lblvolumen";
            lblvolumen.Size = new Size(70, 20);
            lblvolumen.TabIndex = 0;
            lblvolumen.Text = "Volumen:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(132, 21);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(110, 27);
            txtArea.TabIndex = 1;
            // 
            // txtvolumen
            // 
            txtvolumen.Location = new Point(132, 67);
            txtvolumen.Name = "txtvolumen";
            txtvolumen.Size = new Size(110, 27);
            txtvolumen.TabIndex = 2;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(71, 119);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(51, 20);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio:";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Location = new Point(70, 168);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(52, 20);
            lblaltura.TabIndex = 0;
            lblaltura.Text = "Altura:";
            // 
            // txtradio
            // 
            txtradio.Location = new Point(132, 116);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(110, 27);
            txtradio.TabIndex = 3;
            // 
            // txtalturatotal
            // 
            txtalturatotal.Location = new Point(132, 215);
            txtalturatotal.Name = "txtalturatotal";
            txtalturatotal.ReadOnly = true;
            txtalturatotal.Size = new Size(110, 27);
            txtalturatotal.TabIndex = 5;
            // 
            // lblalturatotal
            // 
            lblalturatotal.AutoSize = true;
            lblalturatotal.Location = new Point(33, 218);
            lblalturatotal.Name = "lblalturatotal";
            lblalturatotal.Size = new Size(89, 20);
            lblalturatotal.TabIndex = 0;
            lblalturatotal.Text = "Altura Total:";
            lblalturatotal.Click += label5_Click;
            // 
            // lblvolumentotal
            // 
            lblvolumentotal.AutoSize = true;
            lblvolumentotal.Location = new Point(17, 269);
            lblvolumentotal.Name = "lblvolumentotal";
            lblvolumentotal.Size = new Size(105, 20);
            lblvolumentotal.TabIndex = 0;
            lblvolumentotal.Text = "Volumen total:";
            lblvolumentotal.Click += label5_Click;
            // 
            // volumentotal
            // 
            volumentotal.Location = new Point(132, 266);
            volumentotal.Name = "volumentotal";
            volumentotal.ReadOnly = true;
            volumentotal.Size = new Size(110, 27);
            volumentotal.TabIndex = 6;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(132, 165);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(110, 27);
            txtaltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGray;
            btnCalcular.Location = new Point(79, 321);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 24);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 370);
            Controls.Add(btnCalcular);
            Controls.Add(volumentotal);
            Controls.Add(txtaltura);
            Controls.Add(txtalturatotal);
            Controls.Add(txtradio);
            Controls.Add(txtvolumen);
            Controls.Add(txtArea);
            Controls.Add(lblvolumentotal);
            Controls.Add(lblalturatotal);
            Controls.Add(lblaltura);
            Controls.Add(lblRadio);
            Controls.Add(lblvolumen);
            Controls.Add(lblarea);
            Name = "_06";
            Text = "_06";
            Load += _06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblarea;
        private Label lblvolumen;
        private TextBox txtArea;
        private TextBox txtvolumen;
        private Label lblRadio;
        private Label lblaltura;
        private TextBox txtradio;
        private TextBox txtalturatotal;
        private Label lblalturatotal;
        private Label lblvolumentotal;
        private TextBox volumentotal;
        private TextBox txtaltura;
        private Button btnCalcular;
    }
}
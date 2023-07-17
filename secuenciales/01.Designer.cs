namespace appFd.secuenciales
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
            lblPVarones = new Label();
            lblPMujeres = new Label();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(53, 56);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(51, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "Varones:";
            lblPVarones.Click += lblPVarones_Click;
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(53, 97);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(52, 15);
            lblPMujeres.TabIndex = 1;
            lblPMujeres.Text = "Mujeres:";
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(108, 53);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(69, 23);
            txtVarones.TabIndex = 1;
            txtVarones.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(108, 94);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(69, 23);
            txtMujeres.TabIndex = 2;
            txtMujeres.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 56);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 1;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 94);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 2;
            label4.Text = "%";
            // 
            // button1
            // 
            button1.Location = new Point(108, 140);
            button1.Name = "button1";
            button1.Size = new Size(69, 29);
            button1.TabIndex = 3;
            button1.Text = "C&alcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 208);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(lblPMujeres);
            Controls.Add(lblPVarones);
            Name = "_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPVarones;
        private Label lblPMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
namespace appFd.repetitivas
{
    partial class _18
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
            txtTexto = new TextBox();
            txtRpta = new TextBox();
            lblTexto = new Label();
            lblRpta = new Label();
            btnTrim = new Button();
            btnTrimStar = new Button();
            btnTrimEnd = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(168, 66);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(130, 27);
            txtTexto.TabIndex = 1;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(168, 137);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(130, 27);
            txtRpta.TabIndex = 2;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(101, 69);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(48, 20);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto:";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(106, 137);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(43, 20);
            lblRpta.TabIndex = 0;
            lblRpta.Text = "Rpta:";
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(269, 200);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(105, 32);
            btnTrim.TabIndex = 5;
            btnTrim.Text = "Trim";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // btnTrimStar
            // 
            btnTrimStar.Location = new Point(44, 200);
            btnTrimStar.Name = "btnTrimStar";
            btnTrimStar.Size = new Size(105, 32);
            btnTrimStar.TabIndex = 3;
            btnTrimStar.Text = "TrimStar";
            btnTrimStar.UseVisualStyleBackColor = true;
            btnTrimStar.Click += btnTrimStar_Click;
            // 
            // btnTrimEnd
            // 
            btnTrimEnd.Location = new Point(158, 200);
            btnTrimEnd.Name = "btnTrimEnd";
            btnTrimEnd.Size = new Size(105, 32);
            btnTrimEnd.TabIndex = 4;
            btnTrimEnd.Text = "TrimEnd";
            btnTrimEnd.UseVisualStyleBackColor = true;
            btnTrimEnd.Click += btnTrimEnd_Click;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 280);
            Controls.Add(btnTrimStar);
            Controls.Add(btnTrimEnd);
            Controls.Add(btnTrim);
            Controls.Add(lblRpta);
            Controls.Add(lblTexto);
            Controls.Add(txtRpta);
            Controls.Add(txtTexto);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private TextBox txtRpta;
        private Label lblTexto;
        private Label lblRpta;
        private Button btnTrim;
        private Button btnTrimStar;
        private Button btnTrimEnd;
    }
}
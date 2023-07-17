namespace appFd.Varios
{
    partial class Login02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login02));
            panel1 = new Panel();
            pbxSalir = new PictureBox();
            pictureBox1 = new PictureBox();
            lbldni = new Label();
            lblPassword = new Label();
            txtdni = new TextBox();
            txtPassword = new TextBox();
            btnIniciar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 19, 97);
            panel1.Controls.Add(pbxSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 50);
            panel1.TabIndex = 0;
            // 
            // pbxSalir
            // 
            pbxSalir.Image = (Image)resources.GetObject("pbxSalir.Image");
            pbxSalir.Location = new Point(348, 12);
            pbxSalir.Name = "pbxSalir";
            pbxSalir.Size = new Size(34, 30);
            pbxSalir.TabIndex = 1;
            pbxSalir.TabStop = false;
            pbxSalir.Click += pbxSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image;
            pictureBox1.Location = new Point(83, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Location = new Point(83, 103);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(38, 20);
            lbldni.TabIndex = 0;
            lbldni.Text = "DNI:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(83, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(173, 100);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(112, 27);
            txtdni.TabIndex = 1;
            txtdni.Enter += txt_Enter;
            txtdni.Leave += txt_leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(112, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Enter += txt_Enter;
            txtPassword.Leave += txt_leave;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(94, 19, 97);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(64, 221);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(120, 35);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            btnIniciar.Enter += btn_enter;
            btnIniciar.Leave += btn_Leave;
            btnIniciar.MouseLeave += btn_Leave;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(94, 19, 97);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(205, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            btnCancelar.Enter += btn_enter;
            btnCancelar.Leave += btn_Leave;
            btnCancelar.MouseLeave += btn_Leave;
            // 
            // Login02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 303);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(txtPassword);
            Controls.Add(txtdni);
            Controls.Add(lblPassword);
            Controls.Add(lbldni);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login02";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbxSalir;
        private PictureBox pictureBox1;
        private Label lbldni;
        private Label lblPassword;
        private TextBox txtdni;
        private TextBox txtPassword;
        private Button btnIniciar;
        private Button btnCancelar;
    }
}
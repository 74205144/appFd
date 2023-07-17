namespace appFd.Varios
{
    partial class Login01
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
            lblPassword = new Label();
            lblID = new Label();
            txtID = new TextBox();
            txtPassword = new TextBox();
            panelx = new Panel();
            btnEnter = new Button();
            btnAtras = new Button();
            btn3 = new Button();
            btnBorrar = new Button();
            btn6 = new Button();
            btnCancelar = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            pnlNumeros = new Panel();
            panelx.SuspendLayout();
            pnlNumeros.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(42, 182);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            lblPassword.Click += label1_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 139);
            lblID.Name = "lblID";
            lblID.Size = new Size(116, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID de Operador:";
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 136);
            txtID.MaxLength = 8;
            txtID.Name = "txtID";
            txtID.Size = new Size(112, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txt_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(134, 182);
            txtPassword.MaxLength = 6;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(112, 27);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txt_TextChanged;
            // 
            // panelx
            // 
            panelx.BackColor = Color.Red;
            panelx.Controls.Add(pnlNumeros);
            panelx.Controls.Add(btnEnter);
            panelx.Controls.Add(btnAtras);
            panelx.Controls.Add(btnBorrar);
            panelx.Controls.Add(btnCancelar);
            panelx.Location = new Point(277, 12);
            panelx.Name = "panelx";
            panelx.Size = new Size(289, 303);
            panelx.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(175, 217);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(83, 40);
            btnEnter.TabIndex = 16;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(175, 158);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(83, 40);
            btnAtras.TabIndex = 15;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(104, 133);
            btn3.Name = "btn3";
            btn3.Size = new Size(40, 40);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnDigitos_click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(175, 98);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(83, 40);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(104, 73);
            btn6.Name = "btn6";
            btn6.Size = new Size(40, 40);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnDigitos_click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(175, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 40);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(104, 16);
            btn9.Name = "btn9";
            btn9.Size = new Size(40, 40);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnDigitos_click;
            // 
            // btn0
            // 
            btn0.Location = new Point(58, 192);
            btn0.Name = "btn0";
            btn0.Size = new Size(40, 40);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnDigitos_click;
            // 
            // btn2
            // 
            btn2.Location = new Point(58, 133);
            btn2.Name = "btn2";
            btn2.Size = new Size(40, 40);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnDigitos_click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 133);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 40);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnDigitos_click;
            // 
            // btn5
            // 
            btn5.Location = new Point(58, 73);
            btn5.Name = "btn5";
            btn5.Size = new Size(40, 40);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnDigitos_click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 73);
            btn4.Name = "btn4";
            btn4.Size = new Size(40, 40);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnDigitos_click;
            // 
            // btn8
            // 
            btn8.Location = new Point(58, 16);
            btn8.Name = "btn8";
            btn8.Size = new Size(40, 40);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnDigitos_click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 16);
            btn7.Name = "btn7";
            btn7.Size = new Size(40, 40);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnDigitos_click;
            // 
            // pnlNumeros
            // 
            pnlNumeros.Controls.Add(btn8);
            pnlNumeros.Controls.Add(btn7);
            pnlNumeros.Controls.Add(btn3);
            pnlNumeros.Controls.Add(btn4);
            pnlNumeros.Controls.Add(btn5);
            pnlNumeros.Controls.Add(btn6);
            pnlNumeros.Controls.Add(btn1);
            pnlNumeros.Controls.Add(btn2);
            pnlNumeros.Controls.Add(btn9);
            pnlNumeros.Controls.Add(btn0);
            pnlNumeros.Location = new Point(12, 27);
            pnlNumeros.Name = "pnlNumeros";
            pnlNumeros.Size = new Size(157, 246);
            pnlNumeros.TabIndex = 3;
            // 
            // Login01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 331);
            Controls.Add(panelx);
            Controls.Add(txtPassword);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(lblPassword);
            Name = "Login01";
            Text = "Login01";
            Load += Login01_Load;
            panelx.ResumeLayout(false);
            pnlNumeros.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtPassword;
        private Panel panelx;
        private Button btn7;
        private Button btnEnter;
        private Button btnAtras;
        private Button btn3;
        private Button btnBorrar;
        private Button btn6;
        private Button btnCancelar;
        private Button btn9;
        private Button btn0;
        private Button btn2;
        private Button btn1;
        private Button btn5;
        private Button btn4;
        private Button btn8;
        private Panel pnlNumeros;
    }
}
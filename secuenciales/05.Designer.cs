namespace appFd.secuenciales
{
    partial class _05
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
            lblmegabytes = new Label();
            lblkilobytes = new Label();
            lblbytes = new Label();
            lblgigabyte = new Label();
            txtgigabyte = new TextBox();
            txtmegabyte = new TextBox();
            txtkilobytes = new TextBox();
            txtbytes = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblmegabytes
            // 
            lblmegabytes.AutoSize = true;
            lblmegabytes.Location = new Point(51, 98);
            lblmegabytes.Name = "lblmegabytes";
            lblmegabytes.Size = new Size(85, 20);
            lblmegabytes.TabIndex = 0;
            lblmegabytes.Text = "Megabytes:";
            // 
            // lblkilobytes
            // 
            lblkilobytes.AutoSize = true;
            lblkilobytes.Location = new Point(63, 159);
            lblkilobytes.Name = "lblkilobytes";
            lblkilobytes.Size = new Size(73, 20);
            lblkilobytes.TabIndex = 0;
            lblkilobytes.Text = "Kilobytes:";
            // 
            // lblbytes
            // 
            lblbytes.AutoSize = true;
            lblbytes.Location = new Point(89, 217);
            lblbytes.Name = "lblbytes";
            lblbytes.Size = new Size(47, 20);
            lblbytes.TabIndex = 0;
            lblbytes.Text = "Bytes:";
            // 
            // lblgigabyte
            // 
            lblgigabyte.AutoSize = true;
            lblgigabyte.Location = new Point(63, 37);
            lblgigabyte.Name = "lblgigabyte";
            lblgigabyte.Size = new Size(72, 20);
            lblgigabyte.TabIndex = 0;
            lblgigabyte.Text = "Gigabyte:";
            // 
            // txtgigabyte
            // 
            txtgigabyte.Location = new Point(149, 34);
            txtgigabyte.Name = "txtgigabyte";
            txtgigabyte.Size = new Size(105, 27);
            txtgigabyte.TabIndex = 1;
            // 
            // txtmegabyte
            // 
            txtmegabyte.Location = new Point(149, 95);
            txtmegabyte.Name = "txtmegabyte";
            txtmegabyte.ReadOnly = true;
            txtmegabyte.Size = new Size(105, 27);
            txtmegabyte.TabIndex = 2;
            // 
            // txtkilobytes
            // 
            txtkilobytes.Location = new Point(149, 156);
            txtkilobytes.Name = "txtkilobytes";
            txtkilobytes.ReadOnly = true;
            txtkilobytes.Size = new Size(105, 27);
            txtkilobytes.TabIndex = 3;
            // 
            // txtbytes
            // 
            txtbytes.Location = new Point(149, 214);
            txtbytes.Name = "txtbytes";
            txtbytes.ReadOnly = true;
            txtbytes.Size = new Size(105, 27);
            txtbytes.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.AppWorkspace;
            btnCalcular.Location = new Point(105, 282);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 25);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "C&alcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 342);
            Controls.Add(btnCalcular);
            Controls.Add(txtbytes);
            Controls.Add(txtkilobytes);
            Controls.Add(txtmegabyte);
            Controls.Add(txtgigabyte);
            Controls.Add(lblgigabyte);
            Controls.Add(lblbytes);
            Controls.Add(lblkilobytes);
            Controls.Add(lblmegabytes);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmegabytes;
        private Label lblkilobytes;
        private Label lblbytes;
        private Label lblgigabyte;
        private TextBox txtgigabyte;
        private TextBox txtmegabyte;
        private TextBox txtkilobytes;
        private TextBox txtbytes;
        private Button btnCalcular;
    }
}
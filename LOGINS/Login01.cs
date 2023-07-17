namespace appFd.Varios
{
    public partial class Login01 : Form
    {
        int enter = 1;
        public Login01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDigitos_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TextBox txt = enter == 1 ? txtID : txtPassword;
            if (txt.Text.Length < txt.MaxLength)
                txt.Text += ((Button)sender).Text;


            (enter == 1 ? txtID : txtPassword).Text += btn.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            enter = 1;
            txtID.Text = txtPassword.Text = "";
            txtID.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            (enter == 1 ? txtID : txtPassword).Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TextBox txt = enter == 1 ? txtID : txtPassword;
            if ( txt.Text.Length > 0 )
            { 
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
                txt.Focus();
                txt.SelectionStart = txt.Text.Length;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            enter++;

            (enter == 1 ? txtID : txtPassword).Focus();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox) sender;
            txt.BackColor = Color.White;
            if (txt.Text.Length == txt.MaxLength)
                txt.BackColor = Color.Aquamarine;
        }

        private void Login01_Load(object sender, EventArgs e)
        {
            PanelNumeros();
        }

        private void PanelNumeros()
        {
            string sNumeros = "", sNX = "";

            foreach( Control control in pnlNumeros.Controls )
            {
                while ( sNumeros.Contains(sNX = "" + new Random().Next(0,10) ) )
                control.Text = sNX;
                sNumeros += sNX;
            }
               
        }
    }
}

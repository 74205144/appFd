namespace appFd.condicionales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);

            int precio;

            if (unidades <= 25) precio = 27;
            else if (unidades >= 26 && unidades <= 50) precio = 25;
            else precio = 23;

            txtRpta.Text = precio.ToString("0.00");
        }
    }
}

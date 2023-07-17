namespace appFd.secuenciales
{
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txtMonto.Text);

            double sueldoBruto = 500 + 0.09 * Monto;
            double descuento = 0.11 * sueldoBruto;
            double sueldoNeto = sueldoBruto - descuento;
        }
    }
}

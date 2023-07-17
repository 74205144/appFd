namespace appFd.secuenciales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(txtMetros.Text);

            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = metros / 12;
            double yardas = pies / 3;

            txtCentimetros.Text = "" + centimetros;
            txtPulgadas.Text = "" + pulgadas;
            txtPies.Text = "" + pies;
            txtYardas.Text = "" + yardas;
        }
    }
}

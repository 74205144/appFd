namespace appFd.secuenciales
{
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Radio = int.Parse(txtRadio.Text);
            int Altura = int.Parse(txtAltura.Text);

            double Areabase = Math.PI * Math.Pow(2, Radio);
            double Arealateral = 2 * Math.PI * Radio * Altura;
            double Areatotal = 2 * (Areabase + Arealateral);

            txtAreabase.Text = Areabase.ToString("0.00");
            txtArealateral.Text = Arealateral.ToString("0.00");
            txtAreatotal.Text = Areatotal.ToString("0.00");
        }
    }
}

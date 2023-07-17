namespace appFd.condicionales
{
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Matematica = int.Parse(txtmatematica.Text);
            int Fisica = int.Parse(txtfisica.Text);

            double promedio = (Matematica + Fisica) / 2.0;
            double propina = (Matematica > 17 ? 3 : 1) * Matematica + (Fisica > 15 ? 2 : 0.50);


            txtRpta.Text =
                "Promedio =" + promedio.ToString("0.00") + Environment.NewLine +
                "propina  =" + propina.ToString("0.00") + Environment.NewLine +
                "Reloj    =" + (promedio > 16 ? "SI" : "NO");
        }
    }
}

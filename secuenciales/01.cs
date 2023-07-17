namespace appFd.secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Entrada
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            //proceso
            int total = varones + mujeres;
            double pVarones = varones * 100 / total;
            double pMujeres = mujeres * 100 / total;

            //salida
            lblPVarones.Text = "" + pVarones + " %";
            lblPMujeres.Text = "" + pMujeres + " %";
        }

        private void lblPVarones_Click(object sender, EventArgs e)
        {

        }
    }
}

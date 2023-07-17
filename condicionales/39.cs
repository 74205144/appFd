namespace appFd.condicionales
{
    public partial class _39 : Form
    {
        public _39()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Horasausencia = double.Parse(txtHorasausencia.Text);
            int Malost = int.Parse(txtMalosT.Text);
            int Buenost = int.Parse(txtBuenosT.Text);

            if (Horasausencia > 1.5 && Malost > 300 && Buenost < 10000) txtRpta.Text = "5";
            else if (Horasausencia < 1.5 && Malost > 300 && Buenost < 10000) txtRpta.Text = "7";
            else if (Horasausencia > 1.5 && Malost < 300 && Buenost < 10000) txtRpta.Text = "8";
            else if (Horasausencia > 1.5 && Malost > 300 && Buenost > 10000) txtRpta.Text = "9";
            else if (Horasausencia < 1.5 && Malost < 300 && Buenost < 10000) txtRpta.Text = "12";
            else if (Horasausencia < 1.5 && Malost > 300 && Buenost > 10000) txtRpta.Text = "13";
            else if (Horasausencia > 1.5 && Malost < 300 && Buenost > 10000) txtRpta.Text = "15";
            else if (Horasausencia < 1.5 && Malost < 300 && Buenost > 10000) txtRpta.Text = "20";
        }
    }
}

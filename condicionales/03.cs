namespace appFd.condicionales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            if (Numero == 0) txtRpta.Text = "Cero";
            else if (Numero > 0 && Numero < 90) txtRpta.Text = "Obstuso";
            else if (Numero == 90) txtRpta.Text = "Recto";
            else if (Numero > 90 && Numero < 90) txtRpta.Text = "Obtuso";
            else if (Numero == 180) txtRpta.Text = "Llano";
            else if (Numero > 180 && Numero < 360) txtRpta.Text = "Concavo";
            else txtRpta.Text = "Completo";
        }
    }
}

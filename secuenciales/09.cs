namespace appFd.secuenciales
{
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            int c1 = Numero / 1000; Numero%= 1000;
            int c2 = Numero / 100; Numero%= 100;
            int c3 = Numero / 10;
            int c4 = Numero % 10;

            txtSuma.Text = "" + (c1 + c2 + c3 + c4);
        }
    }
}

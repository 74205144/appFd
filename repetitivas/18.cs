namespace appFd.repetitivas
{
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btnTrimStar_Click(object sender, EventArgs e)
        {
            string sTexto = txtTexto.Text;
            int index = -1;
            while (sTexto.ElementAt(++index) == 32 );

            txtRpta.Text = sTexto.Substring(index, sTexto.Length - index);
        }

        private void btnTrimEnd_Click(object sender, EventArgs e)
        {
            string sTexto = txtTexto.Text;
            int index = sTexto.Length;
            while (sTexto.ElementAt(--index) == 32);

            txtRpta.Text = sTexto.Substring(0, index + 1);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string sTexto =txtTexto.Text;

            int inicio = -1;
            while (sTexto.ElementAt(++inicio) ==32);

            int fin = length(sTexto); // sTexto.Length;
            while (sTexto.ElementAt(--fin) == 32);

            txtRpta.Text =sTexto.Substring(inicio, fin - inicio + 1);
        }

        int length(string sTexto)
        {
            if (sTexto.Length == 1) return 1;
            return 1 + length(sTexto.Substring(1));
        }
    }
}

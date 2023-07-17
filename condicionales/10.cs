using System.Diagnostics.CodeAnalysis;

namespace appFd.condicionales
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int [] Notas = new int[5];
            int sum = 0;
            int Notaeliminadamayor = int.Parse(txtnotamayor.Text);
            int Notaeliminadamenor = int.Parse(txtnotamenor.Text);
            
            for (int i = 0; i < 5; i++)
            {
                sum += Notas[i];
                if (Notas[i] > Notaeliminadamayor) Notaeliminadamayor = Notas[i];
                if (Notas[i] < Notaeliminadamenor) Notaeliminadamenor = Notas[i];
            }
            sum -= Notaeliminadamayor + Notaeliminadamenor;
            double avergae = sum / 3.0;
        }
    }
}

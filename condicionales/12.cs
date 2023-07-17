using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFd.condicionales
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero = int.Parse(txtNumero.Text);

            if (Numero == 1) txtDia.Text = "Lunes";
            else if (Numero == 2) txtDia.Text = "Martes";
            else if (Numero == 3) txtDia.Text = "Miercoles";
            else if (Numero == 4) txtDia.Text = "Jueves";
            else if (Numero == 5) txtDia.Text = "Viernes";
            else if (Numero == 6) txtDia.Text = "Sabado";
            else if (Numero == 7) txtDia.Text = "Domingo";
            else txtDia.Text = "error";
        }
    }
}

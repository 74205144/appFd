using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFd.condicionales
{
    public partial class _27 : Form
    {
        public _27()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Montototal = int.Parse(txtMontototal.Text);
            double Sueldobruto = 600 + (Montototal * 0.15);
            double Descuento = 0;

            if (Sueldobruto > 1800) Descuento = Sueldobruto * 0.1;
            else Descuento = Sueldobruto * 0.05;

            if (Montototal > 1000) txtRegalopolo.Text = "3 polos";
            else txtRegalopolo.Text = "1 polo";

            double Sueldoneto = Sueldobruto - Descuento;

            txtSueldobruto.Text = Sueldobruto.ToString("0.00");
            txtSueldoneto.Text = Sueldoneto.ToString("0.00");
            txtDescuento.Text = Descuento.ToString("0.00");
        }
    }
}

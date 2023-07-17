using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFd.repetitivas
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int multiplicando = int.Parse(txtMultiplicando.Text);
            int multiplicador = int.Parse(txtMultiplicador.Text);

            int producto = 0;

            for (int i = 1, mx = multiplicando; i++ < multiplicando; multiplicando += mx) ;

            txtProducto.Text = "" + producto;

        }
    }
}

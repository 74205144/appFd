using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFd.repetitivas
{
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTexto = txtTexto.Text;
            string sRpta = "";
            for (int index = sTexto.Length; --index >= 0; sRpta += sTexto.ElementAt(index))

            txtRpta.Text = reverse( sTexto);
        }

        string reverse(string sTexto)
        {
            if (sTexto.Length == 1) return sTexto;
            return sTexto.Substring( sTexto.Length - 1 ) + reverse( sTexto.Substring(0, sTexto.Length - 1 ) );
        }

    }
}

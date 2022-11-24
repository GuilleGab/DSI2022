using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PobreTITO
{
    public partial class HistorialDeReportes : Form
    {
        public HistorialDeReportes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();
        }
    }
}

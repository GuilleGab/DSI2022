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
    public partial class ReportarIncidente : Form
    {
        public ReportarIncidente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            InicioUsuario inicio = new InicioUsuario();
            inicio.Show();
            this.Hide();
        }

        private void btnReportarIncidente_Click(object sender, EventArgs e)
        {
            string tipoReporte;
            string areaReporte;
            string ubicacionReporte;
            string descripcionReporte;

            tipoReporte = cbxTipoReporte.Text;
            areaReporte = cbxArea.Text;
            ubicacionReporte = txtBoxUbicacion.Text;
            descripcionReporte = txtBoxDescripcion.Text;

            MessageBox.Show("El Reporte de Incidente ha sido registrado exitosamente", "Incidente Registrado");
            if (DialogResult.OK == MessageBox.Show("El Reporte de Incidente ha sido registrado exitosamente"))
            {
                InicioUsuario inicio = new InicioUsuario();
                inicio.Show();
                this.Hide();
            }
        }
    }
}

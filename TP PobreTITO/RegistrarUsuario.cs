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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnRegistrarUser_Click(object sender, EventArgs e)
        {
            string nombreUser;
            string contraseña1;
            string contraseña2;
            string nombre;
            string apellido;
            int dni;
            string direccion;
            int telefono;
            string email;

            nombreUser = txtBoxUserName.Text;
            contraseña1 = txtBoxContraseña1.Text;
            contraseña2 = txtBoxContraseña2.Text;
            nombre = txtBoxNombre.Text;
            apellido = txtBoxApellido.Text;
            dni = Convert.ToInt32(txtBoxDni.Text);
            direccion = txtBoxDireccion.Text;
            telefono = Convert.ToInt32(txtBoxTelefono.Text);
            email = txtBoxEmail.Text;

            if (contraseña1 == contraseña2)
            {
                MessageBox.Show("El Usuario ha sido registrado exitosamente", "Usuario Registrado");
                if (DialogResult.OK == MessageBox.Show("El Usuario ha sido registrado exitosamente"))
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    
                    this.Hide();
                }                
            }
            else
            {
                lblErrorContraseña.Enabled = true;
            }


        }
    }
}

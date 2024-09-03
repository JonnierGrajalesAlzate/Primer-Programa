using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
  14Agosto2024
  Primer Programa
*/
namespace prjRecopilacionDeDatos
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string lcNombre = txtNombre.Text;
            string lcApellidos = txtApellidos.Text;
            long lnIdentificacion = long.Parse(txtIdentificacion.Text);
            string lcCorreo = txtCorreo.Text;

            string lcEmpresa = txtEmpresa.Text;
            long lnNit = long.Parse(txtNit.Text);
            string lcTelefono = txtTelefono.Text;

            Persona lopersona1 = new Persona(lcNombre, lcApellidos, lnIdentificacion, lcCorreo, lcEmpresa, lnNit, lcTelefono);
            MessageBox.Show($"Nombre " + lopersona1.getNombre() + "\n" + "Apellidos:" +
                 lopersona1.getApellidos() + "\n Identificacion: " + lopersona1.getId() +
                "\n Correo: " + lopersona1.getCorreo() + "\n Empresa: " + lopersona1.getEmpresa() +
                "\n NIT: " + lopersona1.getId() + "\n Telefono: " + lopersona1.getTelefono());
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                e.Handled = true; 
                return;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!txtCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("El correo debe de llevar @", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true; 
                }
                if (!txtCorreo.Text.Contains("."))
                {
                    MessageBox.Show("El correo debe de llevar .", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                e.Handled = true; 
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33  && e.KeyChar <= 42) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

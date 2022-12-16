using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace TP_1
{
    public partial class form_CrearUsuario : Form
    {
        private Usuario nuevoUsuario;

        public form_CrearUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string usuario = txt_usuario.Text;
            string clave = txt_clave.Text;

            if (ValidarDatos())
            {
                if (radio_admin.Checked)
                {
                    nuevoUsuario = new Admin(nombre, apellido, usuario, clave);
                }
                if (radio_profesor.Checked)
                {
                    nuevoUsuario = new Profesor(nombre, apellido, usuario, clave);
                }
                if (radio_alumno.Checked)
                {
                    nuevoUsuario = new Alumno(nombre, apellido, usuario, clave);
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No ha ingresado los datos completos");
            }
        }

        public Usuario NuevoUsuario
        {
            get { return nuevoUsuario; }
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private bool ValidarDatos()
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string usuario = txt_apellido.Text;
            string clave = txt_clave.Text;
            bool radioChecked = false;
            bool retorno = false;

            if (radio_admin.Checked || radio_profesor.Checked || radio_alumno.Checked)
            {
                radioChecked = true;
            }

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave) && radioChecked)
            {
                retorno = true;
            }

            return retorno;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btb_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

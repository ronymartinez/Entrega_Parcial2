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
    public partial class form_listaUsuario : Form
    {
        public form_listaUsuario()
        {
            InitializeComponent();
            CargarPropiedades();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        private void CargarPropiedades()
        {
            dgv_listaUsuarios.RowHeadersVisible = false;
            dgv_listaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_listaUsuarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_listaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listaUsuarios.AllowUserToAddRows = false;

        }
        private void form_listaUsuario_Load(object sender, EventArgs e)
        {
            foreach (var item in ListaUsuarios.GetListaUsuarios)
            {
                int n = dgv_listaUsuarios.Rows.Add();

                dgv_listaUsuarios.Rows[n].Cells[0].Value = item.Legajo;
                dgv_listaUsuarios.Rows[n].Cells[1].Value = item.NombreUsuario;

                if (item is Admin)
                {
                    dgv_listaUsuarios.Rows[n].Cells[2].Value = ((Admin)item).Nombre;
                    dgv_listaUsuarios.Rows[n].Cells[3].Value = ((Admin)item).Apellido;
                    dgv_listaUsuarios.Rows[n].Cells[4].Value = "Administrador";
                }
                if (item is Profesor)
                {
                    dgv_listaUsuarios.Rows[n].Cells[2].Value = ((Profesor)item).Nombre;
                    dgv_listaUsuarios.Rows[n].Cells[3].Value = ((Profesor)item).Apellido;
                    dgv_listaUsuarios.Rows[n].Cells[4].Value = "Profesor";

                }
                if (item is Alumno)
                {
                    dgv_listaUsuarios.Rows[n].Cells[2].Value = ((Alumno)item).Nombre;
                    dgv_listaUsuarios.Rows[n].Cells[3].Value = ((Alumno)item).Apellido;
                    dgv_listaUsuarios.Rows[n].Cells[4].Value = "Alumno";
                }

                n++;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

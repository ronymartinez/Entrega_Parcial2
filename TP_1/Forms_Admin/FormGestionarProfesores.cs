using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_gestionarProfesores : Form
    {
        private Profesor profesor;
        private int legajo;
        public form_gestionarProfesores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }


        private void CargarDatos()
        {
            dgv_listadoProfes.Rows.Clear();

            foreach(Profesor profesor in ListaProfesores.GetListaProfesores)
            {
                int n = this.dgv_listadoProfes.Rows.Add();
                dgv_listadoProfes.Rows[n].Cells[0].Value = profesor.Legajo.ToString();
                dgv_listadoProfes.Rows[n].Cells[1].Value = profesor.NombreUsuario;
                dgv_listadoProfes.Rows[n].Cells[2].Value = profesor.Nombre;
                dgv_listadoProfes.Rows[n].Cells[3].Value = profesor.Apellido;

                if (profesor.MateriasAsignadas is not null && profesor.MateriasAsignadas.Count != 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Materia materia in profesor.MateriasAsignadas)
                    {
                        sb.AppendLine(materia.NombreMateria);
                    }
                    dgv_listadoProfes.Rows[n].Cells[4].Value = sb.ToString();
                }
                else
                {
                    dgv_listadoProfes.Rows[n].Cells[4].Value = "Aún no se asignaron materias";
                }
                n++;

            }

        }

        private void FormGestionarProfesores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (legajo != 0)
            {
                form_editarProfesor formEditarProfesor = new form_editarProfesor(legajo);
                DialogResult dialogResult = formEditarProfesor.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDatos();
                }
            }
            else
            {
                legajo = Convert.ToInt32(dgv_listadoProfes.Rows[0].Cells[0].Value);
                form_editarProfesor formEditarProfesor = new form_editarProfesor(legajo);
                DialogResult dialogResult = formEditarProfesor.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDatos();
                }
            }
        }

        private void dgv_listadoProfes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (dgv_listadoProfes.Rows[e.RowIndex].Cells[1].Value.ToString() is not null)
                {
                    legajo = Convert.ToInt32(dgv_listadoProfes.Rows[e.RowIndex].Cells[0].Value);
                }
            }
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

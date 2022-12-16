using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_gestionarAlumnos : Form
    {
        int legajo;
        public form_gestionarAlumnos()
        {
            InitializeComponent();
            legajo = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void CargarDataGrid()
        {
            dgv_listadoAlumnos.Rows.Clear();

            foreach (Alumno alumno in ListaCalificaciones.GetDiccionarioCalificaciones.Keys)
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    int n = this.dgv_listadoAlumnos.Rows.Add();

                    dgv_listadoAlumnos.Rows[n].Cells[0].Value = calificacion.Materia.NombreMateria;
                    dgv_listadoAlumnos.Rows[n].Cells[1].Value = alumno.Legajo.ToString();
                    dgv_listadoAlumnos.Rows[n].Cells[2].Value = alumno.Nombre;
                    dgv_listadoAlumnos.Rows[n].Cells[3].Value = alumno.Apellido;

                    if (calificacion.Examen1 != null && calificacion.Examen2 != null)
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = calificacion.Promedio.ToString();
                    }
                    else
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = "Falta rendir";
                    }

                    if (calificacion.CantPresente != 0)
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = calificacion.CantPresente.ToString();
                    }
                    else
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = "Próxima a cursar";
                    }

                    dgv_listadoAlumnos.Rows[n].Cells[6].Value = calificacion.Regularidad.ToString();
                    dgv_listadoAlumnos.Rows[n].Cells[7].Value = calificacion.Aprobacion.ToString();

                    n++;
                }
            }
        }
        private void form_gestionarAlumnos_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
        private void dgv_listadoAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value.ToString() is not null)
                {
                    legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value);
                }
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (legajo != 0)
            {
                //legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value);
                form_ModificarAlumnos formModificarAlumnos = new form_ModificarAlumnos(legajo);
                DialogResult dialogResult = formModificarAlumnos.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDataGrid();
                }
                
            }
            else
            {
                legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[0].Cells[1].Value);
                form_ModificarAlumnos formModificarAlumnos = new form_ModificarAlumnos(legajo);
                DialogResult dialogResult = formModificarAlumnos.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDataGrid();
                }
                //MessageBox.Show("Debe hacer click en la fila que desea modificar");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

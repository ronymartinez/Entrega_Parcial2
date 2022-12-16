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
    public partial class form_calificarAlumnos : Form
    {
        private Profesor profe;
        private int legajo;
        private string nombreMateria;

        public form_calificarAlumnos()
        {
            InitializeComponent();
            CargarPropiedades();
            CargarDataGrid();

        }
        public form_calificarAlumnos(Profesor profe) : this()
        {
            this.profe = profe;
        }
        private void CargarPropiedades()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dgv_listadoAlumnos.RowHeadersVisible = false;
            dgv_listadoAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listadoAlumnos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_listadoAlumnos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_listadoAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listadoAlumnos.AllowUserToAddRows = false;
            dgv_listadoAlumnos.ReadOnly = true;
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
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = calificacion.Examen1.Nota.ToString();
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = calificacion.Examen2.Nota.ToString();
                        dgv_listadoAlumnos.Rows[n].Cells[6].Value = calificacion.Promedio.ToString();
                    }
                    if (calificacion.Examen1 != null && calificacion.Examen2 == null)
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = calificacion.Examen1.Nota.ToString();
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = "Sin rendir";
                        dgv_listadoAlumnos.Rows[n].Cells[6].Value = "Falta rendir parcial";
                    }
                    if (calificacion.Examen1 == null && calificacion.Examen2 != null)
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = "Sin rendir";
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = calificacion.Examen2.Nota.ToString();
                        dgv_listadoAlumnos.Rows[n].Cells[6].Value = "Falta rendir parcial";
                    }
                    if (calificacion.Examen1 == null && calificacion.Examen2 == null)
                    {
                        dgv_listadoAlumnos.Rows[n].Cells[4].Value = "Sin rendir";
                        dgv_listadoAlumnos.Rows[n].Cells[5].Value = "Sin rendir";
                        dgv_listadoAlumnos.Rows[n].Cells[6].Value = "Falta rendir parcial";
                    }

                    dgv_listadoAlumnos.Rows[n].Cells[7].Value = calificacion.CantPresente.ToString();
                    dgv_listadoAlumnos.Rows[n].Cells[8].Value = calificacion.Aprobacion.ToString();
                }
            }
        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (legajo != 0 && nombreMateria is not null)
            {
                //legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value);
                form_EditarCalificaciones formEditarCalificaciones = new form_EditarCalificaciones(legajo, nombreMateria);
                DialogResult dialogResult = formEditarCalificaciones.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDataGrid();
                }
            }
            else
            {
                legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[0].Cells[1].Value);
                nombreMateria = dgv_listadoAlumnos.Rows[0].Cells[0].Value.ToString();

                form_EditarCalificaciones formEditarCalificaciones = new form_EditarCalificaciones(legajo, nombreMateria);
                DialogResult dialogResult = formEditarCalificaciones.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El cambio se ha realizado correctamente");
                    CargarDataGrid();
                }

            }
        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_listadoAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value is not null &&        dgv_listadoAlumnos.Rows[e.RowIndex].Cells[0].Value is not null)
                {
                    legajo = Convert.ToInt32(dgv_listadoAlumnos.Rows[e.RowIndex].Cells[1].Value);
                    nombreMateria = dgv_listadoAlumnos.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            
        }
    }
}

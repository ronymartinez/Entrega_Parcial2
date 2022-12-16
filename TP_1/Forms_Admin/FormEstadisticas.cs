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
    public partial class form_estadisticas : Form
    {
        public form_estadisticas()
        {
            InitializeComponent();
            CargarPropiedades();
            CargarDataGrid();
            CargarDataGrid2();
            CargarDataGrid3();
        }

        private void CargarPropiedades()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dgv_estadisticas.RowHeadersVisible = false;
            dgv_estadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_estadisticas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_estadisticas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_estadisticas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_estadisticas.AllowUserToAddRows = false;


            dgv_estadisticas2.RowHeadersVisible = false;
            dgv_estadisticas2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_estadisticas2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_estadisticas2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_estadisticas2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_estadisticas2.AllowUserToAddRows = false;

            dgv_estadisticas3.RowHeadersVisible = false;
            dgv_estadisticas3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_estadisticas3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_estadisticas3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_estadisticas3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_estadisticas3.AllowUserToAddRows = false;

        }
        private void CargarDataGrid()
        {

            foreach (Materia materia in ListaMaterias.GetListaMateriaTotales)
            {
                int n = dgv_estadisticas.Rows.Add();
                dgv_estadisticas.Rows[n].Cells[0].Value = materia.NombreMateria;
                dgv_estadisticas.Rows[n].Cells[1].Value = ObtenerCantidadInscriptosPorMateria(materia).ToString();
                dgv_estadisticas.Rows[n].Cells[2].Value = ObtenerPromedioDeNotasPorMateria(materia).ToString("N2");

            }

            int o = dgv_estadisticas.Rows.Add();
            dgv_estadisticas.Rows[o].Cells[0].Value = "";
            dgv_estadisticas.Rows[o].Cells[1].Value = "";
            dgv_estadisticas.Rows[o].Cells[2].Value = "";


            int p = dgv_estadisticas.Rows.Add();
            dgv_estadisticas.Rows[p].Cells[0].Value = "PROMEDIO TOTAL";
            dgv_estadisticas.Rows[p].Cells[1].Value = ObtenerPromedioTotalInscriptos(ListaMaterias.GetListaMateriaTotales).ToString("N2");
            dgv_estadisticas.Rows[p].Cells[2].Value = ObtenerPromedioDeNotasTotales(ListaMaterias.GetListaMateriaTotales).ToString("N2");

        }

        private void CargarDataGrid2()
        {
            foreach (Profesor profesor in ListaProfesores.GetListaProfesores)
            {
                int n = dgv_estadisticas2.Rows.Add();
                dgv_estadisticas2.Rows[n].Cells[0].Value = profesor.Nombre + " " + profesor.Apellido;

                if (ObtenerCantidadDeAlumnosPorProfesor(profesor) == 0)
                {
                    dgv_estadisticas2.Rows[n].Cells[1].Value = "Aún no tiene alumnos asignados";
                }
                else
                {
                    dgv_estadisticas2.Rows[n].Cells[1].Value = ObtenerCantidadDeAlumnosPorProfesor(profesor);
                }


            }
        }

        private void CargarDataGrid3()
        {
            foreach (Usuario usuario in ListaUsuarios.GetListaUsuarios)
            {
                if (usuario is Alumno)
                {
                    int n = dgv_estadisticas3.Rows.Add();
                    dgv_estadisticas3.Rows[n].Cells[0].Value = ((Alumno)usuario).Nombre + " " + ((Alumno)usuario).Apellido;
                    if(ObtenerPromedioDeNotasPorAlumno(((Alumno)usuario)) != 0)
                    {
                        dgv_estadisticas3.Rows[n].Cells[1].Value = ObtenerPromedioDeNotasPorAlumno(((Alumno)usuario)).ToString("N2");
                    }
                    else
                    {
                        dgv_estadisticas3.Rows[n].Cells[1].Value = "Aún no rindió parciales";
                    }
                   
                }
            }

        }
        private int ObtenerCantidadInscriptosPorMateria(Materia materia)
        {
            if (materia is not null && materia.ListaAlumnosAsignados is not null)
            {
                return materia.ListaAlumnosAsignados.Count;
            }

            return 0;
        }

        private int ObtenerCantidadDeAlumnosPorProfesor(Profesor profesor)
        {
            int acumulador = 0;

            if (profesor is not null && profesor.MateriasAsignadas is not null)
            {
                foreach (Materia materia in profesor.MateriasAsignadas)
                {
                    if (materia.ListaAlumnosAsignados is not null)
                    {
                        acumulador += materia.ListaAlumnosAsignados.Count;
                    }
                }
            }

            return acumulador;
        }
        private float ObtenerPromedioTotalInscriptos(List<Materia> listaDeMaterias)
        {
            int acumulador = 0;
            int contador = 0;

            if (listaDeMaterias is not null)
            {
                foreach (Materia materia in listaDeMaterias)
                {
                    if (materia.ListaAlumnosAsignados is not null)
                    {
                        acumulador += materia.ListaAlumnosAsignados.Count;
                    }
                    contador++;
                }
            }
            if (contador != 0)
            {
                return acumulador / (float)contador;
            }
            return 0;
        }

        private float ObtenerPromedioDeNotasPorMateria(Materia materia)
        {
            float acumulador = 0;
            int contador = 0;

            if (materia is not null && materia.ListaAlumnosAsignados is not null)
            {
                foreach (Alumno alumno in materia.ListaAlumnosAsignados)
                {
                    foreach (Calificacion calificacion in alumno.Calificaciones)
                    {
                        if (calificacion.Aprobacion != eAprobacion.Pendiente)
                        {
                            acumulador += calificacion.Promedio;
                            contador++;
                        }
                    }
                }
            }
            if (contador != 0)
            {
                return acumulador / (float)contador;
            }
            return 0;
        }

        private float ObtenerPromedioDeNotasTotales(List<Materia> listaDeMaterias)
        {
            float acumulador = 0;
            int contador = 0;
            if (listaDeMaterias is not null)
            {
                foreach (Materia materia in listaDeMaterias)
                {
                    acumulador += ObtenerPromedioDeNotasPorMateria(materia);
                    contador++;
                }

            }
            if (contador != 0)
            {
                return acumulador / (float)contador;
            }
            return 0;
        }

        private float ObtenerPromedioDeNotasPorAlumno(Alumno alumno)
        {
            float acumulador = 0;
            int contador = 0;

            foreach (Calificacion calificacion in alumno.Calificaciones)
            {
                if (calificacion.Examen1 is not null && calificacion.Examen2 is not null)
                {
                    acumulador += calificacion.Promedio;
                    contador++;
                }
            }

            if(contador!= 0)
            {
                return acumulador / contador;
            }
            return acumulador;
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

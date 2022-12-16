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
    public partial class form_inscribirAMaterias : Form
    {
        List<Alumno> listaAlumno;
        Alumno alumnoElegido;
        string materiaElegida;

        public form_inscribirAMaterias()
        {
            InitializeComponent();
            listaAlumno = new List<Alumno>();
            CargarComboBox();
            CargarPropiedades();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void form_inscribirAMaterias_Load(object sender, EventArgs e)
        {            
            CargarPropiedades();
        }

        private void CargarPropiedades()
        {
            dgv_materiasInscriptas.RowHeadersVisible = false;
            dgv_materiasInscriptas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_materiasInscriptas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_materiasInscriptas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_materiasInscriptas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_materiasInscriptas.AllowUserToAddRows = false;
            
            dgv_listaMateriasTotales.RowHeadersVisible = false;
            dgv_listaMateriasTotales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaMateriasTotales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_listaMateriasTotales.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_listaMateriasTotales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listaMateriasTotales.AllowUserToAddRows = false;

        }
        private void CargarComboBox()
        {
            //ComboBox
            cmb_listaAlumnos.Items.Clear();
            
            foreach (Usuario usuario in ListaUsuarios.GetListaUsuarios)
            {
                if (usuario is Alumno)
                {
                    cmb_listaAlumnos.Items.Add("-Legajo: "+((Alumno)usuario).Legajo + " - " + ((Alumno)usuario).Nombre + " " + ((Alumno)usuario).Apellido);

                    listaAlumno.Add((Alumno)usuario);
                }
            }
        }
        private void CargarDataGrid(Alumno alumno)
        {
            //CARGAR MATERIAS INSCRIPTAS
            dgv_materiasInscriptas.Rows.Clear();
            if (alumno.Calificaciones.Count != 0 && alumno.Calificaciones is not null)
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    int n = this.dgv_materiasInscriptas.Rows.Add();
                    dgv_materiasInscriptas.Rows[n].Cells[0].Value = calificacion.Materia.NombreMateria;
                    dgv_materiasInscriptas.Rows[n].Cells[1].Value = "2002";
                    dgv_materiasInscriptas.Rows[n].Cells[2].Value = calificacion.Promedio.ToString();
                    dgv_materiasInscriptas.Rows[n].Cells[3].Value = calificacion.Aprobacion.ToString();

                    n++;
                }
            }
            else
            {
                lbl_titulo.Text = "Aún no se ha inscripto a materias";
            }

            // CARGAR MATERIAS
            dgv_listaMateriasTotales.Rows.Clear();
            if (ListaMaterias.GetListaMateriaTotales.Count != 0)
            {
                foreach (Materia materia in ListaMaterias.GetListaMateriaTotales)
                {
                    int m = this.dgv_listaMateriasTotales.Rows.Add();
                    dgv_listaMateriasTotales.Rows[m].Cells[0].Value = materia.NombreMateria;
                    dgv_listaMateriasTotales.Rows[m].Cells[1].Value = materia.MostrarCorrelativas();

                    m++;
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cmb_listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmb_listaAlumnos.SelectedIndex;
            alumnoElegido = listaAlumno[indice];
            CargarDataGrid(listaAlumno[indice]);

        }

        private void btn_inscribir_Click(object sender, EventArgs e)
        {
            Materia materiaAux = new Materia();

            bool verificarInscripcion = true;
            bool verificarCorrelativa = false;
            bool sinCorrelativas = false;

            if (materiaElegida is null)
            {
                materiaElegida = dgv_listaMateriasTotales.Rows[0].Cells[0].Value.ToString();
            }

            if (materiaElegida is not null)
            {
                foreach (Materia materia in ListaMaterias.GetListaMateriaTotales)
                {
                    if (materia.NombreMateria == materiaElegida)
                    {
                        materiaAux = materia;
                        break;
                    }
                }

                foreach (Calificacion calificacion in alumnoElegido.Calificaciones)
                {
                    if (calificacion.Materia.NombreMateria == materiaElegida)
                    {
                        MessageBox.Show("Ya se encuentra inscripto en esa materia");
                        verificarInscripcion = false;
                        break;
                    }
                }

                if (materiaAux.ListaCorrelativas is not null && materiaAux.ListaCorrelativas.Count > 0)
                {
                    foreach (Materia materia in materiaAux.ListaCorrelativas)
                    {
                        foreach (Calificacion calificacion in alumnoElegido.Calificaciones)
                        {
                            if (calificacion.Aprobacion == eAprobacion.Aprobado && calificacion.Materia.NombreMateria == materiaAux.NombreMateria)
                            {
                                verificarCorrelativa = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    sinCorrelativas = true;
                }

                if (verificarInscripcion && (verificarCorrelativa || sinCorrelativas))
                {
                    Calificacion calificacion = new Calificacion(materiaAux);
                    alumnoElegido.AgregarCalificacion(calificacion);
                    MessageBox.Show("Se ha realizado la inscripción");
                    CargarDataGrid(alumnoElegido);
                }
                else if (verificarInscripcion && !verificarCorrelativa)
                {
                    MessageBox.Show("No se puede inscribir. Verifique correlatividad.");
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una Materia.");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listaMateriasTotales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                materiaElegida = dgv_listaMateriasTotales.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                materiaElegida = dgv_listaMateriasTotales.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}

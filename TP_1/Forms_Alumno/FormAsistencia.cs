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
    public partial class form_asistencia : Form
    {
        Alumno alumno;
        string materiaElegida;
        int indice;
        List<int> indicesBloqueados;
        public form_asistencia(Alumno alumno)
        {
            this.alumno = alumno;
            indicesBloqueados = new List<int>();            

            InitializeComponent();
            CargarPropiedades();
            CargarDataGrid();
            Text = $"Asistencia de {alumno.Nombre} {alumno.Apellido}: (Perfil Alumno)";
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {


        }
        private void CargarPropiedades()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dgv_materiasEnCurso.RowHeadersVisible = false;
            dgv_materiasEnCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_materiasEnCurso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_materiasEnCurso.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_materiasEnCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_materiasEnCurso.AllowUserToAddRows = false;
            dgv_materiasEnCurso.ReadOnly = true;
        }

        private void CargarDataGrid()
        {
            //CARGAR MATERIAS INSCRIPTAS
            dgv_materiasEnCurso.Rows.Clear();
            int contador = 0;
            if (alumno.Calificaciones.Count != 0 && alumno.Calificaciones is not null)
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    if (calificacion.Aprobacion == eAprobacion.Pendiente)
                    {
                    int n = this.dgv_materiasEnCurso.Rows.Add();

                        dgv_materiasEnCurso.Rows[n].Cells[0].Value = calificacion.Materia.NombreMateria;
                        dgv_materiasEnCurso.Rows[n].Cells[1].Value = calificacion.Aprobacion.ToString();
                        dgv_materiasEnCurso.Rows[n].Cells[2].Value = calificacion.CantPresente.ToString();
                        //n++;
                        contador++;
                    }
                }
            }
            if(contador == 0)
            {
                lbl_titulo.Text = "Actualmente no se encuentra cursando ninguna materia.";
                lbl_titulo.Text = "";
            }
            else
            {
                lbl_titulo.Text = "";
                lbl_titulo.Text = "Materias inscriptas: ";
            }

        }

        private void btn_DarPresente_Click(object sender, EventArgs e)
        {
            if (materiaElegida is null)
            {
                materiaElegida = dgv_materiasEnCurso.Rows[0].Cells[0].Value.ToString();
                indice = 0;
            }

            if (materiaElegida is not null && VerificarIndice(indice))
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    if (calificacion.Materia.NombreMateria == materiaElegida)
                    {
                        calificacion.CantPresente++;
                        indicesBloqueados.Add(indice);
                        MessageBox.Show("Se ha registrado su asistencia.");
                        CargarDataGrid();
                    }
                }
            }
            else if (materiaElegida is not null && !VerificarIndice(indice))
            {
                MessageBox.Show("No puede dar presente dos veces a la misma materia.");
            }
        }

        private void dgv_materiasEnCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                //materiaElegida = dgv_materiasEnCurso.Rows[e.RowIndex].Cells[0].Value.ToString();
                //indice = e.RowIndex;
                if (dgv_materiasEnCurso.Rows[e.RowIndex].Cells[0].Value is not null)
                {
                    materiaElegida = dgv_materiasEnCurso.Rows[e.RowIndex].Cells[0].Value.ToString();
                    indice = e.RowIndex;
                }
            }

        }

        private bool VerificarIndice(int indiceElegido)
        {
            foreach (int indiceAux in indicesBloqueados)
            {
                if (indiceElegido == indiceAux)
                {
                    return false;
                }
            }
            return true;
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

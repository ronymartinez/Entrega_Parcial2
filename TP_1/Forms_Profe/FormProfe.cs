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
    public partial class form_Profe : Form
    {
        private Profesor profe;
        public form_Profe()
        {
            InitializeComponent();
        }
        public form_Profe(Usuario usuario) : this()
        {
            lbl_bienvenida.Text = "¡Hola, \n" + ((Profesor)usuario).Nombre + " " + ((Profesor)usuario).Apellido + "!";
            profe = (Profesor)usuario;
        }

        private void form_Profe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_verMaterias_Click(object sender, EventArgs e)
        {
            if (profe.MateriasAsignadas.Count > 0)
            {
                form_materiasAsignadas formMateriasAsignadas = new form_materiasAsignadas(profe);
                formMateriasAsignadas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aún no tenés no tiene materias asignadas.");
            }

        }

        private void btn_crearExamen_Click(object sender, EventArgs e)
        {

            if (profe.MateriasAsignadas.Count > 0)
            {
                form_crearExamen formCrearExamen = new form_crearExamen(profe);
                DialogResult dg = formCrearExamen.ShowDialog();
                Examen examenAux = formCrearExamen.Examen;
                Materia materiaAux = formCrearExamen.Materia;
                if (examenAux is not null && dg == DialogResult.OK)
                {
                    ListaExamenes.AgregarExamen(examenAux, materiaAux);

                }
                else
                {
                    MessageBox.Show("No se ha podido crear el examen");
                }
            }
            else
            {
                MessageBox.Show("No puede crear examen si no tiene materias asignadas.");
            }
        }

        

        private void btn_calificarAlumnos_Click(object sender, EventArgs e)
        {
            if (profe.MateriasAsignadas.Count > 0)
            {
                form_calificarAlumnos formCalificarAlumnos = new form_calificarAlumnos(profe);

                DialogResult dg = formCalificarAlumnos.ShowDialog();
                if (dg == DialogResult.OK)
                {
                    this.ShowDialog();
                }

                //Examen examenAux = formCrearExamen.Examen;
                //Materia materiaAux = formCrearExamen.Materia;

            }

        }

        private void btn_listaExamenes_Click(object sender, EventArgs e)
        {
            if (profe.MateriasAsignadas.Count > 0)
            {
                form_ListaExamenes formListaExamenes = new form_ListaExamenes();

                DialogResult dg = formListaExamenes.ShowDialog();
                if (dg == DialogResult.OK)
                {
                    this.ShowDialog();
                }
                //Examen examenAux = formCrearExamen.Examen;
                //Materia materiaAux = formCrearExamen.Materia;

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cargarAlumnos_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Alumno", "Alumno");
            formBBDD.ShowDialog();
        }
    }
}

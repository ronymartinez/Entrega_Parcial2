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
    public partial class form_ModificarAlumnos : Form
    {
        private Alumno alumno;
        private int legajo;
        public form_ModificarAlumnos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public form_ModificarAlumnos(int legajo) : this()
        {
            this.legajo = legajo;
        }

        private void ModificarAlumnos_Load(object sender, EventArgs e)
        {
            foreach (Alumno alumno in ListaCalificaciones.GetDiccionarioCalificaciones.Keys)
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    if (alumno.Legajo == legajo)
                    {
                        txt_materia.Text = calificacion.Materia.NombreMateria;
                        txt_legajo.Text = alumno.Legajo.ToString();
                        txt_nombre.Text = alumno.Nombre;
                        txt_apellido.Text = alumno.Apellido;
                        domain_asistencia.Text = calificacion.CantPresente.ToString();

                        this.alumno = alumno;
                    }
                }
            }
        }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public int Legajo { get => legajo; set => legajo = value; }

     
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Alumno alumnoAux = alumno;
            try
            {
                alumnoAux.Nombre = txt_nombre.Text;
                alumnoAux.Apellido = txt_apellido.Text;

                foreach (Calificacion calificacion in alumnoAux.Calificaciones)
                {
                    if (calificacion.Materia.NombreMateria == txt_materia.Text)
                    {
                        calificacion.CantPresente = Convert.ToInt32(domain_asistencia.Text);

                        if (calificacion.CantPresente > 14 && calificacion.Promedio > 6)
                        {
                            calificacion.Aprobacion = eAprobacion.Aprobado;
                        }
                        if (calificacion.CantPresente < 15 && calificacion.CantPresente > 0)
                        {
                            calificacion.Aprobacion = eAprobacion.Reprobado;
                        }
                        if (calificacion.CantPresente < 0)
                        {
                            calificacion.Aprobacion = eAprobacion.Pendiente;
                        }
                    }
                }
                alumno = alumnoAux;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
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

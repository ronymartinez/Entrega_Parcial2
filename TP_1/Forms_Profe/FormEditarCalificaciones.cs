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
    public partial class form_EditarCalificaciones : Form
    {
        private Alumno alumno;
        private int legajo;
        private string nombreMateria;

        public form_EditarCalificaciones()
        {
            InitializeComponent();
        }
        public form_EditarCalificaciones(int legajo) : this()
        {
            this.legajo = legajo;
        }
        public form_EditarCalificaciones(int legajo, string nombreMateria) : this()
        {
            this.legajo = legajo;
            this.nombreMateria = nombreMateria;
        }
        private void form_EditarCalificaciones_Load(object sender, EventArgs e)
        {
            foreach (Alumno alumno in ListaCalificaciones.GetDiccionarioCalificaciones.Keys)
            {
                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    if (alumno.Legajo == legajo && calificacion.Materia.NombreMateria == nombreMateria)
                    {
                        txt_materia.Text = calificacion.Materia.NombreMateria;
                        txt_legajo.Text = alumno.Legajo.ToString();
                        txt_nombre.Text = alumno.Nombre;
                        txt_apellido.Text = alumno.Apellido;

                        if (calificacion.Examen1 is not null && calificacion.Examen1.Nota > 0)
                        {
                            domain_nota1.Text = calificacion.Examen1.Nota.ToString();
                        }
                        else
                        {
                            domain_nota1.Text = "Elija la nota";
                        }
                        if (calificacion.Examen2 is not null && calificacion.Examen2.Nota > 0)
                        {
                            domain_nota2.Text = calificacion.Examen2.Nota.ToString();
                        }
                        else
                        {
                            domain_nota2.Text = "Elija la nota";
                        }

                        domain_asistencia.Text = calificacion.CantPresente.ToString();

                        //cmb_aprobacion.SelectedItem = calificacion.Aprobacion.ToString();

                        this.alumno = alumno;
                        break;
                    }
                }
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Alumno alumnoAux = alumno;

            //foreach (var item in ListaCalificaciones.GetDiccionarioCalificaciones.Keys)
            //{
            //    if (item.Legajo == legajo)
            //    {
            //        alumnoAux = item;
            //    }
            //}

            try
            {
                alumno.Nombre = txt_nombre.Text;
                alumno.Apellido = txt_apellido.Text;

                foreach (Calificacion calificacion in alumno.Calificaciones)
                {
                    if (calificacion.Materia.NombreMateria == txt_materia.Text)
                    {
                        if (calificacion.Examen1 is null)
                        {
                            calificacion.Examen1 = new Examen("Primer Parcial", DateTime.Now);
                        }
                        if (calificacion.Examen2 is null)
                        {
                            calificacion.Examen2 = new Examen("Segundo Parcial", DateTime.Now);
                        }

                        if (int.TryParse(domain_asistencia.Text, out int presentes))
                        {
                            calificacion.CantPresente = presentes;
                        }

                        if (int.TryParse(domain_nota1.Text, out int nota1))
                        {
                            calificacion.Examen1.Nota = nota1;
                        }

                        if (int.TryParse(domain_nota2.Text, out int nota2))
                        {
                            calificacion.Examen2.Nota = nota2;
                        }

                    }
                }
                //alumno = alumnoAux;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception er)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(er.Message);
            }
            this.Close();
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

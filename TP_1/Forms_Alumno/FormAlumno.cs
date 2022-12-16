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
    public partial class form_alumno : Form
    {
        Alumno alumno;

        public form_alumno()
        {
            InitializeComponent();
            //Bitmap img = new Bitmap(Application.StartupPath+@"\Debug\img\fondo.png");
            //this.BackgroundImage = img;
        }
        public form_alumno(Usuario usuario) : this()
        {
            alumno = (Alumno) usuario;

            lbl_bienvenida.Text = "¡Hola, \n" + alumno.Nombre + " " + alumno.Apellido + "!";
        }


        private void form_alumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_inscripcionMaterias_Click(object sender, EventArgs e)
        {
            form_inscripcion formInscripcion = new form_inscripcion(alumno);
            formInscripcion.ShowDialog();
        }

        private void btn_darAsistencia_Click(object sender, EventArgs e)
        {
            form_asistencia formAsitencia = new form_asistencia(alumno);
            formAsitencia.ShowDialog();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_verMaterias_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Alumno", "Materia");
            formBBDD.ShowDialog();
        }
    }
}

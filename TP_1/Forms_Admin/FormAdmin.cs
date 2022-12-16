using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_BBDD;
using System.Text.Json.Serialization;

namespace TP_1
{
    public partial class form_Admin : Form
    {
        private form_Admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public form_Admin(Usuario admin) : this()
        {
            lbl_bienvenida.Text = "¡Hola, \n" + ((Admin)admin).Nombre + " " + ((Admin)admin).Apellido + "!";
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            form_CrearUsuario formCrearUsuario = new form_CrearUsuario();
            DialogResult dg = formCrearUsuario.ShowDialog();
            bool altaUsuario = ListaUsuarios.AgregarUsuario(formCrearUsuario.NuevoUsuario);

            if (dg == DialogResult.OK && altaUsuario)
            {
                MessageBox.Show("Se ha cargado el usuario");
            }
            else if (dg == DialogResult.OK && !altaUsuario)
            {
                MessageBox.Show("Error. Ya existe ese nombre de usuario en el sistemaa.");
            }
            else
            {
                MessageBox.Show("No se ha podido crear el usuario");
            }
        }

        private void btn_verUsuarios_Click(object sender, EventArgs e)
        {
            form_listaUsuario formListaUsuario = new form_listaUsuario();
            formListaUsuario.ShowDialog();
        }

        private void form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_verMaterias_Click(object sender, EventArgs e)
        {
            try
            {


                form_listaMaterias formListaMaterias = new form_listaMaterias();
                formListaMaterias.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_crearMateria_Click(object sender, EventArgs e)
        {
            form_CrearMateria formCrearMateria = new form_CrearMateria();
            DialogResult dg = formCrearMateria.ShowDialog();
            bool altaMateria = ListaMaterias.AgregarMateriaALaListaTotal(formCrearMateria.NuevaMateria);

            if (dg == DialogResult.OK && altaMateria)
            {
                MessageBox.Show("Se ha cargado la materia");
            }
            else if (dg == DialogResult.OK && !altaMateria)
            {
                MessageBox.Show("Error. Ya existe una materia con ese nombre.");
            }
            else
            {
                MessageBox.Show("No se ha podido crear la materia");
            }
        }

        private void btn_gestionarAlumnos_Click(object sender, EventArgs e)
        {
            if (ListaCalificaciones.GetDiccionarioCalificaciones is not null)
            {
                form_gestionarAlumnos formGestionarAlumnos = new form_gestionarAlumnos();

                formGestionarAlumnos.ShowDialog();
            }
        }

        private void btn_gestionarProfesores_Click(object sender, EventArgs e)
        {
            form_gestionarProfesores formGestionarProfesores = new form_gestionarProfesores();

            formGestionarProfesores.ShowDialog();

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inscribir_Click(object sender, EventArgs e)
        {
            form_inscribirAMaterias formInscribirAMaterias = new form_inscribirAMaterias();
            formInscribirAMaterias.ShowDialog();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            form_estadisticas formEstadisticas = new form_estadisticas();
            formEstadisticas.ShowDialog();
        }
        private void btn_AdminBBDD_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Admin", "Admin");
            formBBDD.ShowDialog();
        }


        private void btn_alumnosBBDD_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Alumno", "Alumno");
            formBBDD.ShowDialog();
        }

        private void btn_materiasBBDD_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Admin", "Materia");
            formBBDD.ShowDialog();
        }

        private void btn_profes_Click(object sender, EventArgs e)
        {
            form_BBDD formBBDD = new form_BBDD("Admin", "Profe");
            formBBDD.ShowDialog();
        }

        private void btn_importarJson_Click(object sender, EventArgs e)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "Archivo.json");

            List<AlumnoBBDD> alumnos = DeserializarDesdeJson<List<AlumnoBBDD>>(rutaArchivo);


            foreach (var item in alumnos)
            {
                //MessageBox.Show(item.ToString());
                Console.WriteLine(item.MostrarDatos());
            }
        }

        private static T DeserializarDesdeJson<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta).ToString();

            T objeto = JsonSerializer.Deserialize<T>(objetoJson);
            return objeto;
        }

    }




}


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
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
            CargarDatos();
            txt_nombreUsuario.Text = "adminMaster";
            txt_clave.Text = "12345";
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            var usuarioAux = VerificarUsuario(txt_nombreUsuario.Text, txt_clave.Text);

            if (usuarioAux is not null)
            {
                this.Hide();
                if (usuarioAux.GetType() == typeof(Admin))
                {
                    form_Admin formAdmin = new form_Admin(usuarioAux);
                    formAdmin.ShowDialog();
                }
                else if (usuarioAux.GetType() == typeof(Profesor))
                {
                    form_Profe formProfe = new form_Profe(usuarioAux);
                    formProfe.ShowDialog();
                }
                else if (usuarioAux.GetType() == typeof(Alumno))
                {
                    form_alumno formAlumno = new form_alumno(usuarioAux);
                    formAlumno.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("El usuario indicado no se encuentra registrado");
            }
        }
        private Usuario VerificarUsuario(string nombreUsuario, string clave)
        {

            foreach (var item in ListaUsuarios.GetListaUsuarios)
            {
                if (item.NombreUsuario == nombreUsuario && item.Clave == clave)
                {
                    return item;
                }
            }
            return null;
        }

        public void CargarDatos()
        {

            Admin admin = new Admin("Mirtha", "Perez", "adminMaster", "12345");
            ListaUsuarios.AgregarUsuario(admin);
            Profesor profesor = new Profesor("Susana", "Martinez", "profeMaster", "12345");
            Profesor profesor2 = new Profesor("Marcelo", "Vasquez", "profeMarce", "12345");
            Profesor profesor3 = new Profesor("María", "Torres", "profeLaOne", "12345");
            Profesor profesor4 = new Profesor("Pedro", "Quispe", "profeToto", "12345");
            Profesor profesor5 = new Profesor("Eugenia", "Cabanilla", "profeChina", "12345");
            Profesor profesor6 = new Profesor("Daniela", "Rodriguez", "profeDani", "12345");
            ListaUsuarios.AgregarUsuario(profesor);
            ListaUsuarios.AgregarUsuario(profesor2);
            ListaUsuarios.AgregarUsuario(profesor3);
            ListaUsuarios.AgregarUsuario(profesor4);
            ListaUsuarios.AgregarUsuario(profesor5);
            ListaUsuarios.AgregarUsuario(profesor6);


            List<Profesor> listaProfesoresProgUno = new List<Profesor>();
            List<Profesor> listaProfesIngles = new List<Profesor>();
            List<Profesor> listaProfesoresProgDos = new List<Profesor>();
            List<Profesor> listaProfesoresMatematica = new List<Profesor>();
            List<Profesor> listaProfesoresProgTres= new List<Profesor>();

            List<Alumno> listaAlumnosProgUno = new List<Alumno>();
            List<Alumno> listaAlumnosIngles = new List<Alumno>();
            List<Alumno> listaAlumnosProgDos = new List<Alumno>();
            List<Alumno> listaAlumnosMatematica = new List<Alumno>();

          
            List<Materia> listaCorrelativasProg2 = new List<Materia>();
            List<Materia> listaCorrelativasProg3 = new List<Materia>();

            Materia programacionUno = new("Programación I", listaProfesoresProgUno, listaAlumnosProgUno, eCuatriMestre.Primero);
            Materia programacionDos = new("Programación II", listaProfesoresProgDos, listaAlumnosProgDos, eCuatriMestre.Segundo, listaCorrelativasProg2);
            Materia ingles = new("Inglés", listaProfesIngles, listaAlumnosIngles, eCuatriMestre.Primero);
            Materia matematica = new Materia("Matemática", listaProfesoresProgDos, listaAlumnosMatematica, eCuatriMestre.Primero);
           
            ///

            Materia programacionTres = new Materia("Programacion III", listaProfesoresProgTres, eCuatriMestre.Tercero, listaCorrelativasProg3);


            ///



            //ALLUMNO 1
            List<Calificacion> califAlumno1 = new List<Calificacion>();
            califAlumno1.Add(new Calificacion(matematica,
                                              new Examen("Primer Parcial", new DateTime(2022,06,12), 10),
                                              new Examen("Segundo Parcial", new DateTime(2022,09,12), 9),
                                              18));
                       
            
            califAlumno1.Add(new Calificacion(ingles,
                                              new Examen("Primer Parcial", new DateTime(2021,06,2), 8),
                                              new Examen("Segundo Parcial", new DateTime(2021,09,1), 7),
                                              16));
            
            califAlumno1.Add(new Calificacion(programacionUno,
                                              new Examen("Primer Parcial", new DateTime(2022,12,2)),
                                              new Examen("Segundo Parcial", new DateTime(2022,12,1)),
                                              0));


            Alumno alumno1 = new Alumno("Oriana", "Gimenez", "alumnoMaster", "12345", califAlumno1);

            listaAlumnosMatematica.Add(alumno1);
            listaAlumnosIngles.Add(alumno1);
            ListaUsuarios.AgregarUsuario(alumno1);


            //ALLUMNO 2
            List<Calificacion> califAlumno2 = new List<Calificacion>();
            califAlumno2.Add(new Calificacion(programacionUno,
                                              new Examen("Primer Parcial", new DateTime(2022, 07, 12), 8),
                                              new Examen("Segundo Parcial", new DateTime(2022,10, 12), 7),                      19));
            
            califAlumno2.Add(new Calificacion(ingles,
                                              new Examen("Primer Parcial", new DateTime(2021, 03, 13), 9),
                                              new Examen("Segundo Parcial", new DateTime(2021,10, 1), 10),                      18));


            Alumno alumno2 = new Alumno("Karina", "Rosas", "TuKari", "12345", califAlumno2);
            listaAlumnosProgUno.Add(alumno2);
            listaAlumnosIngles.Add(alumno2);
            ListaUsuarios.AgregarUsuario(alumno2);

            //ALLUMNO 3
            List<Calificacion> califAlumno3 = new List<Calificacion>();
            califAlumno3.Add(new Calificacion(matematica,
                                              new Examen("Primer Parcial", new DateTime(2022, 03, 12), 8),
                                              new Examen("Segundo Parcial", new DateTime(2022, 06, 12), 7),
                                              18));
            Alumno alumno3 = new Alumno("Zulma", "Canales", "LaZu", "12345", califAlumno3);
            listaAlumnosMatematica.Add(alumno3);
            ListaUsuarios.AgregarUsuario(alumno3);

            //ALLUMNO 4         
            List<Calificacion> califAlumno4 = new List<Calificacion>();
            califAlumno4.Add(new Calificacion(ingles,
                                              new Examen("Primer Parcial", new DateTime(2022, 01, 04), 8),
                                              new Examen("Segundo Parcial", new DateTime(2022, 11, 12), 2),
                                              15));
            califAlumno4.Add(new Calificacion(programacionUno,
                                              new Examen("Primer Parcial", new DateTime(2022, 02, 05), 4),
                                              new Examen("Segundo Parcial", new DateTime(2022, 11, 12), 1),
                                              3));
            Alumno alumno4 = new Alumno("Guido", "Rodriguez", "ElTomi", "12345", califAlumno4);
            listaAlumnosIngles.Add(alumno4);
            ListaUsuarios.AgregarUsuario(alumno4);


            //ALLUMNO 5
            List<Calificacion> califAlumno5 = new List<Calificacion>();
            
            
            califAlumno5.Add(new Calificacion(programacionDos,
                                              new Examen("Primer Parcial", new DateTime(2022, 02, 4), 1),
                                              new Examen("Segundo Parcial", new DateTime(2022, 12, 12),2),
                                              16));
            Alumno alumno5 = new Alumno("Carolina", "Melchor", "LaMeche", "12345", califAlumno5);
            listaAlumnosProgDos.Add(alumno5);
            ListaUsuarios.AgregarUsuario(alumno5);

            //ALLUMNO 6
            List<Calificacion> califAlumno6 = new List<Calificacion>();
            List<Materia> listaMateriaAlumno6 = new List<Materia>();
            listaMateriaAlumno6.Add(matematica);
            califAlumno6.Add(new Calificacion(programacionDos,
                                              new Examen("Primer Parcial", new DateTime(2022,05,04),5),
                                              new Examen("Segundo Parcial", new DateTime(2022,11,12),6),
                                              18));
            Alumno alumno6 = new Alumno("Abigail", "Coria", "LaAbi", "12345", califAlumno6);
            listaAlumnosProgDos.Add(alumno6);
            ListaUsuarios.AgregarUsuario(alumno6);

            //ALLUMNO 7
            List<Calificacion> califAlumno7 = new List<Calificacion>();
            califAlumno7.Add(new Calificacion(matematica,
                                              new Examen("Primer Parcial", new DateTime(2022, 02, 12), 8),
                                              new Examen("Segundo Parcial", new DateTime(2022, 06, 12), 2),                     14));
            Alumno alumno7 = new Alumno("Jorge", "Ferreira", "ElChamo", "12345", califAlumno7);
            listaAlumnosMatematica.Add(alumno7);
            ListaUsuarios.AgregarUsuario(alumno7);

            //ALUMNO 8
            List<Calificacion> califAlumno8 = new List<Calificacion>();
            califAlumno8.Add(new Calificacion(programacionUno));
            califAlumno8.Add(new Calificacion(ingles));
            Alumno alumno8 = new Alumno("Pablo", "Cossio", "pablitoATR", "12345", califAlumno8);
            listaAlumnosIngles.Add(alumno8);
            listaAlumnosMatematica.Add(alumno8);
            ListaUsuarios.AgregarUsuario(alumno8);

            //ALUMNO 9
            List<Calificacion> califAlumno9 = new List<Calificacion>();
            califAlumno9.Add(new Calificacion(matematica));
            califAlumno9.Add(new Calificacion(programacionUno));
            Alumno alumno9 = new Alumno("Catalina", "Flores", "Catita", "12345", califAlumno9);
            listaAlumnosMatematica.Add(alumno9);
            listaAlumnosProgUno.Add(alumno9);
            ListaUsuarios.AgregarUsuario(alumno9);

            //ALUMNO 10
            List<Calificacion> califAlumno10 = new List<Calificacion>();
            califAlumno10.Add(new Calificacion(programacionDos));
            //List<Materia> materiasAprobadasAlumno10 = new List<Materia>();
            //materiasAprobadasAlumno10.Add(ingles);
            //materiasAprobadasAlumno10.Add(programacionUno);
            Alumno alumno10 = new Alumno("Junior", "Moreno", "JuMore", "12345", califAlumno10);
            listaAlumnosProgDos.Add(alumno10);
            ListaUsuarios.AgregarUsuario(alumno10);

            //ALUMNO 11
            List<Calificacion> califAlumno11 = new List<Calificacion>();
            califAlumno11.Add(new Calificacion(programacionUno));
            Alumno alumno11 = new Alumno("Bryan", "Goldin", "Colombiaxxx", "12345", califAlumno11);
            listaAlumnosProgUno.Add(alumno11);
            ListaUsuarios.AgregarUsuario(alumno11);

            //ALUMNO 12
            List<Calificacion> califAlumno12 = new List<Calificacion>();
            califAlumno12.Add(new Calificacion(matematica));
            Alumno alumno12 = new Alumno("Nelida", "Murguia", "NelidaMex", "12345", califAlumno12);
            listaAlumnosProgUno.Add(alumno12);
            ListaUsuarios.AgregarUsuario(alumno12);


            ListaMaterias.AgregarMateriaALaListaTotal(programacionUno);
            ListaMaterias.AgregarMateriaALaListaTotal(programacionDos);
            ListaMaterias.AgregarMateriaALaListaTotal(programacionTres);
            ListaMaterias.AgregarMateriaALaListaTotal(ingles);
            ListaMaterias.AgregarMateriaALaListaTotal(matematica);
            

            listaProfesoresProgUno.Add(profesor);
            listaProfesoresProgUno.Add(profesor2);
            listaProfesoresProgDos.Add(profesor4);
            listaProfesoresProgDos.Add(profesor5);
            listaProfesoresProgTres.Add(profesor6);
            listaProfesIngles.Add(profesor);
            listaProfesIngles.Add(profesor2);
            listaProfesIngles.Add(profesor3);
            listaProfesoresMatematica.Add(profesor5);
            

            listaCorrelativasProg2.Add(programacionUno);
            listaCorrelativasProg2.Add(ingles);
            listaCorrelativasProg3.Add(programacionDos);

            ListaMaterias.CargarMateriasAProfes();


            //HARCODEO FINALES
            Examen examen1 = new Examen("Final Prog I", new DateTime(2022, 12, 22));
            Examen examen2 = new Examen("Final Prog II", new DateTime(2022, 11, 3));
            Examen examen3 = new Examen("Final Matematica", new DateTime(2022, 10, 8));
            Examen examen4 = new Examen("Final Inglés I", new DateTime(2022, 1, 7));
            Examen examen5 = new Examen("Final Inglés I", new DateTime(2022, 2, 5));
            Examen examen6 = new Examen("Final Matematica", new DateTime(2022, 5, 24));
            
            examen1.AgregarAlumnoAFinal(alumno4);
            examen1.AgregarAlumnoAFinal(alumno2);
            examen3.AgregarAlumnoAFinal(alumno8);
            examen3.AgregarAlumnoAFinal(alumno6);
            examen4.AgregarAlumnoAFinal(alumno3);
            examen4.AgregarAlumnoAFinal(alumno5);

            ListaExamenes.GetdiccionarioExamenes.Add(examen1, programacionUno);
            ListaExamenes.GetdiccionarioExamenes.Add(examen2, programacionDos);
            ListaExamenes.GetdiccionarioExamenes.Add(examen3, matematica);
            ListaExamenes.GetdiccionarioExamenes.Add(examen4, ingles);
            ListaExamenes.GetdiccionarioExamenes.Add(examen5, ingles);
            ListaExamenes.GetdiccionarioExamenes.Add(examen6, matematica);


        }
        private void btn_completarAdmin_Click(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = "adminMaster";
            txt_clave.Text = "12345";
        }

        private void btn_completarProfesor_Click(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = "profeMaster";
            txt_clave.Text = "12345";
        }

        private void btn_completarAlumno_Click(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = "alumnoMaster";
            txt_clave.Text = "12345";
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }
    }
}

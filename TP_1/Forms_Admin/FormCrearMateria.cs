using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_CrearMateria : Form
    {
        private Materia nuevaMateria;
        //  private Dictionary<string, int> diccionarioProfesores;

        public Materia NuevaMateria { get => nuevaMateria; set => nuevaMateria = value; }

        public form_CrearMateria()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public form_CrearMateria(Materia nuevaMateria) : this()
        {
            this.nuevaMateria = nuevaMateria;
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            bool validarDatos = ValidarDatos();

            if (validarDatos)
            {
                string nombre = txt_nombre.Text.ToString();
                int cuatri = combo_cuatri.SelectedIndex;
                List<Profesor> profesNuevaMateria = new List<Profesor>();               
                eCuatriMestre nuevoCuatri = ObtenerCuatriMestre(cuatri);


                //Entra si solo los parámetros profe2, materiaCorrelativa1 y materiaCorrelativa2 son nulos
                if (string.IsNullOrEmpty(combo_profe2.Text) && string.IsNullOrEmpty(combo_correlativa1.Text) && string.IsNullOrEmpty(combo_correlativa2.Text))
                {
                    nuevaMateria = new Materia(nombre, profesNuevaMateria, nuevoCuatri);
                }
                //Entra si solo los parámetros materiaCorrelativa1 y materiaCorrelativa2 son nulos
                else if (!string.IsNullOrEmpty(combo_profe1.Text) && !string.IsNullOrEmpty(combo_profe2.Text) && string.IsNullOrEmpty(combo_correlativa1.Text) && string.IsNullOrEmpty(combo_correlativa2.Text))
                {
                    Profesor profeAux1 = ObtenerProfesor(combo_profe1.Text);
                    Profesor profeAux2 = ObtenerProfesor(combo_profe2.Text);
                    profesNuevaMateria.Add(profeAux1);
                    profesNuevaMateria.Add(profeAux2);
                    nuevaMateria = new Materia(nombre, profesNuevaMateria, nuevoCuatri);
                }
                //Entra si solo los parámetros materiaCorrelativa1 es nulo
                else if (!string.IsNullOrEmpty(combo_profe2.Text) && string.IsNullOrEmpty(combo_correlativa1.Text) && !string.IsNullOrEmpty(combo_correlativa2.Text))
                {
                    Profesor profeAux1 = ObtenerProfesor(combo_profe1.Text);
                    profesNuevaMateria.Add(profeAux1);
                    List<Materia> correlativas = new List<Materia>();
                    correlativas.Add(ObtenerMateria(combo_correlativa2.Text));
                    nuevaMateria = new Materia(nombre, profesNuevaMateria, nuevoCuatri, correlativas);
                }
                //Entra si solo el parámetro materiaCorrelativa2 es nulo
                else if (!string.IsNullOrEmpty(combo_profe2.Text) && !string.IsNullOrEmpty(combo_correlativa1.Text) && string.IsNullOrEmpty(combo_correlativa2.Text))
                {
                    Profesor profeAux2 = ObtenerProfesor(combo_profe2.Text);
                    profesNuevaMateria.Add(profeAux2);
                    List<Materia> correlativas = new List<Materia>();
                    correlativas.Add(ObtenerMateria(combo_correlativa1.Text));
                    nuevaMateria = new Materia(nombre, profesNuevaMateria, nuevoCuatri, correlativas);
                }
                //Entra si no hay datos nulos
                else if (!string.IsNullOrEmpty(combo_profe2.Text) && !string.IsNullOrEmpty(combo_correlativa1.Text) && !string.IsNullOrEmpty(combo_correlativa2.Text))
                {
                    Profesor profeAux1 = ObtenerProfesor(combo_profe1.Text);
                    Profesor profeAux2 = ObtenerProfesor(combo_profe2.Text);
                    profesNuevaMateria.Add(profeAux1);
                    profesNuevaMateria.Add(profeAux2);
                    List<Materia> correlativas = new List<Materia>();
                    Materia materiaAux1 = ObtenerMateria(combo_correlativa1.Text);
                    Materia materiaAux2 = ObtenerMateria(combo_correlativa2.Text);
                    correlativas.Add(materiaAux1);
                    correlativas.Add(materiaAux2);
                    nuevaMateria = new Materia(nombre, profesNuevaMateria, nuevoCuatri, correlativas);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool retorno = true;

            string nombre = txt_nombre.Text;
            string profe1 = combo_profe1.Text;
            string profe2 = combo_profe2.Text;
            string cuatri = combo_cuatri.Text.ToString();

           
            if(string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No ha ingresado el nombre de la materia.");
                retorno = false;
            }
            else if(string.IsNullOrEmpty(cuatri))
            {
                MessageBox.Show("No ha ingresado el cuatrimestre.");
                retorno = false;
            }
            else if (string.IsNullOrEmpty(profe1))
            {
                MessageBox.Show("Debe elegir al menos un profesor.");
                retorno = false;
            }
            else if((profe1 == profe2) && (!string.IsNullOrEmpty(profe1) && !string.IsNullOrEmpty(profe1)))
            {
                MessageBox.Show("No puede elegir 2 veces el mismo profesor.");
                retorno = false;
            }

            return retorno;
        }
        private Profesor ObtenerProfesor(string nombreProfesor)
        {
            Profesor profeAux = null;

            string nombreYApellido;

            foreach (var item in ListaUsuarios.GetListaUsuarios)
            {
                if (item is Profesor)
                {
                    nombreYApellido = ((Profesor)item).Nombre + " " + ((Profesor)item).Apellido;

                    if (nombreYApellido == nombreProfesor)
                    {
                        profeAux = (Profesor)item;
                        break;
                    }
                }
            }
            return profeAux;
        }

        private eCuatriMestre ObtenerCuatriMestre(int indice)
        {
            eCuatriMestre eCuatriAux = eCuatriMestre.Primero;

            int cuatriAux = indice + 1;

            switch (cuatriAux)
            {
                case 2:
                    eCuatriAux = eCuatriMestre.Segundo;

                    break;
                case 3:
                    eCuatriAux = eCuatriMestre.Tercero;

                    break;
                case 4:
                    eCuatriAux = eCuatriMestre.Cuarto;
                    break;
            }

            return eCuatriAux;
        }
        private Materia ObtenerMateria(string nombreMateria)
        {
            Materia materiaAux = null;

            foreach (var item in ListaMaterias.GetListaMateriaTotales)
            {
                if (item.NombreMateria == nombreMateria)
                {
                    materiaAux = item;
                    break;
                }

            }
            return materiaAux;
        }
        private void form_CrearMateria_Load(object sender, EventArgs e)
        {
            combo_cuatri.Items.Add((eCuatriMestre.Primero.ToString()));
            combo_cuatri.Items.Add((eCuatriMestre.Segundo.ToString()));
            combo_cuatri.Items.Add((eCuatriMestre.Tercero.ToString()));
            combo_cuatri.Items.Add((eCuatriMestre.Cuarto.ToString()));

            foreach (var item in ListaUsuarios.GetListaUsuarios)
            {
                if (item is Profesor)
                {
                    combo_profe1.Items.Add(((Profesor)item).Nombre + " " + ((Profesor)item).Apellido);
                    combo_profe2.Items.Add(((Profesor)item).Nombre + " " + ((Profesor)item).Apellido);
                }
            }

            foreach (var item in ListaMaterias.GetListaMateriaTotales)
            {
                combo_correlativa1.Items.Add(item.NombreMateria);
                combo_correlativa2.Items.Add(item.NombreMateria);
            }
        }

        private void combo_profe1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_cuatri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_cuatri.SelectedIndex == 0)
            {
                combo_correlativa1.Enabled = false;
                combo_correlativa2.Enabled = false;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

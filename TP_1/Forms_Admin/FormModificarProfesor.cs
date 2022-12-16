using Biblioteca;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_editarProfesor : Form
    {
        Profesor profesor;
        int legajo;
        public form_editarProfesor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        public form_editarProfesor(int legajo) : this()
        {
            this.legajo = legajo;
        }
        public form_editarProfesor(Profesor profesor) : this()
        {
            this.profesor = profesor;
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarProfesor_Load(object sender, EventArgs e)
        {
            cmb_materia1.Items.Add(" ");
            cmb_materia2.Items.Add(" ");
            cmb_materia3.Items.Add(" ");
            foreach (Materia materia in ListaMaterias.GetListaMateriaTotales)
            {
                cmb_materia1.Items.Add(materia.NombreMateria);
                cmb_materia2.Items.Add(materia.NombreMateria);
                cmb_materia3.Items.Add(materia.NombreMateria);
            }

            foreach (var item in ListaUsuarios.GetListaUsuarios)
            {
                if (item.Legajo == legajo)
                {
                    this.profesor = (Profesor)item;

                    foreach (Materia materia in ((Profesor)item).MateriasAsignadas)
                    {
                        if (cmb_materia1.Text == "")
                        {
                            cmb_materia1.Text = materia.NombreMateria;
                        }
                        else if (cmb_materia2.Text == "")
                        {
                            cmb_materia2.Text = materia.NombreMateria;
                        }
                        else if (cmb_materia3.Text == "")
                        {
                            cmb_materia2.Text = materia.NombreMateria;
                        }
                    }
                }
            }

            txt_legajo.Text = legajo.ToString();
            txt_usuario.Text = profesor.NombreUsuario;
            txt_nombre.Text = profesor.Nombre;
            txt_apellido.Text = profesor.Apellido;


        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            foreach(Materia materia in ListaMaterias.GetListaMateriaTotales)
            {
                foreach (Profesor itemProfesor in materia.ListaProfesoresAsignados)
                {
                   if(itemProfesor.Legajo == this.profesor.Legajo)
                    {
                        itemProfesor.MateriasAsignadas.Clear();
                        itemProfesor.MateriasAsignadas.Remove(materia);
                    }
                }
            }

            Profesor profeAux = profesor;


            try
            {
                profeAux.Nombre = txt_nombre.Text;
                profeAux.Apellido = txt_apellido.Text;
                List<Materia> materiasAux = new List<Materia>();

                foreach (Materia materia in ListaMaterias.GetListaMateriaTotales)
                {                      
                    if(materia.NombreMateria == cmb_materia1.Text)
                    {
                        materiasAux.Add(materia);
                    }                   
                    if(materia.NombreMateria == cmb_materia2.Text)
                    {
                        materiasAux.Add(materia);
                    }                   
                    if(materia.NombreMateria == cmb_materia3.Text)
                    {
                        materiasAux.Add(materia);
                    }              
                }
             
                profeAux.MateriasAsignadas = materiasAux;

                this.profesor = profeAux;
                this.DialogResult = DialogResult.OK;

            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

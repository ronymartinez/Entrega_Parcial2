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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_1
{
    public partial class form_crearExamen : Form
    {
        private Profesor profe;
        private Examen examen;
        private Materia materia;

        public form_crearExamen()
        {
            InitializeComponent();
        }

        public form_crearExamen(Profesor profe):this()
        {
            this.profe = profe;
        }


        private void FormCrearExamen_Load(object sender, EventArgs e)
        {
            foreach (var itemProfe in profe.MateriasAsignadas)
            {
                combo_materiaExamen.Items.Add(itemProfe.NombreMateria);
            }
            if (combo_materiaExamen.Items.Count > 0)
            {
                combo_materiaExamen.SelectedIndex = 0;

            }
        }

        //public Examen ObtenerExamen()
        //{
        //    //Examen examen = null;
        //    //if (Validardatos())
        //    //{
        //    //    examen = new Examen(txt_nombreExamen.Text, date_Examen.Value);
        //    //    DialogResult = DialogResult.OK;
        //    //}

        //    //return examen;
        //}
        //public Examen Examen { get => examen; }

        private bool Validardatos()
        {
            bool retorno = false;

            if (!string.IsNullOrEmpty(combo_materiaExamen.Text) && !string.IsNullOrEmpty(date_Examen.Text) && !string.IsNullOrEmpty(txt_nombreExamen.Text))
            {
                retorno = true;
            }
            return retorno;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        //     private string nombre;
        //private DateTime fecha;
        //private int nota;

            if (Validardatos())
            {
                examen = new Examen(txt_nombreExamen.Text, date_Examen.Value);
                
                foreach(Materia item in ListaMaterias.GetListaMateriaTotales)
                {
                    if(combo_materiaExamen.Text == item.NombreMateria)
                    {
                        materia = item;
                    }
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public Examen Examen { get => examen; set => examen = value; }
        public Materia Materia { get => materia; set => materia = value; }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

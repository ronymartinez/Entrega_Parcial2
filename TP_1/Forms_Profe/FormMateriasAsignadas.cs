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
    public partial class form_materiasAsignadas : Form
    {
        Profesor profe;
        public form_materiasAsignadas()
        {
            InitializeComponent();
            CargarPropiedades();
        }
        public form_materiasAsignadas(Profesor profe) : this()
        {
            this.profe = profe;
            this.Text = "Materias Asignadas a " + profe.Nombre + " " + profe.Apellido;
        }

        private void VerMateriasAsignadas_Load(object sender, EventArgs e)
        {
            foreach (var itemProfe in profe.MateriasAsignadas)
            {
                combo_materia.Items.Add(itemProfe.NombreMateria);
            }           
        }

        private void CargarPropiedades()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dgv_materiasAsignadas.RowHeadersVisible = false;
            dgv_materiasAsignadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_materiasAsignadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_materiasAsignadas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_materiasAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_materiasAsignadas.AllowUserToAddRows = false;
            dgv_materiasAsignadas.ReadOnly = true;
        }

        private void combo_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_materiasAsignadas.Rows.Clear();
            string? nombreMateria = combo_materia.SelectedItem.ToString();

            foreach (var itemMateria in profe.MateriasAsignadas)
            {
                if (itemMateria.NombreMateria == nombreMateria)
                {
                    foreach (var itemAlumno in itemMateria.ListaAlumnosAsignados)
                    {
                        int n = this.dgv_materiasAsignadas.Rows.Add();
                        dgv_materiasAsignadas.Rows[n].Cells[0].Value = itemAlumno.Legajo.ToString();
                        dgv_materiasAsignadas.Rows[n].Cells[1].Value = itemAlumno.Nombre.ToString();
                        dgv_materiasAsignadas.Rows[n].Cells[2].Value = itemAlumno.Apellido.ToString();
                        n++;
                    }
                }
            }
          
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

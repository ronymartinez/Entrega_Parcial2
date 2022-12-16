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
    public partial class form_ListaExamenes : Form
    {
        public form_ListaExamenes()
        {
            InitializeComponent();
            CargarPropiedades();
            //CargarDataGrid();
        }

        private void CargarPropiedades()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            dgv_listaExamenes.RowHeadersVisible = false;
            dgv_listaExamenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaExamenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_listaExamenes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_listaExamenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listaExamenes.AllowUserToAddRows = false;
            dgv_listaExamenes.ReadOnly = true;
        }

        private void form_ListaExamenes_Load(object sender, EventArgs e)
        {
            dgv_listaExamenes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (var item in ListaExamenes.GetdiccionarioExamenes)
            {
                // MAteria - fecha - nombre - alumnos
                int n = dgv_listaExamenes.Rows.Add();
                StringBuilder sb = new StringBuilder();

                dgv_listaExamenes.Rows[n].Cells[0].Value = item.Value.NombreMateria;
                dgv_listaExamenes.Rows[n].Cells[1].Value = item.Key.Fecha.ToShortDateString();
                dgv_listaExamenes.Rows[n].Cells[2].Value = item.Key.Nombre;

               
                    dgv_listaExamenes.Rows[n].Cells[3].Value = item.Key.ListadoDeAlumnosString();
                
                n++;
            }

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

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
using Biblioteca_BBDD;
using Newtonsoft.Json;

namespace TP_1
{
    public delegate void DelegadoLeer();

    public partial class form_BBDD : Form
    {

        string tabla;
        int id;
        AlumnoBBDD alumno;
        public form_BBDD()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        public form_BBDD(string perfil, string tabla) : this()
        {
            Text = perfil;
            this.tabla = tabla;

            if (tabla == "Admin")
            {
                lbl_titulo.Text = "Listado de \nAdministradores";
            }

            if (tabla == "Alumno")
            {
                lbl_titulo.Text = "Listado de \nAlumnos";
            }
            if (tabla == "Materia")
            {
                lbl_titulo.Text = "Listado de \nMaterias";
            }
            if (perfil == "Alumno" && tabla == "Materia")
            {
                btn_eliminar.Visible = false;
            }
            if (perfil == "Admin" && tabla == "Json")
            {
                LeerArchivoJson();
            }

        }
        private void Refrescar()
        {
            dgv_tabla.Update();
            dgv_tabla.Refresh();
        }
        private void ejecutarDataGrid(DelegadoLeer delegado)
        {
            try
            {
                Refrescar();
                //dgv_tabla.Rows.Clear();
                dgv_tabla.RowHeadersVisible = false;
                dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_tabla.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_tabla.AllowUserToAddRows = false;

                delegado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDatagridAlumnos()
        {
            try
            {
                dgv_tabla.DataSource = ConexionBBDD.LeerAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDatagridProfesores()
        {
            try
            {
                dgv_tabla.DataSource = ConexionBBDD.LeerProfesor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDatagridAdmin()
        {
            try
            {
                dgv_tabla.DataSource = ConexionBBDD.LeerAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDatagridMateria()
        {
            try
            {
                dgv_tabla.DataSource = ConexionBBDD.LeerMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btb_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (dgv_tabla.SelectedRows.Count > 0)
            {
                if (tabla == "Admin")
                {
                    ejecutarDataGrid(CargarDatagridAdmin);
                }

                if (tabla == "Alumno")
                {
                    ConexionBBDD.GuardarAlumno(alumno);
                    ejecutarDataGrid(CargarDatagridAlumnos);

                }
                if (tabla == "Materia")
                {
                    //ConexionBBDD.EliminarMateria(id);
                    ejecutarDataGrid(CargarDatagridMateria);
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (tabla == "Admin")
                {
                    ConexionBBDD.EliminarAdmin(id);
                    ejecutarDataGrid(CargarDatagridAdmin);
                }

                if (tabla == "Alumno")
                {
                    ConexionBBDD.EliminarALumno(id);
                    ejecutarDataGrid(CargarDatagridAlumnos);

                }
                if (tabla == "Materia")
                {
                    ConexionBBDD.EliminarMateria(id);
                    ejecutarDataGrid(CargarDatagridMateria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Se ha eliminado el registro");
            }

        }

        private void form_BBDD_Load(object sender, EventArgs e)
        {

            if (tabla == "Admin")
            {
                ejecutarDataGrid(CargarDatagridAdmin);
            }
            if (tabla == "Materia")
            {
                ejecutarDataGrid(CargarDatagridMateria);
            }

            if (tabla == "Profe")
            {
                //ejecutarDataGrid(CargarDatagridProfesores);
                CargarDatagridProfesores();
            }

            if (tabla == "Alumno")
            {
                ejecutarDataGrid(CargarDatagridAlumnos);
            }
        }

        private void LeerArchivoJson()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            lbl_titulo.Text = "Lista \nde JSON";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileJson = openFileDialog.FileName;

                DataTable tablaJson = (DataTable)JsonConvert.DeserializeObject(fileJson, typeof(DataTable));

                dgv_tabla.DataSource = tablaJson;
            }

        }

    }
}

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
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class form_listaMaterias : Form
    {
        string materia;
        Materia materiaAux;
        public delegate void DelegadoSerializar<T>(T objeto);

        public form_listaMaterias()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            DevolverMateria(materia);
        }

        private void SizeAllRows(Object sender,
        EventArgs e)
        {
            dgv_listaMateria.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void FormListaMateria_Load(object sender, EventArgs e)
        {
            dgv_listaMateria.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_listaMateria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (var item in ListaMaterias.GetListaMateriaTotales)
            {
                int n = dgv_listaMateria.Rows.Add();

                dgv_listaMateria.Rows[n].Cells[0].Value = item.NombreMateria;
                dgv_listaMateria.Rows[n].Cells[1].Value = item.MostrarProfesores();
                dgv_listaMateria.Rows[n].Cells[2].Value = item.MostrarAlumnos();
                dgv_listaMateria.Rows[n].Cells[3].Value = item.Cuatrimestre;
                dgv_listaMateria.Rows[n].Cells[4].Value = item.MostrarCorrelativas();
                dgv_listaMateria.Rows[n].Cells[5].Value = "Tecnicatura en Programación";
                dgv_listaMateria.Rows[n].Cells[6].Value = "2022";

                n++;
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportarCSV<T>(T objeto)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Archivo CSV|*.csv" };

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> filas = new List<string>();
                    List<string> cabeceras = new List<string>();
                    foreach (DataGridViewColumn item in dgv_listaMateria.Columns)
                    {
                        cabeceras.Add(item.HeaderText);
                    }
                    string separador = " | ";
                    filas.Add(string.Join(separador, cabeceras));


                    filas.Add(materiaAux.NombreMateria + separador +
                               materiaAux.IMostrarListadoProfesores() + separador +
                               materiaAux.IMostrarListadoAlumnos() + separador +
                               materiaAux.IMostrarListadoCorrelativas() + separador +
                               "Tecnicatura en Programación" + separador +
                               "2022" + separador);

                    File.WriteAllLines(saveFileDialog.FileName, filas);
                    MessageBox.Show("Se ha guardado el archivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ExportarJson<T>(T objeto)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "Archivo Json|*.json" };
            
            Materia nuevaMateria = new Materia();
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {                   
                    nuevaMateria.ListaCorrelativas = materiaAux.ListaCorrelativas;

                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        options.ReferenceHandler = ReferenceHandler.Preserve;

                        string materiaJson = JsonSerializer.Serialize(objeto, options);                 

                        File.WriteAllText(saveFileDialog.FileName, materiaJson);


                    MessageBox.Show("Se ha guardado el archivo.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btn_CSV_Click(object sender, EventArgs e)
        {
            ExportarCSV(materiaAux);
        }
        private void btn_Json_Click(object sender, EventArgs e)
        {
            ExportarJson(materiaAux);
        }
        private void ExportarArchivo<T>(T delegadoSerializar)
        {
        }
        private void dgv_listaMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0)
                {
                    if (dgv_listaMateria.Rows[e.RowIndex].Cells[0].Value.ToString() is not null)
                    {
                        materia = dgv_listaMateria.Rows[e.RowIndex].Cells[0].Value.ToString();
                        DevolverMateria(materia);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DevolverMateria(string materia)
        {
            if (materia is not null)
            {
                foreach (Materia item in ListaMaterias.GetListaMateriaTotales)
                {
                    if (item.NombreMateria == materia)
                    {
                        materiaAux = item;
                        break;
                    }
                }
            }
            else
            {
                foreach (Materia item in ListaMaterias.GetListaMateriaTotales)
                {
                    if (item.NombreMateria == "Programación I")
                    {
                        materiaAux = item;
                        break;
                    }
                }
            }
        }

    }
}

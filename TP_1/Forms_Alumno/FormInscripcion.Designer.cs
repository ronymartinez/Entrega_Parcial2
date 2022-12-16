
namespace TP_1
{
    partial class form_inscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_inscribir = new System.Windows.Forms.Button();
            this.lbl_elegir = new System.Windows.Forms.Label();
            this.dgv_materiasInscriptas = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_listaMateriasTotales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_elija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasInscriptas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaMateriasTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(717, 278);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(148, 65);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(717, 175);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(148, 65);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_inscribir
            // 
            this.btn_inscribir.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_inscribir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscribir.ForeColor = System.Drawing.Color.White;
            this.btn_inscribir.Location = new System.Drawing.Point(717, 76);
            this.btn_inscribir.Name = "btn_inscribir";
            this.btn_inscribir.Size = new System.Drawing.Size(148, 65);
            this.btn_inscribir.TabIndex = 10;
            this.btn_inscribir.Text = "Inscribir";
            this.btn_inscribir.UseVisualStyleBackColor = false;
            this.btn_inscribir.Click += new System.EventHandler(this.btn_inscribir_Click);
            // 
            // lbl_elegir
            // 
            this.lbl_elegir.AutoSize = true;
            this.lbl_elegir.Location = new System.Drawing.Point(291, 76);
            this.lbl_elegir.Name = "lbl_elegir";
            this.lbl_elegir.Size = new System.Drawing.Size(123, 20);
            this.lbl_elegir.TabIndex = 9;
            this.lbl_elegir.Text = "Elija una materia:";
            // 
            // dgv_materiasInscriptas
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_materiasInscriptas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_materiasInscriptas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_materiasInscriptas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_materiasInscriptas.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasInscriptas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_materiasInscriptas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiasInscriptas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Anio,
            this.Promedio,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasInscriptas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_materiasInscriptas.Enabled = false;
            this.dgv_materiasInscriptas.GridColor = System.Drawing.Color.Black;
            this.dgv_materiasInscriptas.Location = new System.Drawing.Point(124, 442);
            this.dgv_materiasInscriptas.Name = "dgv_materiasInscriptas";
            this.dgv_materiasInscriptas.RowHeadersVisible = false;
            this.dgv_materiasInscriptas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_materiasInscriptas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_materiasInscriptas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateBlue;
            this.dgv_materiasInscriptas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_materiasInscriptas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateBlue;
            this.dgv_materiasInscriptas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_materiasInscriptas.RowTemplate.Height = 29;
            this.dgv_materiasInscriptas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_materiasInscriptas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materiasInscriptas.Size = new System.Drawing.Size(741, 220);
            this.dgv_materiasInscriptas.TabIndex = 7;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "MATERIA";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            // 
            // Anio
            // 
            this.Anio.HeaderText = "AÑO";
            this.Anio.MinimumWidth = 6;
            this.Anio.Name = "Anio";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "PROMEDIO";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(372, 391);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(243, 26);
            this.lbl_titulo.TabIndex = 13;
            this.lbl_titulo.Text = "Materias Inscriptas:";
            // 
            // dgv_listaMateriasTotales
            // 
            this.dgv_listaMateriasTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listaMateriasTotales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_listaMateriasTotales.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgv_listaMateriasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaMateriasTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Correlativas});
            this.dgv_listaMateriasTotales.GridColor = System.Drawing.Color.Black;
            this.dgv_listaMateriasTotales.Location = new System.Drawing.Point(124, 76);
            this.dgv_listaMateriasTotales.Name = "dgv_listaMateriasTotales";
            this.dgv_listaMateriasTotales.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_listaMateriasTotales.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_listaMateriasTotales.RowTemplate.Height = 29;
            this.dgv_listaMateriasTotales.Size = new System.Drawing.Size(566, 267);
            this.dgv_listaMateriasTotales.TabIndex = 14;
            this.dgv_listaMateriasTotales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaMateriasTotales_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "MATERIA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Correlativas
            // 
            this.Correlativas.HeaderText = "CORRELATIVAS";
            this.Correlativas.MinimumWidth = 6;
            this.Correlativas.Name = "Correlativas";
            // 
            // lbl_elija
            // 
            this.lbl_elija.AutoSize = true;
            this.lbl_elija.BackColor = System.Drawing.Color.Transparent;
            this.lbl_elija.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_elija.ForeColor = System.Drawing.Color.White;
            this.lbl_elija.Location = new System.Drawing.Point(124, 33);
            this.lbl_elija.Name = "lbl_elija";
            this.lbl_elija.Size = new System.Drawing.Size(509, 26);
            this.lbl_elija.TabIndex = 15;
            this.lbl_elija.Text = "Elija la materia a la que se quiera inscribir:";
            // 
            // form_inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 705);
            this.Controls.Add(this.lbl_elija);
            this.Controls.Add(this.dgv_listaMateriasTotales);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_inscribir);
            this.Controls.Add(this.lbl_elegir);
            this.Controls.Add(this.dgv_materiasInscriptas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_inscripcion";
            this.Text = "Inscripción a Materias (Perfil Alumno)";
            this.Load += new System.EventHandler(this.form_inscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasInscriptas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaMateriasTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_inscribir;
        private System.Windows.Forms.Label lbl_elegir;
        private System.Windows.Forms.DataGridView dgv_materiasInscriptas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_listaMateriasTotales;
        private System.Windows.Forms.Label lbl_elija;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativas;
    }
}
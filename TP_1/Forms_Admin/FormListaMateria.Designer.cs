namespace TP_1
{
    partial class form_listaMaterias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_listaMateria = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_CSV = new System.Windows.Forms.Button();
            this.btn_Json = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(364, 44);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(330, 32);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "LISTA DE MATERIAS:";
            // 
            // dgv_listaMateria
            // 
            this.dgv_listaMateria.AllowUserToAddRows = false;
            this.dgv_listaMateria.AllowUserToResizeColumns = false;
            this.dgv_listaMateria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listaMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_listaMateria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_listaMateria.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listaMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listaMateria.ColumnHeadersHeight = 29;
            this.dgv_listaMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Profesores,
            this.Alumnos,
            this.Cuatrimestre,
            this.Correlativas,
            this.Carrera,
            this.Anio});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_listaMateria.Location = new System.Drawing.Point(37, 112);
            this.dgv_listaMateria.MultiSelect = false;
            this.dgv_listaMateria.Name = "dgv_listaMateria";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_listaMateria.RowHeadersVisible = false;
            this.dgv_listaMateria.RowHeadersWidth = 55;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_listaMateria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
            this.dgv_listaMateria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_listaMateria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_listaMateria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_listaMateria.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.RowTemplate.Height = 30;
            this.dgv_listaMateria.RowTemplate.ReadOnly = true;
            this.dgv_listaMateria.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listaMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaMateria.ShowEditingIcon = false;
            this.dgv_listaMateria.Size = new System.Drawing.Size(941, 392);
            this.dgv_listaMateria.StandardTab = true;
            this.dgv_listaMateria.TabIndex = 1;
            this.dgv_listaMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaMateria_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Profesores
            // 
            this.Profesores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Profesores.DefaultCellStyle = dataGridViewCellStyle4;
            this.Profesores.HeaderText = "PROFESORES";
            this.Profesores.MinimumWidth = 6;
            this.Profesores.Name = "Profesores";
            this.Profesores.Width = 125;
            // 
            // Alumnos
            // 
            this.Alumnos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Alumnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Alumnos.HeaderText = "ALUMNOS";
            this.Alumnos.MinimumWidth = 6;
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Width = 108;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cuatrimestre.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cuatrimestre.HeaderText = "CUATRIMESTRE";
            this.Cuatrimestre.MinimumWidth = 6;
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.Width = 141;
            // 
            // Correlativas
            // 
            this.Correlativas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Correlativas.DefaultCellStyle = dataGridViewCellStyle7;
            this.Correlativas.HeaderText = "CORRELATIVAS";
            this.Correlativas.MinimumWidth = 6;
            this.Correlativas.Name = "Correlativas";
            this.Correlativas.Width = 138;
            // 
            // Carrera
            // 
            this.Carrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Carrera.DefaultCellStyle = dataGridViewCellStyle8;
            this.Carrera.HeaderText = "CARRERA";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            // 
            // Anio
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Anio.DefaultCellStyle = dataGridViewCellStyle9;
            this.Anio.HeaderText = "AÑO";
            this.Anio.MinimumWidth = 6;
            this.Anio.Name = "Anio";
            this.Anio.Width = 70;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(37, 546);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(170, 69);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(808, 546);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(170, 69);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_CSV
            // 
            this.btn_CSV.BackColor = System.Drawing.Color.DarkRed;
            this.btn_CSV.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CSV.ForeColor = System.Drawing.Color.White;
            this.btn_CSV.Location = new System.Drawing.Point(295, 546);
            this.btn_CSV.Name = "btn_CSV";
            this.btn_CSV.Size = new System.Drawing.Size(170, 69);
            this.btn_CSV.TabIndex = 9;
            this.btn_CSV.Text = "Exportar CSV";
            this.btn_CSV.UseVisualStyleBackColor = false;
            this.btn_CSV.Click += new System.EventHandler(this.btn_CSV_Click);
            // 
            // btn_Json
            // 
            this.btn_Json.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Json.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Json.ForeColor = System.Drawing.Color.White;
            this.btn_Json.Location = new System.Drawing.Point(556, 546);
            this.btn_Json.Name = "btn_Json";
            this.btn_Json.Size = new System.Drawing.Size(170, 69);
            this.btn_Json.TabIndex = 9;
            this.btn_Json.Text = "Exportar Json";
            this.btn_Json.UseVisualStyleBackColor = false;
            this.btn_Json.Click += new System.EventHandler(this.btn_Json_Click);
            // 
            // form_listaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.ClientSize = new System.Drawing.Size(1016, 659);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Json);
            this.Controls.Add(this.btn_CSV);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_listaMateria);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_listaMaterias";
            this.Text = "Lista de Materias (Perfil Admin)";
            this.Load += new System.EventHandler(this.FormListaMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_listaMateria;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_CSV;
        private System.Windows.Forms.Button btn_Json;
    }
}
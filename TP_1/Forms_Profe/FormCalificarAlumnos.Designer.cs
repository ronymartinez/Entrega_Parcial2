namespace TP_1
{
    partial class form_calificarAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_listadoAlumnos = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(468, 497);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(142, 71);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click_1);
            // 
            // dgv_listadoAlumnos
            // 
            this.dgv_listadoAlumnos.AllowUserToAddRows = false;
            this.dgv_listadoAlumnos.AllowUserToDeleteRows = false;
            this.dgv_listadoAlumnos.AllowUserToResizeColumns = false;
            this.dgv_listadoAlumnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listadoAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_listadoAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listadoAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_listadoAlumnos.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgv_listadoAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_listadoAlumnos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listadoAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listadoAlumnos.ColumnHeadersHeight = 29;
            this.dgv_listadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listadoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.Alumnos,
            this.Correlativas,
            this.Promedio,
            this.Asistencia,
            this.Aprobacion});
            this.dgv_listadoAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_listadoAlumnos.EnableHeadersVisualStyles = false;
            this.dgv_listadoAlumnos.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgv_listadoAlumnos.Location = new System.Drawing.Point(12, 93);
            this.dgv_listadoAlumnos.MultiSelect = false;
            this.dgv_listadoAlumnos.Name = "dgv_listadoAlumnos";
            this.dgv_listadoAlumnos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_listadoAlumnos.RowHeadersVisible = false;
            this.dgv_listadoAlumnos.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowTemplate.Height = 29;
            this.dgv_listadoAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listadoAlumnos.ShowEditingIcon = false;
            this.dgv_listadoAlumnos.Size = new System.Drawing.Size(1101, 373);
            this.dgv_listadoAlumnos.TabIndex = 11;
            this.dgv_listadoAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoAlumnos_CellClick);
            // 
            // Materia
            // 
            this.Materia.HeaderText = "MATERIA";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Legajo.HeaderText = "LEGAJO";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 90;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 99;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle4;
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 104;
            // 
            // Alumnos
            // 
            this.Alumnos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Alumnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Alumnos.HeaderText = "NOTA PP";
            this.Alumnos.MinimumWidth = 6;
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.ReadOnly = true;
            this.Alumnos.Width = 96;
            // 
            // Correlativas
            // 
            this.Correlativas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Correlativas.DefaultCellStyle = dataGridViewCellStyle6;
            this.Correlativas.HeaderText = "NOTA SP";
            this.Correlativas.MinimumWidth = 6;
            this.Correlativas.Name = "Correlativas";
            this.Correlativas.ReadOnly = true;
            this.Correlativas.Width = 96;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "PROMEDIO";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Nº ASISTENCIAS";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            // 
            // Aprobacion
            // 
            this.Aprobacion.HeaderText = "APROBACIÓN";
            this.Aprobacion.MinimumWidth = 6;
            this.Aprobacion.Name = "Aprobacion";
            this.Aprobacion.ReadOnly = true;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(699, 497);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(146, 71);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_modificar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(222, 497);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(146, 71);
            this.btn_modificar.TabIndex = 14;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(356, 34);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(420, 32);
            this.lbl_titulo.TabIndex = 23;
            this.lbl_titulo.Text = "Lista de Alumnos a su Cargo:";
            // 
            // form_calificarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_profe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 594);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_listadoAlumnos);
            this.Name = "form_calificarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar Alumnos (Perfil: Profesor)";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_listadoAlumnos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobacion;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
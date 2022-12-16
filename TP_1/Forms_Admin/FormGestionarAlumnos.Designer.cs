namespace TP_1
{
    partial class form_gestionarAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_listadoAlumnos = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regularidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_indicaciones = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(481, 609);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(203, 77);
            this.btn_volver.TabIndex = 18;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
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
            this.dgv_listadoAlumnos.BackgroundColor = System.Drawing.Color.DarkRed;
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
            this.Promedio,
            this.Asistencia,
            this.Regularidad,
            this.Aprobacion});
            this.dgv_listadoAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_listadoAlumnos.EnableHeadersVisualStyles = false;
            this.dgv_listadoAlumnos.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgv_listadoAlumnos.Location = new System.Drawing.Point(29, 113);
            this.dgv_listadoAlumnos.MultiSelect = false;
            this.dgv_listadoAlumnos.Name = "dgv_listadoAlumnos";
            this.dgv_listadoAlumnos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_listadoAlumnos.RowHeadersVisible = false;
            this.dgv_listadoAlumnos.RowHeadersWidth = 51;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_listadoAlumnos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.RowTemplate.Height = 29;
            this.dgv_listadoAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listadoAlumnos.ShowEditingIcon = false;
            this.dgv_listadoAlumnos.Size = new System.Drawing.Size(1101, 442);
            this.dgv_listadoAlumnos.TabIndex = 17;
            this.dgv_listadoAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoAlumnos_CellClick);
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Materia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Materia.HeaderText = "MATERIA";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 99;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 99;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 104;
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
            this.Asistencia.HeaderText = "Nº ASISTENCIA";
            this.Asistencia.MinimumWidth = 6;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            // 
            // Regularidad
            // 
            this.Regularidad.HeaderText = "REGULARIDAD";
            this.Regularidad.MinimumWidth = 6;
            this.Regularidad.Name = "Regularidad";
            this.Regularidad.ReadOnly = true;
            // 
            // Aprobacion
            // 
            this.Aprobacion.HeaderText = "APROBACIÓN";
            this.Aprobacion.MinimumWidth = 6;
            this.Aprobacion.Name = "Aprobacion";
            this.Aprobacion.ReadOnly = true;
            // 
            // lbl_indicaciones
            // 
            this.lbl_indicaciones.AutoSize = true;
            this.lbl_indicaciones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_indicaciones.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_indicaciones.Location = new System.Drawing.Point(363, 41);
            this.lbl_indicaciones.Name = "lbl_indicaciones";
            this.lbl_indicaciones.Size = new System.Drawing.Size(447, 32);
            this.lbl_indicaciones.TabIndex = 22;
            this.lbl_indicaciones.Text = "Listado Completo de Alumnos:";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_modificar.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.Location = new System.Drawing.Point(219, 609);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(203, 77);
            this.btn_modificar.TabIndex = 23;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(744, 609);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(203, 77);
            this.btn_salir.TabIndex = 24;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // form_gestionarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 717);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_indicaciones);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_listadoAlumnos);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "form_gestionarAlumnos";
            this.Text = "Gestionar Alumnos (Perfil Admin)";
            this.Load += new System.EventHandler(this.form_gestionarAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_listadoAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regularidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aprobacion;
        private System.Windows.Forms.Label lbl_indicaciones;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_salir;
    }
}
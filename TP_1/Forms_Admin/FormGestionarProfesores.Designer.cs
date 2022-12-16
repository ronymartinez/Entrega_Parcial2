namespace TP_1
{
    partial class form_gestionarProfesores
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_listadoProfes = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoProfes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(777, 577);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(203, 77);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_modificar.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(130, 574);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(203, 77);
            this.btn_modificar.TabIndex = 28;
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
            this.lbl_titulo.Location = new System.Drawing.Point(332, 50);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(470, 32);
            this.lbl_titulo.TabIndex = 27;
            this.lbl_titulo.Text = "Listado Completo de Profesores:";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(466, 574);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(203, 77);
            this.btn_volver.TabIndex = 26;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dgv_listadoProfes
            // 
            this.dgv_listadoProfes.AllowUserToAddRows = false;
            this.dgv_listadoProfes.AllowUserToDeleteRows = false;
            this.dgv_listadoProfes.AllowUserToResizeColumns = false;
            this.dgv_listadoProfes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoProfes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_listadoProfes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_listadoProfes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listadoProfes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_listadoProfes.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dgv_listadoProfes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_listadoProfes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_listadoProfes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_listadoProfes.ColumnHeadersHeight = 29;
            this.dgv_listadoProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_listadoProfes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Usuario,
            this.Nombre,
            this.Apellido,
            this.Materia});
            this.dgv_listadoProfes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_listadoProfes.EnableHeadersVisualStyles = false;
            this.dgv_listadoProfes.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgv_listadoProfes.Location = new System.Drawing.Point(44, 124);
            this.dgv_listadoProfes.MultiSelect = false;
            this.dgv_listadoProfes.Name = "dgv_listadoProfes";
            this.dgv_listadoProfes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoProfes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_listadoProfes.RowHeadersVisible = false;
            this.dgv_listadoProfes.RowHeadersWidth = 51;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoProfes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_listadoProfes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoProfes.RowTemplate.Height = 29;
            this.dgv_listadoProfes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_listadoProfes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listadoProfes.ShowEditingIcon = false;
            this.dgv_listadoProfes.Size = new System.Drawing.Size(1101, 395);
            this.dgv_listadoProfes.TabIndex = 25;
            this.dgv_listadoProfes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoProfes_CellClick);
            // 
            // Legajo
            // 
            this.Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Legajo.HeaderText = "LEGAJO";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.HeaderText = "USUARIO";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle4;
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Materia.DefaultCellStyle = dataGridViewCellStyle5;
            this.Materia.HeaderText = "MATERIAS";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // form_gestionarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 721);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_listadoProfes);
            this.Name = "form_gestionarProfesores";
            this.Text = "Gestionar datos de Profesores (Perfil Admin)";
            this.Load += new System.EventHandler(this.FormGestionarProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoProfes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_listadoProfes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
    }
}
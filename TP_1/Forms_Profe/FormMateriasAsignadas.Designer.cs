namespace TP_1
{
    partial class form_materiasAsignadas
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
            this.dgv_materiasAsignadas = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_materia = new System.Windows.Forms.ComboBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasAsignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_materiasAsignadas
            // 
            this.dgv_materiasAsignadas.AllowUserToAddRows = false;
            this.dgv_materiasAsignadas.AllowUserToDeleteRows = false;
            this.dgv_materiasAsignadas.AllowUserToResizeColumns = false;
            this.dgv_materiasAsignadas.AllowUserToResizeRows = false;
            this.dgv_materiasAsignadas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_materiasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_materiasAsignadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_materiasAsignadas.BackgroundColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_materiasAsignadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_materiasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiasAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasAsignadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_materiasAsignadas.Location = new System.Drawing.Point(125, 140);
            this.dgv_materiasAsignadas.MultiSelect = false;
            this.dgv_materiasAsignadas.Name = "dgv_materiasAsignadas";
            this.dgv_materiasAsignadas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasAsignadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_materiasAsignadas.RowHeadersWidth = 51;
            this.dgv_materiasAsignadas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dgv_materiasAsignadas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_materiasAsignadas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.dgv_materiasAsignadas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_materiasAsignadas.RowTemplate.Height = 29;
            this.dgv_materiasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materiasAsignadas.ShowEditingIcon = false;
            this.dgv_materiasAsignadas.Size = new System.Drawing.Size(610, 242);
            this.dgv_materiasAsignadas.TabIndex = 0;
            // 
            // Legajo
            // 
            this.Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Legajo.HeaderText = "LEGAJO";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "NOMBRE ALUMNO";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.HeaderText = "APELLIDO ALUMNO";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // combo_materia
            // 
            this.combo_materia.FormattingEnabled = true;
            this.combo_materia.Location = new System.Drawing.Point(228, 47);
            this.combo_materia.Name = "combo_materia";
            this.combo_materia.Size = new System.Drawing.Size(409, 28);
            this.combo_materia.TabIndex = 1;
            this.combo_materia.Text = "Selecciona la materia";
            this.combo_materia.SelectedIndexChanged += new System.EventHandler(this.combo_materia_SelectedIndexChanged);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(196, 449);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(182, 48);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(455, 449);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(182, 48);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // form_materiasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_profe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 550);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.combo_materia);
            this.Controls.Add(this.dgv_materiasAsignadas);
            this.Name = "form_materiasAsignadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias Asignadas (Perfil:  Profesor)";
            this.Load += new System.EventHandler(this.VerMateriasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasAsignadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_materiasAsignadas;
        private System.Windows.Forms.ComboBox combo_materia;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button btn_salir;
    }
}

namespace TP_1
{
    partial class form_estadisticas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_estadisticas = new System.Windows.Forms.Label();
            this.dgv_estadisticas = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscriptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_estadisticas2 = new System.Windows.Forms.DataGridView();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_estadisticas3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AutoSize = true;
            this.lbl_estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas.ForeColor = System.Drawing.Color.White;
            this.lbl_estadisticas.Location = new System.Drawing.Point(444, 28);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(191, 32);
            this.lbl_estadisticas.TabIndex = 1;
            this.lbl_estadisticas.Text = "Estadísticas:";
            // 
            // dgv_estadisticas
            // 
            this.dgv_estadisticas.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estadisticas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Inscriptos,
            this.Promedio2});
            this.dgv_estadisticas.Enabled = false;
            this.dgv_estadisticas.EnableHeadersVisualStyles = false;
            this.dgv_estadisticas.Location = new System.Drawing.Point(21, 86);
            this.dgv_estadisticas.Name = "dgv_estadisticas";
            this.dgv_estadisticas.ReadOnly = true;
            this.dgv_estadisticas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_estadisticas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkRed;
            this.dgv_estadisticas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_estadisticas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas.RowTemplate.Height = 29;
            this.dgv_estadisticas.Size = new System.Drawing.Size(337, 352);
            this.dgv_estadisticas.TabIndex = 2;
            // 
            // Materia
            // 
            this.Materia.HeaderText = "MATERIA";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 125;
            // 
            // Inscriptos
            // 
            this.Inscriptos.HeaderText = "CANTIDAD DE INSCRIPTOS";
            this.Inscriptos.MinimumWidth = 6;
            this.Inscriptos.Name = "Inscriptos";
            this.Inscriptos.ReadOnly = true;
            this.Inscriptos.Width = 125;
            // 
            // Promedio2
            // 
            this.Promedio2.HeaderText = "NOTA PROMEDIO";
            this.Promedio2.MinimumWidth = 6;
            this.Promedio2.Name = "Promedio2";
            this.Promedio2.ReadOnly = true;
            this.Promedio2.Width = 125;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(357, 481);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(159, 67);
            this.btn_volver.TabIndex = 3;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(583, 481);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(159, 67);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_estadisticas2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_estadisticas2.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estadisticas2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_estadisticas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadisticas2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Profesor,
            this.CantAlumno});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estadisticas2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_estadisticas2.Enabled = false;
            this.dgv_estadisticas2.Location = new System.Drawing.Point(393, 86);
            this.dgv_estadisticas2.Name = "dgv_estadisticas2";
            this.dgv_estadisticas2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estadisticas2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_estadisticas2.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas2.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_estadisticas2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgv_estadisticas2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_estadisticas2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas2.RowTemplate.Height = 29;
            this.dgv_estadisticas2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estadisticas2.Size = new System.Drawing.Size(347, 352);
            this.dgv_estadisticas2.TabIndex = 5;
            // 
            // Profesor
            // 
            this.Profesor.HeaderText = "PROFESOR";
            this.Profesor.MinimumWidth = 6;
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 125;
            // 
            // CantAlumno
            // 
            this.CantAlumno.HeaderText = "CANTIDAD DE ALUMNOS";
            this.CantAlumno.MinimumWidth = 6;
            this.CantAlumno.Name = "CantAlumno";
            this.CantAlumno.ReadOnly = true;
            this.CantAlumno.Width = 125;
            // 
            // dgv_estadisticas3
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_estadisticas3.BackgroundColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estadisticas3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_estadisticas3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estadisticas3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estadisticas3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_estadisticas3.Enabled = false;
            this.dgv_estadisticas3.Location = new System.Drawing.Point(773, 86);
            this.dgv_estadisticas3.Name = "dgv_estadisticas3";
            this.dgv_estadisticas3.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estadisticas3.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_estadisticas3.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas3.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_estadisticas3.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgv_estadisticas3.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_estadisticas3.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_estadisticas3.RowTemplate.Height = 29;
            this.dgv_estadisticas3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estadisticas3.Size = new System.Drawing.Size(363, 352);
            this.dgv_estadisticas3.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ALUMNO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PROMEDIO TOTAL";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // form_estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 574);
            this.Controls.Add(this.dgv_estadisticas3);
            this.Controls.Add(this.dgv_estadisticas2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dgv_estadisticas);
            this.Controls.Add(this.lbl_estadisticas);
            this.Name = "form_estadisticas";
            this.Text = "Estadísticas (Perfil Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadisticas3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estadisticas;
        private System.Windows.Forms.DataGridView dgv_estadisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscriptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_estadisticas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantAlumno;
        private System.Windows.Forms.DataGridView dgv_estadisticas3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
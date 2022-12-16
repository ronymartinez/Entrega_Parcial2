
namespace TP_1
{
    partial class form_asistencia
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
            this.dgv_materiasEnCurso = new System.Windows.Forms.DataGridView();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asitencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_DarPresente = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasEnCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_materiasEnCurso
            // 
            this.dgv_materiasEnCurso.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasEnCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_materiasEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materiasEnCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Estado,
            this.Asitencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasEnCurso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_materiasEnCurso.GridColor = System.Drawing.Color.Black;
            this.dgv_materiasEnCurso.Location = new System.Drawing.Point(56, 93);
            this.dgv_materiasEnCurso.Name = "dgv_materiasEnCurso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasEnCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_materiasEnCurso.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_materiasEnCurso.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_materiasEnCurso.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SlateBlue;
            this.dgv_materiasEnCurso.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_materiasEnCurso.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_materiasEnCurso.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_materiasEnCurso.RowTemplate.Height = 29;
            this.dgv_materiasEnCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materiasEnCurso.Size = new System.Drawing.Size(686, 195);
            this.dgv_materiasEnCurso.TabIndex = 0;
            this.dgv_materiasEnCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_materiasEnCurso_CellClick);
            // 
            // Materia
            // 
            this.Materia.HeaderText = "MATERIA";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Asitencia
            // 
            this.Asitencia.HeaderText = "ASISTENCIA";
            this.Asitencia.MinimumWidth = 6;
            this.Asitencia.Name = "Asitencia";
            this.Asitencia.Width = 125;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(299, 35);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(228, 26);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Materias en Curso:";
            // 
            // btn_DarPresente
            // 
            this.btn_DarPresente.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_DarPresente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DarPresente.FlatAppearance.BorderSize = 3;
            this.btn_DarPresente.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DarPresente.ForeColor = System.Drawing.Color.White;
            this.btn_DarPresente.Location = new System.Drawing.Point(109, 340);
            this.btn_DarPresente.Name = "btn_DarPresente";
            this.btn_DarPresente.Size = new System.Drawing.Size(148, 57);
            this.btn_DarPresente.TabIndex = 3;
            this.btn_DarPresente.Text = "Dar presente";
            this.btn_DarPresente.UseVisualStyleBackColor = false;
            this.btn_DarPresente.Click += new System.EventHandler(this.btn_DarPresente_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(309, 340);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(148, 57);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(513, 340);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(148, 57);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo2.Location = new System.Drawing.Point(79, 35);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(663, 26);
            this.lbl_titulo2.TabIndex = 1;
            this.lbl_titulo2.Text = "Actualmente no se encuentra cursando ninguna materia";
            // 
            // form_asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_DarPresente);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgv_materiasEnCurso);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "form_asistencia";
            this.Text = "Dar Asistencia (Perfil Alumno)";
            this.Load += new System.EventHandler(this.FormAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasEnCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_materiasEnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asitencia;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_DarPresente;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo2;
    }
}
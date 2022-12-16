namespace TP_1
{
    partial class form_Profe
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
            this.btn_calificarAlumnos = new System.Windows.Forms.Button();
            this.btn_crearExamen = new System.Windows.Forms.Button();
            this.btn_verMaterias = new System.Windows.Forms.Button();
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.btn_listaExamenes = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cargarAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calificarAlumnos
            // 
            this.btn_calificarAlumnos.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_calificarAlumnos.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calificarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btn_calificarAlumnos.Location = new System.Drawing.Point(509, 133);
            this.btn_calificarAlumnos.Name = "btn_calificarAlumnos";
            this.btn_calificarAlumnos.Size = new System.Drawing.Size(198, 64);
            this.btn_calificarAlumnos.TabIndex = 2;
            this.btn_calificarAlumnos.Text = "Calificar alumnos";
            this.btn_calificarAlumnos.UseVisualStyleBackColor = false;
            this.btn_calificarAlumnos.Click += new System.EventHandler(this.btn_calificarAlumnos_Click);
            // 
            // btn_crearExamen
            // 
            this.btn_crearExamen.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_crearExamen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_crearExamen.ForeColor = System.Drawing.Color.White;
            this.btn_crearExamen.Location = new System.Drawing.Point(509, 28);
            this.btn_crearExamen.Name = "btn_crearExamen";
            this.btn_crearExamen.Size = new System.Drawing.Size(198, 64);
            this.btn_crearExamen.TabIndex = 3;
            this.btn_crearExamen.Text = "Crear examen";
            this.btn_crearExamen.UseVisualStyleBackColor = false;
            this.btn_crearExamen.Click += new System.EventHandler(this.btn_crearExamen_Click);
            // 
            // btn_verMaterias
            // 
            this.btn_verMaterias.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_verMaterias.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verMaterias.ForeColor = System.Drawing.Color.White;
            this.btn_verMaterias.Location = new System.Drawing.Point(509, 242);
            this.btn_verMaterias.Name = "btn_verMaterias";
            this.btn_verMaterias.Size = new System.Drawing.Size(198, 64);
            this.btn_verMaterias.TabIndex = 4;
            this.btn_verMaterias.Text = "Ver materias asignadas";
            this.btn_verMaterias.UseVisualStyleBackColor = false;
            this.btn_verMaterias.Click += new System.EventHandler(this.btn_verMaterias_Click);
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pregunta.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pregunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pregunta.Location = new System.Drawing.Point(41, 228);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(311, 32);
            this.lbl_pregunta.TabIndex = 6;
            this.lbl_pregunta.Text = "¿Qué deseas realizar?";
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenida.Location = new System.Drawing.Point(57, 68);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(243, 35);
            this.lbl_bienvenida.TabIndex = 5;
            this.lbl_bienvenida.Text = "¡Hola, Nombre!";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_listaExamenes
            // 
            this.btn_listaExamenes.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_listaExamenes.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_listaExamenes.ForeColor = System.Drawing.Color.White;
            this.btn_listaExamenes.Location = new System.Drawing.Point(509, 345);
            this.btn_listaExamenes.Name = "btn_listaExamenes";
            this.btn_listaExamenes.Size = new System.Drawing.Size(198, 64);
            this.btn_listaExamenes.TabIndex = 4;
            this.btn_listaExamenes.Text = "Ver lista de exámenes";
            this.btn_listaExamenes.UseVisualStyleBackColor = false;
            this.btn_listaExamenes.Click += new System.EventHandler(this.btn_listaExamenes_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(41, 345);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(198, 64);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_cargarAlumnos
            // 
            this.btn_cargarAlumnos.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cargarAlumnos.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cargarAlumnos.ForeColor = System.Drawing.Color.White;
            this.btn_cargarAlumnos.Location = new System.Drawing.Point(276, 345);
            this.btn_cargarAlumnos.Name = "btn_cargarAlumnos";
            this.btn_cargarAlumnos.Size = new System.Drawing.Size(198, 64);
            this.btn_cargarAlumnos.TabIndex = 4;
            this.btn_cargarAlumnos.Text = "Cargar Alumnos (BBDD)";
            this.btn_cargarAlumnos.UseVisualStyleBackColor = false;
            this.btn_cargarAlumnos.Click += new System.EventHandler(this.btn_cargarAlumnos_Click);
            // 
            // form_Profe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_profe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_pregunta);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.btn_calificarAlumnos);
            this.Controls.Add(this.btn_crearExamen);
            this.Controls.Add(this.btn_cargarAlumnos);
            this.Controls.Add(this.btn_listaExamenes);
            this.Controls.Add(this.btn_verMaterias);
            this.Name = "form_Profe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Profe_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_calificarAlumnos;
        private System.Windows.Forms.Button btn_crearExamen;
        private System.Windows.Forms.Button btn_verMaterias;
        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Button btn_listaExamenes;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cargarAlumnos;
    }
}
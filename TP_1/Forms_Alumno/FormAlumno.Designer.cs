namespace TP_1
{
    partial class form_alumno
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
            this.btn_darAsistencia = new System.Windows.Forms.Button();
            this.btn_inscripcionMaterias = new System.Windows.Forms.Button();
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_verMaterias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_darAsistencia
            // 
            this.btn_darAsistencia.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_darAsistencia.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_darAsistencia.ForeColor = System.Drawing.Color.White;
            this.btn_darAsistencia.Location = new System.Drawing.Point(372, 122);
            this.btn_darAsistencia.Name = "btn_darAsistencia";
            this.btn_darAsistencia.Size = new System.Drawing.Size(272, 68);
            this.btn_darAsistencia.TabIndex = 5;
            this.btn_darAsistencia.Text = "Dar asistencia";
            this.btn_darAsistencia.UseVisualStyleBackColor = false;
            this.btn_darAsistencia.Click += new System.EventHandler(this.btn_darAsistencia_Click);
            // 
            // btn_inscripcionMaterias
            // 
            this.btn_inscripcionMaterias.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_inscripcionMaterias.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inscripcionMaterias.ForeColor = System.Drawing.Color.White;
            this.btn_inscripcionMaterias.Location = new System.Drawing.Point(372, 33);
            this.btn_inscripcionMaterias.Name = "btn_inscripcionMaterias";
            this.btn_inscripcionMaterias.Size = new System.Drawing.Size(272, 68);
            this.btn_inscripcionMaterias.TabIndex = 6;
            this.btn_inscripcionMaterias.Text = "Inscripción a Materias";
            this.btn_inscripcionMaterias.UseVisualStyleBackColor = false;
            this.btn_inscripcionMaterias.Click += new System.EventHandler(this.btn_inscripcionMaterias_Click);
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pregunta.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pregunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pregunta.Location = new System.Drawing.Point(41, 271);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(256, 26);
            this.lbl_pregunta.TabIndex = 9;
            this.lbl_pregunta.Text = "¿Qué deseas realizar?";
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenida.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenida.ForeColor = System.Drawing.Color.White;
            this.lbl_bienvenida.Location = new System.Drawing.Point(41, 91);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(147, 70);
            this.lbl_bienvenida.TabIndex = 8;
            this.lbl_bienvenida.Text = "¡Hola,\r\nNombre!";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(372, 304);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(272, 68);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_verMaterias
            // 
            this.btn_verMaterias.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_verMaterias.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verMaterias.ForeColor = System.Drawing.Color.White;
            this.btn_verMaterias.Location = new System.Drawing.Point(372, 214);
            this.btn_verMaterias.Name = "btn_verMaterias";
            this.btn_verMaterias.Size = new System.Drawing.Size(272, 68);
            this.btn_verMaterias.TabIndex = 5;
            this.btn_verMaterias.Text = "Cargar Materias (BB))";
            this.btn_verMaterias.UseVisualStyleBackColor = false;
            this.btn_verMaterias.Click += new System.EventHandler(this.btn_verMaterias_Click);
            // 
            // form_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 396);
            this.Controls.Add(this.lbl_pregunta);
            this.Controls.Add(this.lbl_bienvenida);
            this.Controls.Add(this.btn_verMaterias);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_darAsistencia);
            this.Controls.Add(this.btn_inscripcionMaterias);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_alumno_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_darAsistencia;
        private System.Windows.Forms.Button btn_inscripcionMaterias;
        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_verMaterias;
    }
}
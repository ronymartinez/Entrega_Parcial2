namespace TP_1
{
    partial class form_EditarCalificaciones
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.domain_asistencia = new System.Windows.Forms.DomainUpDown();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.domain_nota1 = new System.Windows.Forms.DomainUpDown();
            this.domain_nota2 = new System.Windows.Forms.DomainUpDown();
            this.lbl_nota1 = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.lbl_libre = new System.Windows.Forms.Label();
            this.lbl_regular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(723, 548);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(256, 82);
            this.btn_salir.TabIndex = 29;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.Location = new System.Drawing.Point(396, 548);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(256, 82);
            this.btn_volver.TabIndex = 28;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_aceptar.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(79, 548);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(256, 82);
            this.btn_aceptar.TabIndex = 27;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // domain_asistencia
            // 
            this.domain_asistencia.Items.Add("20");
            this.domain_asistencia.Items.Add("19");
            this.domain_asistencia.Items.Add("18");
            this.domain_asistencia.Items.Add("17");
            this.domain_asistencia.Items.Add("16");
            this.domain_asistencia.Items.Add("15");
            this.domain_asistencia.Items.Add("14");
            this.domain_asistencia.Items.Add("13");
            this.domain_asistencia.Items.Add("12");
            this.domain_asistencia.Items.Add("11");
            this.domain_asistencia.Items.Add("10");
            this.domain_asistencia.Items.Add("9");
            this.domain_asistencia.Items.Add("8");
            this.domain_asistencia.Items.Add("7");
            this.domain_asistencia.Items.Add("6");
            this.domain_asistencia.Items.Add("5");
            this.domain_asistencia.Items.Add("4");
            this.domain_asistencia.Items.Add("3");
            this.domain_asistencia.Items.Add("2");
            this.domain_asistencia.Items.Add("1");
            this.domain_asistencia.Items.Add("0");
            this.domain_asistencia.Items.Add("Aun no inicia");
            this.domain_asistencia.Location = new System.Drawing.Point(385, 394);
            this.domain_asistencia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.domain_asistencia.Name = "domain_asistencia";
            this.domain_asistencia.Size = new System.Drawing.Size(334, 30);
            this.domain_asistencia.TabIndex = 26;
            this.domain_asistencia.Text = "Asistencia";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(681, 100);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(302, 30);
            this.txt_apellido.TabIndex = 25;
            this.txt_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(681, 43);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(302, 30);
            this.txt_nombre.TabIndex = 24;
            this.txt_nombre.Text = "Nombre";
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_asistencia.Location = new System.Drawing.Point(464, 354);
            this.lbl_asistencia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(152, 23);
            this.lbl_asistencia.TabIndex = 21;
            this.lbl_asistencia.Text = "Nº Asistencia:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Location = new System.Drawing.Point(560, 105);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(103, 23);
            this.lbl_apellido.TabIndex = 20;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Location = new System.Drawing.Point(564, 48);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(99, 23);
            this.lbl_nombre.TabIndex = 19;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Location = new System.Drawing.Point(140, 99);
            this.txt_legajo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(314, 30);
            this.txt_legajo.TabIndex = 18;
            this.txt_legajo.Text = "Legajo";
            // 
            // txt_materia
            // 
            this.txt_materia.Enabled = false;
            this.txt_materia.Location = new System.Drawing.Point(140, 43);
            this.txt_materia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(314, 30);
            this.txt_materia.TabIndex = 17;
            this.txt_materia.Text = "Materia";
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_legajo.Location = new System.Drawing.Point(34, 103);
            this.lbl_legajo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(82, 23);
            this.lbl_legajo.TabIndex = 14;
            this.lbl_legajo.Text = "Legajo:";
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materia.Location = new System.Drawing.Point(24, 47);
            this.lbl_materia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(94, 23);
            this.lbl_materia.TabIndex = 13;
            this.lbl_materia.Text = "Materia:";
            // 
            // domain_nota1
            // 
            this.domain_nota1.Items.Add("10");
            this.domain_nota1.Items.Add("9");
            this.domain_nota1.Items.Add("8");
            this.domain_nota1.Items.Add("7");
            this.domain_nota1.Items.Add("6");
            this.domain_nota1.Items.Add("5");
            this.domain_nota1.Items.Add("4");
            this.domain_nota1.Items.Add("3");
            this.domain_nota1.Items.Add("2");
            this.domain_nota1.Items.Add("1");
            this.domain_nota1.Items.Add(" ");
            this.domain_nota1.Location = new System.Drawing.Point(138, 257);
            this.domain_nota1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.domain_nota1.Name = "domain_nota1";
            this.domain_nota1.Size = new System.Drawing.Size(317, 30);
            this.domain_nota1.TabIndex = 30;
            // 
            // domain_nota2
            // 
            this.domain_nota2.Items.Add("10");
            this.domain_nota2.Items.Add("9");
            this.domain_nota2.Items.Add("8");
            this.domain_nota2.Items.Add("7");
            this.domain_nota2.Items.Add("6");
            this.domain_nota2.Items.Add("5");
            this.domain_nota2.Items.Add("4");
            this.domain_nota2.Items.Add("3");
            this.domain_nota2.Items.Add("2");
            this.domain_nota2.Items.Add("1");
            this.domain_nota2.Items.Add(" ");
            this.domain_nota2.Location = new System.Drawing.Point(697, 257);
            this.domain_nota2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.domain_nota2.Name = "domain_nota2";
            this.domain_nota2.Size = new System.Drawing.Size(286, 30);
            this.domain_nota2.TabIndex = 31;
            // 
            // lbl_nota1
            // 
            this.lbl_nota1.AutoSize = true;
            this.lbl_nota1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nota1.Location = new System.Drawing.Point(17, 266);
            this.lbl_nota1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nota1.Name = "lbl_nota1";
            this.lbl_nota1.Size = new System.Drawing.Size(98, 23);
            this.lbl_nota1.TabIndex = 32;
            this.lbl_nota1.Text = "Nota PP:";
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nota2.Location = new System.Drawing.Point(572, 264);
            this.lbl_nota2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(97, 23);
            this.lbl_nota2.TabIndex = 33;
            this.lbl_nota2.Text = "Nota SP:";
            // 
            // lbl_libre
            // 
            this.lbl_libre.AutoSize = true;
            this.lbl_libre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_libre.Location = new System.Drawing.Point(464, 477);
            this.lbl_libre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_libre.Name = "lbl_libre";
            this.lbl_libre.Size = new System.Drawing.Size(144, 23);
            this.lbl_libre.TabIndex = 34;
            this.lbl_libre.Text = "1 a 14 = Libre";
            // 
            // lbl_regular
            // 
            this.lbl_regular.AutoSize = true;
            this.lbl_regular.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regular.Location = new System.Drawing.Point(448, 447);
            this.lbl_regular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_regular.Name = "lbl_regular";
            this.lbl_regular.Size = new System.Drawing.Size(183, 23);
            this.lbl_regular.TabIndex = 35;
            this.lbl_regular.Text = "15 a 20 = Regular";
            // 
            // form_EditarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_profe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 686);
            this.Controls.Add(this.lbl_libre);
            this.Controls.Add(this.lbl_regular);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota1);
            this.Controls.Add(this.domain_nota2);
            this.Controls.Add(this.domain_nota1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.domain_asistencia);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_asistencia);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.lbl_legajo);
            this.Controls.Add(this.lbl_materia);
            this.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "form_EditarCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Calificaciones (Perfil: Profesor)";
            this.Load += new System.EventHandler(this.form_EditarCalificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DomainUpDown domain_asistencia;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.DomainUpDown domain_nota1;
        private System.Windows.Forms.DomainUpDown domain_nota2;
        private System.Windows.Forms.Label lbl_nota1;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.Label lbl_libre;
        private System.Windows.Forms.Label lbl_regular;
    }
}
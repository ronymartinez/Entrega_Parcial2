namespace TP_1
{
    partial class form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_completarAdmin = new System.Windows.Forms.Button();
            this.btn_completarProfesor = new System.Windows.Forms.Button();
            this.btn_completarAlumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(135, 154);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(245, 26);
            this.lbl_nombreUsuario.TabIndex = 0;
            this.lbl_nombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clave.ForeColor = System.Drawing.Color.White;
            this.lbl_clave.Location = new System.Drawing.Point(297, 241);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(83, 26);
            this.lbl_clave.TabIndex = 1;
            this.lbl_clave.Text = "Clave:";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(395, 156);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(191, 27);
            this.txt_nombreUsuario.TabIndex = 2;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(395, 240);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(191, 27);
            this.txt_clave.TabIndex = 3;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ingresar.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Location = new System.Drawing.Point(297, 324);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(196, 73);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_completarAdmin
            // 
            this.btn_completarAdmin.BackColor = System.Drawing.Color.DarkRed;
            this.btn_completarAdmin.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_completarAdmin.ForeColor = System.Drawing.Color.White;
            this.btn_completarAdmin.Location = new System.Drawing.Point(26, 31);
            this.btn_completarAdmin.Name = "btn_completarAdmin";
            this.btn_completarAdmin.Size = new System.Drawing.Size(229, 50);
            this.btn_completarAdmin.TabIndex = 5;
            this.btn_completarAdmin.Text = "Completar datos como Admin";
            this.btn_completarAdmin.UseVisualStyleBackColor = false;
            this.btn_completarAdmin.Click += new System.EventHandler(this.btn_completarAdmin_Click);
            // 
            // btn_completarProfesor
            // 
            this.btn_completarProfesor.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_completarProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_completarProfesor.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_completarProfesor.ForeColor = System.Drawing.Color.White;
            this.btn_completarProfesor.Location = new System.Drawing.Point(284, 31);
            this.btn_completarProfesor.Name = "btn_completarProfesor";
            this.btn_completarProfesor.Size = new System.Drawing.Size(229, 50);
            this.btn_completarProfesor.TabIndex = 5;
            this.btn_completarProfesor.Text = "Completar datos como Profesor";
            this.btn_completarProfesor.UseVisualStyleBackColor = false;
            this.btn_completarProfesor.Click += new System.EventHandler(this.btn_completarProfesor_Click);
            // 
            // btn_completarAlumno
            // 
            this.btn_completarAlumno.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_completarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_completarAlumno.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_completarAlumno.ForeColor = System.Drawing.Color.White;
            this.btn_completarAlumno.Location = new System.Drawing.Point(548, 31);
            this.btn_completarAlumno.Name = "btn_completarAlumno";
            this.btn_completarAlumno.Size = new System.Drawing.Size(229, 50);
            this.btn_completarAlumno.TabIndex = 5;
            this.btn_completarAlumno.Text = "Completar datos como Alumno";
            this.btn_completarAlumno.UseVisualStyleBackColor = false;
            this.btn_completarAlumno.Click += new System.EventHandler(this.btn_completarAlumno_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_completarAlumno);
            this.Controls.Add(this.btn_completarProfesor);
            this.Controls.Add(this.btn_completarAdmin);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_completarAdmin;
        private System.Windows.Forms.Button btn_completarProfesor;
        private System.Windows.Forms.Button btn_completarAlumno;
    }
}

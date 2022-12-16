namespace TP_1
{
    partial class form_CrearUsuario
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.radio_profesor = new System.Windows.Forms.RadioButton();
            this.radio_alumno = new System.Windows.Forms.RadioButton();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.btb_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Aceptar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(127, 458);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(157, 67);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_crearUsuario_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_Usuario.Location = new System.Drawing.Point(222, 198);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(97, 23);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(377, 198);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(178, 27);
            this.txt_usuario.TabIndex = 3;
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_clave.ForeColor = System.Drawing.Color.White;
            this.lbl_clave.Location = new System.Drawing.Point(222, 266);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(72, 23);
            this.lbl_clave.TabIndex = 1;
            this.lbl_clave.Text = "Clave:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(377, 263);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(178, 27);
            this.txt_clave.TabIndex = 4;
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.BackColor = System.Drawing.Color.Transparent;
            this.radio_admin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_admin.ForeColor = System.Drawing.Color.White;
            this.radio_admin.Location = new System.Drawing.Point(166, 350);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(184, 27);
            this.radio_admin.TabIndex = 5;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Administrador";
            this.radio_admin.UseVisualStyleBackColor = false;
            // 
            // radio_profesor
            // 
            this.radio_profesor.AutoSize = true;
            this.radio_profesor.BackColor = System.Drawing.Color.Transparent;
            this.radio_profesor.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_profesor.ForeColor = System.Drawing.Color.White;
            this.radio_profesor.Location = new System.Drawing.Point(368, 350);
            this.radio_profesor.Name = "radio_profesor";
            this.radio_profesor.Size = new System.Drawing.Size(120, 27);
            this.radio_profesor.TabIndex = 6;
            this.radio_profesor.TabStop = true;
            this.radio_profesor.Text = "Profesor";
            this.radio_profesor.UseVisualStyleBackColor = false;
            // 
            // radio_alumno
            // 
            this.radio_alumno.AutoSize = true;
            this.radio_alumno.BackColor = System.Drawing.Color.Transparent;
            this.radio_alumno.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio_alumno.ForeColor = System.Drawing.Color.White;
            this.radio_alumno.Location = new System.Drawing.Point(537, 350);
            this.radio_alumno.Name = "radio_alumno";
            this.radio_alumno.Size = new System.Drawing.Size(113, 27);
            this.radio_alumno.TabIndex = 7;
            this.radio_alumno.TabStop = true;
            this.radio_alumno.Text = "Alumno";
            this.radio_alumno.UseVisualStyleBackColor = false;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(338, 458);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(157, 67);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(222, 69);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(99, 23);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(377, 69);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 27);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(222, 133);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(103, 23);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(377, 134);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(178, 27);
            this.txt_apellido.TabIndex = 2;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // btb_salir
            // 
            this.btb_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btb_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btb_salir.ForeColor = System.Drawing.Color.White;
            this.btb_salir.Location = new System.Drawing.Point(540, 458);
            this.btb_salir.Name = "btb_salir";
            this.btb_salir.Size = new System.Drawing.Size(157, 67);
            this.btb_salir.TabIndex = 9;
            this.btb_salir.Text = "Salir";
            this.btb_salir.UseVisualStyleBackColor = false;
            this.btb_salir.Click += new System.EventHandler(this.btb_salir_Click);
            // 
            // form_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 583);
            this.Controls.Add(this.radio_alumno);
            this.Controls.Add(this.radio_profesor);
            this.Controls.Add(this.radio_admin);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.btb_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "form_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario (Perfil: Admin)";
            this.Load += new System.EventHandler(this.form_CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.RadioButton radio_profesor;
        private System.Windows.Forms.RadioButton radio_alumno;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btb_salir;
    }
}
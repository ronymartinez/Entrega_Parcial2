namespace TP_1
{
    partial class form_CrearMateria
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
            this.lbl_profesor1 = new System.Windows.Forms.Label();
            this.lbl_correlativa1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cuatrimestre = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.combo_profe1 = new System.Windows.Forms.ComboBox();
            this.lbl_profesor2 = new System.Windows.Forms.Label();
            this.combo_profe2 = new System.Windows.Forms.ComboBox();
            this.combo_cuatri = new System.Windows.Forms.ComboBox();
            this.combo_correlativa1 = new System.Windows.Forms.ComboBox();
            this.combo_correlativa2 = new System.Windows.Forms.ComboBox();
            this.lbl_correlativa2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_profesor1
            // 
            this.lbl_profesor1.AutoSize = true;
            this.lbl_profesor1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_profesor1.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor1.Location = new System.Drawing.Point(105, 185);
            this.lbl_profesor1.Name = "lbl_profesor1";
            this.lbl_profesor1.Size = new System.Drawing.Size(133, 26);
            this.lbl_profesor1.TabIndex = 10;
            this.lbl_profesor1.Text = "Profesor 1";
            // 
            // lbl_correlativa1
            // 
            this.lbl_correlativa1.AutoSize = true;
            this.lbl_correlativa1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correlativa1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_correlativa1.ForeColor = System.Drawing.Color.White;
            this.lbl_correlativa1.Location = new System.Drawing.Point(105, 296);
            this.lbl_correlativa1.Name = "lbl_correlativa1";
            this.lbl_correlativa1.Size = new System.Drawing.Size(300, 26);
            this.lbl_correlativa1.TabIndex = 11;
            this.lbl_correlativa1.Text = "Correlativa 1 (opcional):";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(467, 72);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 27);
            this.txt_nombre.TabIndex = 12;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(105, 66);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(113, 26);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_cuatrimestre
            // 
            this.lbl_cuatrimestre.AutoSize = true;
            this.lbl_cuatrimestre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cuatrimestre.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuatrimestre.ForeColor = System.Drawing.Color.White;
            this.lbl_cuatrimestre.Location = new System.Drawing.Point(105, 123);
            this.lbl_cuatrimestre.Name = "lbl_cuatrimestre";
            this.lbl_cuatrimestre.Size = new System.Drawing.Size(176, 26);
            this.lbl_cuatrimestre.TabIndex = 14;
            this.lbl_cuatrimestre.Text = "Cuatrimestre:";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.DarkRed;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(318, 455);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(132, 68);
            this.btn_volver.TabIndex = 22;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Aceptar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(110, 455);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(132, 68);
            this.btn_Aceptar.TabIndex = 21;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // combo_profe1
            // 
            this.combo_profe1.FormattingEnabled = true;
            this.combo_profe1.Location = new System.Drawing.Point(467, 183);
            this.combo_profe1.Name = "combo_profe1";
            this.combo_profe1.Size = new System.Drawing.Size(178, 28);
            this.combo_profe1.TabIndex = 23;
            this.combo_profe1.SelectedIndexChanged += new System.EventHandler(this.combo_profe1_SelectedIndexChanged);
            // 
            // lbl_profesor2
            // 
            this.lbl_profesor2.AutoSize = true;
            this.lbl_profesor2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_profesor2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_profesor2.ForeColor = System.Drawing.Color.White;
            this.lbl_profesor2.Location = new System.Drawing.Point(105, 236);
            this.lbl_profesor2.Name = "lbl_profesor2";
            this.lbl_profesor2.Size = new System.Drawing.Size(267, 26);
            this.lbl_profesor2.TabIndex = 24;
            this.lbl_profesor2.Text = "Profesor 2 (opcional):";
            // 
            // combo_profe2
            // 
            this.combo_profe2.FormattingEnabled = true;
            this.combo_profe2.Location = new System.Drawing.Point(467, 240);
            this.combo_profe2.Name = "combo_profe2";
            this.combo_profe2.Size = new System.Drawing.Size(178, 28);
            this.combo_profe2.TabIndex = 25;
            // 
            // combo_cuatri
            // 
            this.combo_cuatri.FormattingEnabled = true;
            this.combo_cuatri.Location = new System.Drawing.Point(467, 125);
            this.combo_cuatri.Name = "combo_cuatri";
            this.combo_cuatri.Size = new System.Drawing.Size(178, 28);
            this.combo_cuatri.TabIndex = 26;
            this.combo_cuatri.SelectedIndexChanged += new System.EventHandler(this.combo_cuatri_SelectedIndexChanged);
            // 
            // combo_correlativa1
            // 
            this.combo_correlativa1.FormattingEnabled = true;
            this.combo_correlativa1.Location = new System.Drawing.Point(467, 295);
            this.combo_correlativa1.Name = "combo_correlativa1";
            this.combo_correlativa1.Size = new System.Drawing.Size(178, 28);
            this.combo_correlativa1.TabIndex = 27;
            // 
            // combo_correlativa2
            // 
            this.combo_correlativa2.FormattingEnabled = true;
            this.combo_correlativa2.Location = new System.Drawing.Point(467, 352);
            this.combo_correlativa2.Name = "combo_correlativa2";
            this.combo_correlativa2.Size = new System.Drawing.Size(178, 28);
            this.combo_correlativa2.TabIndex = 29;
            // 
            // lbl_correlativa2
            // 
            this.lbl_correlativa2.AutoSize = true;
            this.lbl_correlativa2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correlativa2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_correlativa2.ForeColor = System.Drawing.Color.White;
            this.lbl_correlativa2.Location = new System.Drawing.Point(105, 349);
            this.lbl_correlativa2.Name = "lbl_correlativa2";
            this.lbl_correlativa2.Size = new System.Drawing.Size(300, 26);
            this.lbl_correlativa2.TabIndex = 28;
            this.lbl_correlativa2.Text = "Correlativa 2 (opcional):";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(513, 455);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(132, 68);
            this.btn_salir.TabIndex = 22;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // form_CrearMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 580);
            this.Controls.Add(this.combo_correlativa2);
            this.Controls.Add(this.lbl_correlativa2);
            this.Controls.Add(this.combo_correlativa1);
            this.Controls.Add(this.combo_cuatri);
            this.Controls.Add(this.combo_profe2);
            this.Controls.Add(this.lbl_profesor2);
            this.Controls.Add(this.combo_profe1);
            this.Controls.Add(this.lbl_profesor1);
            this.Controls.Add(this.lbl_correlativa1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_cuatrimestre);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_Aceptar);
            this.Name = "form_CrearMateria";
            this.Text = "Crear Materia (Perfil: Admin)";
            this.Load += new System.EventHandler(this.form_CrearMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_profesor1;
        private System.Windows.Forms.Label lbl_correlativa1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_cuatrimestre;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.ComboBox combo_profe1;
        private System.Windows.Forms.Label lbl_profesor2;
        private System.Windows.Forms.ComboBox combo_profe2;
        private System.Windows.Forms.ComboBox combo_cuatri;
        private System.Windows.Forms.ComboBox combo_correlativa1;
        private System.Windows.Forms.ComboBox combo_correlativa2;
        private System.Windows.Forms.Label lbl_correlativa2;
        private System.Windows.Forms.Button btn_salir;
    }
}
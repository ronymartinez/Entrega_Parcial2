namespace TP_1
{
    partial class form_crearExamen
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lbl_nombreExamen = new System.Windows.Forms.Label();
            this.txt_nombreExamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_materiaExamen = new System.Windows.Forms.ComboBox();
            this.lbl_materiaExamen = new System.Windows.Forms.Label();
            this.date_Examen = new System.Windows.Forms.DateTimePicker();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_aceptar.Location = new System.Drawing.Point(84, 479);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(202, 66);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_nombreExamen
            // 
            this.lbl_nombreExamen.AutoSize = true;
            this.lbl_nombreExamen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreExamen.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreExamen.Location = new System.Drawing.Point(68, 306);
            this.lbl_nombreExamen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nombreExamen.Name = "lbl_nombreExamen";
            this.lbl_nombreExamen.Size = new System.Drawing.Size(248, 26);
            this.lbl_nombreExamen.TabIndex = 2;
            this.lbl_nombreExamen.Text = "Nombre del examen:";
            // 
            // txt_nombreExamen
            // 
            this.txt_nombreExamen.Location = new System.Drawing.Point(407, 303);
            this.txt_nombreExamen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txt_nombreExamen.Name = "txt_nombreExamen";
            this.txt_nombreExamen.Size = new System.Drawing.Size(408, 34);
            this.txt_nombreExamen.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // combo_materiaExamen
            // 
            this.combo_materiaExamen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_materiaExamen.FormattingEnabled = true;
            this.combo_materiaExamen.Location = new System.Drawing.Point(407, 87);
            this.combo_materiaExamen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.combo_materiaExamen.Name = "combo_materiaExamen";
            this.combo_materiaExamen.Size = new System.Drawing.Size(408, 31);
            this.combo_materiaExamen.TabIndex = 1;
            // 
            // lbl_materiaExamen
            // 
            this.lbl_materiaExamen.AutoSize = true;
            this.lbl_materiaExamen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_materiaExamen.ForeColor = System.Drawing.Color.White;
            this.lbl_materiaExamen.Location = new System.Drawing.Point(84, 87);
            this.lbl_materiaExamen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_materiaExamen.Name = "lbl_materiaExamen";
            this.lbl_materiaExamen.Size = new System.Drawing.Size(237, 26);
            this.lbl_materiaExamen.TabIndex = 2;
            this.lbl_materiaExamen.Text = "Materias asignadas:";
            // 
            // date_Examen
            // 
            this.date_Examen.CalendarFont = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Examen.CalendarMonthBackground = System.Drawing.Color.ForestGreen;
            this.date_Examen.CalendarTitleBackColor = System.Drawing.Color.ForestGreen;
            this.date_Examen.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.date_Examen.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_Examen.Location = new System.Drawing.Point(407, 196);
            this.date_Examen.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.date_Examen.Name = "date_Examen";
            this.date_Examen.Size = new System.Drawing.Size(408, 30);
            this.date_Examen.TabIndex = 4;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(353, 479);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(202, 66);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(622, 479);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(202, 66);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // form_crearExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_profe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 620);
            this.Controls.Add(this.date_Examen);
            this.Controls.Add(this.txt_nombreExamen);
            this.Controls.Add(this.lbl_materiaExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nombreExamen);
            this.Controls.Add(this.combo_materiaExamen);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_aceptar);
            this.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "form_crearExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Examen (Perfil: Profesor)";
            this.Load += new System.EventHandler(this.FormCrearExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label lbl_nombreExamen;
        private System.Windows.Forms.TextBox txt_nombreExamen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_materiaExamen;
        private System.Windows.Forms.Label lbl_materiaExamen;
        private System.Windows.Forms.DateTimePicker date_Examen;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_salir;
    }
}
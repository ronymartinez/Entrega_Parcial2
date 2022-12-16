
namespace TP_1
{
    partial class form_BBDD
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btb_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(398, 32);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(85, 26);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Título";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(67, 98);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.RowHeadersWidth = 51;
            this.dgv_tabla.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            this.dgv_tabla.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_tabla.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgv_tabla.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_tabla.RowTemplate.Height = 29;
            this.dgv_tabla.Size = new System.Drawing.Size(732, 305);
            this.dgv_tabla.TabIndex = 1;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_volver.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(190, 433);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(127, 54);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btb_salir
            // 
            this.btb_salir.BackColor = System.Drawing.Color.SteelBlue;
            this.btb_salir.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btb_salir.ForeColor = System.Drawing.Color.White;
            this.btb_salir.Location = new System.Drawing.Point(570, 433);
            this.btb_salir.Name = "btb_salir";
            this.btb_salir.Size = new System.Drawing.Size(127, 54);
            this.btb_salir.TabIndex = 2;
            this.btb_salir.Text = "Salir";
            this.btb_salir.UseVisualStyleBackColor = false;
            this.btb_salir.Click += new System.EventHandler(this.btb_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_eliminar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(382, 433);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(127, 54);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // form_BBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_1.Properties.Resources.fondo_bbdd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 505);
            this.Controls.Add(this.btb_salir);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "form_BBDD";
            this.Text = "FormBBDD";
            this.Load += new System.EventHandler(this.form_BBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btb_salir;
        private System.Windows.Forms.Button btn_eliminar;
    }
}
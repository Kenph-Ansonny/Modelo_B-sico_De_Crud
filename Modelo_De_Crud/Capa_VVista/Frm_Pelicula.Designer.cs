namespace Capa_VVista
{
    partial class Frm_Pelicula
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
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Txt_IdPelicula = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_Titulo = new System.Windows.Forms.TextBox();
            this.Dgv_Pelicula = new System.Windows.Forms.DataGridView();
            this.Txt_FechaEstreno = new System.Windows.Forms.TextBox();
            this.Txt_Calificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Duracion = new System.Windows.Forms.TextBox();
            this.Txt_Disponible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(337, 659);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(162, 40);
            this.Btn_Eliminar.TabIndex = 21;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(172, 659);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(159, 40);
            this.Btn_Modificar.TabIndex = 20;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Font = new System.Drawing.Font("Century", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insertar.Location = new System.Drawing.Point(15, 659);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(151, 40);
            this.Btn_Insertar.TabIndex = 19;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Txt_IdPelicula
            // 
            this.Txt_IdPelicula.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdPelicula.Location = new System.Drawing.Point(38, 116);
            this.Txt_IdPelicula.Name = "Txt_IdPelicula";
            this.Txt_IdPelicula.Size = new System.Drawing.Size(333, 34);
            this.Txt_IdPelicula.TabIndex = 18;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(38, 277);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(333, 34);
            this.Txt_Descripcion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id_Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.Location = new System.Drawing.Point(33, 167);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(70, 25);
            this.Lbl_Usuario.TabIndex = 14;
            this.Lbl_Usuario.Text = "Titulo";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(77, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(224, 32);
            this.Lbl_Titulo.TabIndex = 13;
            this.Lbl_Titulo.Text = "CRUD - Peliculas";
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Titulo.Location = new System.Drawing.Point(38, 195);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(333, 34);
            this.Txt_Titulo.TabIndex = 12;
            // 
            // Dgv_Pelicula
            // 
            this.Dgv_Pelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pelicula.Location = new System.Drawing.Point(536, 38);
            this.Dgv_Pelicula.Name = "Dgv_Pelicula";
            this.Dgv_Pelicula.RowHeadersWidth = 51;
            this.Dgv_Pelicula.RowTemplate.Height = 24;
            this.Dgv_Pelicula.Size = new System.Drawing.Size(861, 661);
            this.Dgv_Pelicula.TabIndex = 11;
            this.Dgv_Pelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Pelicula_SelectionChanged);
            // 
            // Txt_FechaEstreno
            // 
            this.Txt_FechaEstreno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaEstreno.Location = new System.Drawing.Point(38, 345);
            this.Txt_FechaEstreno.Name = "Txt_FechaEstreno";
            this.Txt_FechaEstreno.Size = new System.Drawing.Size(333, 34);
            this.Txt_FechaEstreno.TabIndex = 27;
            // 
            // Txt_Calificacion
            // 
            this.Txt_Calificacion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Calificacion.Location = new System.Drawing.Point(38, 506);
            this.Txt_Calificacion.Name = "Txt_Calificacion";
            this.Txt_Calificacion.Size = new System.Drawing.Size(333, 34);
            this.Txt_Calificacion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha_Estreno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Duracion";
            // 
            // Txt_Duracion
            // 
            this.Txt_Duracion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Duracion.Location = new System.Drawing.Point(38, 424);
            this.Txt_Duracion.Name = "Txt_Duracion";
            this.Txt_Duracion.Size = new System.Drawing.Size(333, 34);
            this.Txt_Duracion.TabIndex = 22;
            // 
            // Txt_Disponible
            // 
            this.Txt_Disponible.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Disponible.Location = new System.Drawing.Point(38, 578);
            this.Txt_Disponible.Name = "Txt_Disponible";
            this.Txt_Disponible.Size = new System.Drawing.Size(333, 34);
            this.Txt_Disponible.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Disponible";
            // 
            // Frm_Pelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 728);
            this.Controls.Add(this.Txt_Disponible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_FechaEstreno);
            this.Controls.Add(this.Txt_Calificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Duracion);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.Txt_IdPelicula);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Txt_Titulo);
            this.Controls.Add(this.Dgv_Pelicula);
            this.Name = "Frm_Pelicula";
            this.Text = "Frm_Pelicula";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.TextBox Txt_IdPelicula;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_Titulo;
        private System.Windows.Forms.DataGridView Dgv_Pelicula;
        private System.Windows.Forms.TextBox Txt_FechaEstreno;
        private System.Windows.Forms.TextBox Txt_Calificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Duracion;
        private System.Windows.Forms.TextBox Txt_Disponible;
        private System.Windows.Forms.Label label6;
    }
}
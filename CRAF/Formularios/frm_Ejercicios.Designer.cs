
namespace CRAF.Formularios
{
    partial class frm_Ejercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ejercicios));
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.lb_NombrePaciente = new System.Windows.Forms.Label();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.lb_Edad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Recomendaciones = new System.Windows.Forms.Label();
            this.txt_Recomendaciones = new System.Windows.Forms.TextBox();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.pb_Imagen = new System.Windows.Forms.PictureBox();
            this.lb_Indicaciones = new System.Windows.Forms.Label();
            this.txt_Indicaciones = new System.Windows.Forms.TextBox();
            this.opn_SeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btn_CargarEjercicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Regresar.Location = new System.Drawing.Point(46, 455);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(168, 37);
            this.btn_Regresar.TabIndex = 0;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // lb_NombrePaciente
            // 
            this.lb_NombrePaciente.AutoSize = true;
            this.lb_NombrePaciente.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lb_NombrePaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_NombrePaciente.Location = new System.Drawing.Point(59, 169);
            this.lb_NombrePaciente.Name = "lb_NombrePaciente";
            this.lb_NombrePaciente.Size = new System.Drawing.Size(168, 21);
            this.lb_NombrePaciente.TabIndex = 1;
            this.lb_NombrePaciente.Text = "Nombre del Paciente:";
            // 
            // btn_Crear
            // 
            this.btn_Crear.Enabled = false;
            this.btn_Crear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Crear.Location = new System.Drawing.Point(234, 455);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(199, 37);
            this.btn_Crear.TabIndex = 2;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Edad
            // 
            this.lb_Edad.AutoSize = true;
            this.lb_Edad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lb_Edad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Edad.Location = new System.Drawing.Point(177, 200);
            this.lb_Edad.Name = "lb_Edad";
            this.lb_Edad.Size = new System.Drawing.Size(50, 21);
            this.lb_Edad.TabIndex = 3;
            this.lb_Edad.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 23);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(234, 198);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(78, 23);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Recomendaciones
            // 
            this.lb_Recomendaciones.AutoSize = true;
            this.lb_Recomendaciones.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lb_Recomendaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Recomendaciones.Location = new System.Drawing.Point(149, 230);
            this.lb_Recomendaciones.Name = "lb_Recomendaciones";
            this.lb_Recomendaciones.Size = new System.Drawing.Size(224, 21);
            this.lb_Recomendaciones.TabIndex = 7;
            this.lb_Recomendaciones.Text = "Recomendaciones Generales:";
            // 
            // txt_Recomendaciones
            // 
            this.txt_Recomendaciones.Location = new System.Drawing.Point(68, 269);
            this.txt_Recomendaciones.Multiline = true;
            this.txt_Recomendaciones.Name = "txt_Recomendaciones";
            this.txt_Recomendaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Recomendaciones.Size = new System.Drawing.Size(402, 150);
            this.txt_Recomendaciones.TabIndex = 8;
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Enabled = false;
            this.btn_Visualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Visualizar.Location = new System.Drawing.Point(459, 455);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(204, 37);
            this.btn_Visualizar.TabIndex = 9;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Enabled = false;
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Imprimir.Location = new System.Drawing.Point(683, 455);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(219, 37);
            this.btn_Imprimir.TabIndex = 10;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Seleccionar.Location = new System.Drawing.Point(633, 24);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(177, 34);
            this.btn_Seleccionar.TabIndex = 11;
            this.btn_Seleccionar.Text = "Seleccionar Imagen";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // pb_Imagen
            // 
            this.pb_Imagen.BackColor = System.Drawing.Color.Azure;
            this.pb_Imagen.Location = new System.Drawing.Point(610, 64);
            this.pb_Imagen.Name = "pb_Imagen";
            this.pb_Imagen.Size = new System.Drawing.Size(223, 187);
            this.pb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagen.TabIndex = 12;
            this.pb_Imagen.TabStop = false;
            // 
            // lb_Indicaciones
            // 
            this.lb_Indicaciones.AutoSize = true;
            this.lb_Indicaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Indicaciones.Location = new System.Drawing.Point(662, 254);
            this.lb_Indicaciones.Name = "lb_Indicaciones";
            this.lb_Indicaciones.Size = new System.Drawing.Size(105, 21);
            this.lb_Indicaciones.TabIndex = 13;
            this.lb_Indicaciones.Text = "Indicaciones:";
            // 
            // txt_Indicaciones
            // 
            this.txt_Indicaciones.Location = new System.Drawing.Point(553, 278);
            this.txt_Indicaciones.Multiline = true;
            this.txt_Indicaciones.Name = "txt_Indicaciones";
            this.txt_Indicaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Indicaciones.Size = new System.Drawing.Size(339, 98);
            this.txt_Indicaciones.TabIndex = 14;
            // 
            // opn_SeleccionarImagen
            // 
            this.opn_SeleccionarImagen.FileName = "Seleccionar Imagen";
            // 
            // btn_CargarEjercicio
            // 
            this.btn_CargarEjercicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarEjercicio.Location = new System.Drawing.Point(620, 382);
            this.btn_CargarEjercicio.Name = "btn_CargarEjercicio";
            this.btn_CargarEjercicio.Size = new System.Drawing.Size(204, 37);
            this.btn_CargarEjercicio.TabIndex = 15;
            this.btn_CargarEjercicio.Text = "Cargar al PDF";
            this.btn_CargarEjercicio.UseVisualStyleBackColor = true;
            this.btn_CargarEjercicio.Click += new System.EventHandler(this.btn_CargarEjercicio_Click);
            // 
            // frm_Ejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.btn_CargarEjercicio);
            this.Controls.Add(this.txt_Indicaciones);
            this.Controls.Add(this.lb_Indicaciones);
            this.Controls.Add(this.pb_Imagen);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.txt_Recomendaciones);
            this.Controls.Add(this.lb_Recomendaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lb_Edad);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.lb_NombrePaciente);
            this.Controls.Add(this.btn_Regresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Ejercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Rehabilitación Acuática y Fisica";
            this.Load += new System.EventHandler(this.frm_Ejercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label lb_NombrePaciente;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Label lb_Edad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Recomendaciones;
        private System.Windows.Forms.TextBox txt_Recomendaciones;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.PictureBox pb_Imagen;
        private System.Windows.Forms.Label lb_Indicaciones;
        private System.Windows.Forms.TextBox txt_Indicaciones;
        private System.Windows.Forms.OpenFileDialog opn_SeleccionarImagen;
        private System.Windows.Forms.Button btn_CargarEjercicio;
    }
}
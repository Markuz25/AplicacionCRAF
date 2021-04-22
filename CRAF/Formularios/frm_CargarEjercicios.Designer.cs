
namespace CRAF.Formularios
{
    partial class frm_CargarEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CargarEjercicios));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Categorias = new System.Windows.Forms.ComboBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.pb_ImagenCargada = new System.Windows.Forms.PictureBox();
            this.Cargar_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_NombreEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenCargada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la categoria:";
            // 
            // cb_Categorias
            // 
            this.cb_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categorias.FormattingEnabled = true;
            this.cb_Categorias.Items.AddRange(new object[] {
            "Cuello",
            "Hombro",
            "Codo",
            "Muñeca",
            "Cadera",
            "Pierna",
            "Rodilla",
            "Pie"});
            this.cb_Categorias.Location = new System.Drawing.Point(274, 29);
            this.cb_Categorias.Name = "cb_Categorias";
            this.cb_Categorias.Size = new System.Drawing.Size(150, 23);
            this.cb_Categorias.TabIndex = 1;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Enabled = false;
            this.btn_Cargar.Location = new System.Drawing.Point(48, 138);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(195, 40);
            this.btn_Cargar.TabIndex = 2;
            this.btn_Cargar.Text = "Cargar Imagen";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // pb_ImagenCargada
            // 
            this.pb_ImagenCargada.Image = ((System.Drawing.Image)(resources.GetObject("pb_ImagenCargada.Image")));
            this.pb_ImagenCargada.Location = new System.Drawing.Point(273, 72);
            this.pb_ImagenCargada.Name = "pb_ImagenCargada";
            this.pb_ImagenCargada.Size = new System.Drawing.Size(195, 191);
            this.pb_ImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ImagenCargada.TabIndex = 3;
            this.pb_ImagenCargada.TabStop = false;
            // 
            // Cargar_Imagen
            // 
            this.Cargar_Imagen.FileName = "Cargar Imagen";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(190, 455);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(138, 40);
            this.btn_Regresar.TabIndex = 4;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(163, 382);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(195, 41);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar Imagen";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_NombreEjercicio
            // 
            this.txt_NombreEjercicio.Location = new System.Drawing.Point(273, 314);
            this.txt_NombreEjercicio.Name = "txt_NombreEjercicio";
            this.txt_NombreEjercicio.Size = new System.Drawing.Size(195, 23);
            this.txt_NombreEjercicio.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del ejercicio";
            // 
            // frm_CargarEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NombreEjercicio);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.pb_ImagenCargada);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.cb_Categorias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CargarEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Rehabilitación Acuática y Fisica";
            this.Load += new System.EventHandler(this.frm_CargarEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenCargada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Categorias;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.PictureBox pb_ImagenCargada;
        private System.Windows.Forms.OpenFileDialog Cargar_Imagen;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_NombreEjercicio;
        private System.Windows.Forms.Label label2;
    }
}
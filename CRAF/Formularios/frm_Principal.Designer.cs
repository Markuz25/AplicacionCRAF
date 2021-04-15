
namespace CRAF.Formularios
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.pnl_Agregar = new System.Windows.Forms.Panel();
            this.btn_AgregarPaciente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SeleccionarEjercicios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ConsultarExpediente = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Agregar
            // 
            this.pnl_Agregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_Agregar.Controls.Add(this.btn_AgregarPaciente);
            this.pnl_Agregar.Controls.Add(this.pictureBox1);
            this.pnl_Agregar.Location = new System.Drawing.Point(54, 105);
            this.pnl_Agregar.Name = "pnl_Agregar";
            this.pnl_Agregar.Size = new System.Drawing.Size(176, 180);
            this.pnl_Agregar.TabIndex = 0;
            // 
            // btn_AgregarPaciente
            // 
            this.btn_AgregarPaciente.Location = new System.Drawing.Point(24, 137);
            this.btn_AgregarPaciente.Name = "btn_AgregarPaciente";
            this.btn_AgregarPaciente.Size = new System.Drawing.Size(124, 37);
            this.btn_AgregarPaciente.TabIndex = 1;
            this.btn_AgregarPaciente.Text = "Agregar Paciente";
            this.btn_AgregarPaciente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btn_SeleccionarEjercicios);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(677, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 180);
            this.panel1.TabIndex = 1;
            // 
            // btn_SeleccionarEjercicios
            // 
            this.btn_SeleccionarEjercicios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SeleccionarEjercicios.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SeleccionarEjercicios.Location = new System.Drawing.Point(24, 137);
            this.btn_SeleccionarEjercicios.Name = "btn_SeleccionarEjercicios";
            this.btn_SeleccionarEjercicios.Size = new System.Drawing.Size(124, 37);
            this.btn_SeleccionarEjercicios.TabIndex = 1;
            this.btn_SeleccionarEjercicios.Text = "Seleccionar Ejercicios";
            this.btn_SeleccionarEjercicios.UseVisualStyleBackColor = false;
            this.btn_SeleccionarEjercicios.Click += new System.EventHandler(this.btn_SeleccionarEjercicios_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Azure;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btn_ConsultarExpediente);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(363, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 180);
            this.panel2.TabIndex = 2;
            // 
            // btn_ConsultarExpediente
            // 
            this.btn_ConsultarExpediente.Location = new System.Drawing.Point(24, 137);
            this.btn_ConsultarExpediente.Name = "btn_ConsultarExpediente";
            this.btn_ConsultarExpediente.Size = new System.Drawing.Size(124, 37);
            this.btn_ConsultarExpediente.TabIndex = 1;
            this.btn_ConsultarExpediente.Text = "Historial Medico";
            this.btn_ConsultarExpediente.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Azure;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centro de Rehabilitación Acuática y Fisica";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Rehabilitación Acuática y Fisica";
            this.pnl_Agregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Agregar;
        private System.Windows.Forms.Button btn_AgregarPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SeleccionarEjercicios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ConsultarExpediente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}
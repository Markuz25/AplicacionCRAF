using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CRAF.Formularios
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }


        private void btn_SeleccionarEjercicios_Click(object sender, EventArgs e)
        {
            frm_Ejercicios ejercicios = new frm_Ejercicios();
            ejercicios.Show();
            Hide();
            
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Creando carpeta donde se almacenaran los ejercicios
            string carpeta = Application.StartupPath + @"\Ejercicios";
            try
            {
                if (Directory.Exists(carpeta))
                {
                    //MessageBox.Show("Carpeta Creada");
                }
                else
                {
                    //MessageBox.Show("Creando Carpeta.....");
                    Directory.CreateDirectory(carpeta);
                }

                frm_CargarEjercicios cargarEjercicios = new frm_CargarEjercicios();
                cargarEjercicios.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

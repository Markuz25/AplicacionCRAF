using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace CRAF.Formularios
{
    public partial class frm_CargarEjercicios : Form
    {
        public frm_CargarEjercicios()
        {
            InitializeComponent();
        }

        //Carga la imagen el pictureBox
        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cargar_Imagen.ShowDialog();
                if (this.Cargar_Imagen.FileName.Equals("")==false)
                {
                    pb_ImagenCargada.Load(this.Cargar_Imagen.FileName);
                    btn_Guardar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: "+ex.Message);
                btn_Guardar.Enabled = false;
            }
        }

        //Regresar a la pantalla principal
        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_Principal principal = new frm_Principal();
            principal.Show();
            Close();
        }

        //Metodo para crear la ruta
        public void CrearCarpeta(string categoria)
        {
            string destino;
            string ruta = Application.StartupPath + @"Ejercicios\"+categoria;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    MessageBox.Show("Directorio Creado");
                    Directory.CreateDirectory(ruta);
                    destino = ruta;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error :\n " + ex);
            }
        }

       
        //Guardar en la ruta seleccionada la imagen cargada
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = txt_NombreEjercicio.Text;
            if(txt_NombreEjercicio.Text == "")
            {
                MessageBox.Show("Escriba el nombre del ejercicio");
            }
            else
            {
                string categoria = cb_Categorias.Text;
                CrearCarpeta(categoria);
                try
                {
                    string destino = string.Format(@"Ejercicios\{0}\{1}.jpeg", categoria, nombre);
                    pb_ImagenCargada.Image.Save(destino, ImageFormat.Jpeg);
                    MessageBox.Show("La imagen ha sido guardada.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido guardar la imagen:\n" + ex.Message);
                }
            }
            
        }

        //Selecciona la categoria indicada
        private void frm_CargarEjercicios_Load(object sender, EventArgs e)
        {
            cb_Categorias.SelectedIndex = 0;
            if (cb_Categorias.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecciona una categoria");
            }
            else
            {
                btn_Cargar.Enabled = true;
            }
        }
    }
}

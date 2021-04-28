using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using Image = iText.Layout.Element.Image;
using Image1 = System.Drawing.Image;
using iText.IO.Image;
using System.Diagnostics;

namespace CRAF.Formularios
{
    public partial class frm_Ejercicios : Form
    {


        public frm_Ejercicios()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_principal = new frm_Principal();
            frm_principal.Show();
            Hide();
        }

        private void frm_Ejercicios_Load(object sender, EventArgs e)
        {
            //Crea la carpeta correspondiente
            CrearCarpeta();
        }

        //Creamos la carpeta donde se almacenaran las listas de los ejercicios
        public void CrearCarpeta()
        {
            string ruta = Application.StartupPath + @"PacientesEjercicios";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error :\n " + ex);
            }
        }

        

        //Crear PDF y plantilla correspondiente
        public void crearEncabezadoPDF()
        {
            //Variables
            string paciente = txtNombre.Text;
            string edad = txtEdad.Text;
            string recomendaciones = txt_Recomendaciones.Text;

            //Concatenaciones
            string datoNombrePaciente = lb_NombrePaciente.Text + paciente;
            string datoEdadPaciente = lb_Edad.Text + edad;
            string datoRecomendaciones = lb_Recomendaciones.Text + recomendaciones;

            string ruta = string.Format(@"PacientesEjercicios\{0}.pdf", txtNombre.Text);
            PdfWriter writer = new PdfWriter(ruta);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            //Agregamos Logo de la Clinica
            Image img = new Image(ImageDataFactory
                .Create(@"Recursos\LogoCraf.jpg"))
                .SetTextAlignment(TextAlignment.LEFT)
                .ScaleToFit(250f, 250f);
            document.Add(img);
            //Titulo del documento
            Paragraph header = new Paragraph("Centro de Rehabilitación Acuática y Fisica")
               .SetTextAlignment(TextAlignment.RIGHT)
               .SetFontSize(15);

            document.Add(header);

            //Insertamos linea de separacion
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);

            //Agregamos datos del paciente
            Paragraph paciente_dato = new Paragraph(datoNombrePaciente).SetTextAlignment(TextAlignment.LEFT).SetFontSize(10);
            Paragraph edad_dato = new Paragraph(datoEdadPaciente).SetTextAlignment(TextAlignment.LEFT).SetFontSize(10);
            Paragraph recomendacion_dato = new Paragraph(datoRecomendaciones).SetTextAlignment(TextAlignment.LEFT).SetFontSize(10);
            document.Add(paciente_dato);
            document.Add(edad_dato);
            document.Add(recomendacion_dato);
            document.Close();

            //Habilitamos el boton visualizar al momento de crear el Pdf
            btn_Visualizar.Enabled = true;

        }

        //Metodo para visualizar el Pdf creado
        public void visualizarPDF()
        {
            
        }

        //Metodo para imprimir el documento creado
        public void imprimirPDF()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txt_Indicaciones.Text) || string.IsNullOrEmpty(txt_Recomendaciones.Text) || pb_Imagen.Image == null)
            {
                MessageBox.Show("No se han llenado los datos correspondientes","Advertencia");
            }          
            else
            {
                if (MessageBox.Show("¿Desea agregar más ejercicios al documento?", "Confirmar creación", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    crearEncabezadoPDF();
                    MessageBox.Show("Documento creado","Confirmación");
                    btn_Visualizar.Enabled = true;
                    btn_Imprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Agrege mas ejercicios","Importante");
                }
            }
            
           
        }

        //Validamos que solo se ingresen numeros en el txt_Edad
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btn_CargarEjercicio_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (string.IsNullOrEmpty(txt_Indicaciones.Text) || (pb_Imagen.Image == null))
                    {
                        MessageBox.Show("No se han llenado los datos correspondiente", "Cuidado");
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea agregar este ejercicio?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show("Ejercicio agregado","Confirmación");
                            btn_Crear.Enabled = true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n"+ex.Message);
                }
                
            
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (opn_SeleccionarImagen.ShowDialog() == DialogResult.OK)
                {
                    string imagen = opn_SeleccionarImagen.FileName;
                    pb_Imagen.Image = Image1.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido:\n"+ex.Message,"Advertencia");
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                visualizarPDF();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido visualizar:\n" + ex.Message, "Error");
            }
            
        }
    }
}

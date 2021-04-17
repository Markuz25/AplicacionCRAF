using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CRAF.Formularios
{
    public partial class frm_Ejercicios : Form
    {
        string destino = "";
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

        }

        public void crearPDF()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();//Abrimos el documento para escribir
            //Insertamos el contenido
            Paragraph parrafo = new Paragraph("Esto es un ejemplo\n Nueva Linea");
            doc.Add(parrafo);
            doc.Close();//Cerramos para terminar de editar el documento
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearPDF();
        }
    }
}

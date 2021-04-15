using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            frm_Ejercicios frm_ejercicios = new frm_Ejercicios();
            frm_ejercicios.Show();
            Hide();
            
        }
    }
}

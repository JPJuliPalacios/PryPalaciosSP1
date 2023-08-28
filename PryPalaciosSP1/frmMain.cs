using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryPalaciosSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swCreararchivo = new StreamWriter("MiArchivito", false);
                MessageBox.Show("Archivo Creado");
            }
            catch (Exception)
            {
                MessageBox.Show("Fatal Error");
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swMajejoarchivo = new StreamWriter("MiArchivito", true); //crea el archivo
                swMajejoarchivo.WriteLine(txtDatos.Text);
                swMajejoarchivo.Close();
                MessageBox.Show("Datos Cargados");
                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("MiArchivito");
            
            while (srManejoArchivo.EndOfStream==false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }
            srManejoArchivo.Close();
        }
    }
}

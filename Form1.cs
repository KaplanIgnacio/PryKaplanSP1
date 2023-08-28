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

namespace PryKaplanSP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArchivo1_Click(object sender, EventArgs e)
        {
            StreamWriter swCrearArchivo = new StreamWriter("miArchivito", false);

            if (swCrearArchivo != null)
            {
                MessageBox.Show("Archivo Creado");
            }
                    
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter swManejoArchivo = new StreamWriter("miArchivito", true);

                swManejoArchivo.WriteLine(txtDatos.Text);

                swManejoArchivo.Close();

                MessageBox.Show("Almacenado");
                txtDatos.Text = "";
                txtDatos.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal Error: " + ex.Message);
            }
        }

        private void bnLeerArchivo_Click(object sender, EventArgs e)
        {
            StreamReader srManejoArchivo = new StreamReader("miArchivito");

            while (srManejoArchivo.EndOfStream == false)
            {
                txtDatos.Text += srManejoArchivo.ReadLine() + Environment.NewLine;
            }

            srManejoArchivo.Close();
        }
    }
}

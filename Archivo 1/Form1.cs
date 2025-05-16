using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo_1
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

        private void txtCaja1_TextChanged(object sender, EventArgs e)
        {
            //leer el contenido de la caja de texto y guarde en un fichero llamado "FicheroFinal.txt"
            //si el fichero no existe, lo crea
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string texto = txtCaja1.Text;
            if (!string.IsNullOrWhiteSpace(texto))
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FicheroFinal.txt");
                File.AppendAllText(rutaArchivo, texto + Environment.NewLine);
                txtCaja1.Clear();
                txtCaja1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FicheroFinal.txt");
            if (File.Exists(rutaArchivo))
            {
                txtCaja2.Text = File.ReadAllText(rutaArchivo);
            }
            else
            {
                txtCaja2.Text = "El fichero no existe.";
            }
        }
    }
    
}

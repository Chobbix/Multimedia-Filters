using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Procesamiento_Imagenes.Clases;

namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    public partial class Form_Imagen : Form
    {
        Filtros filtros = new Filtros();

        public Form_Imagen()
        {
            InitializeComponent();
        }

        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgImagen = new OpenFileDialog();

            if (dlgImagen.ShowDialog() == DialogResult.OK) 
            {
                img_Imagen.ImageLocation = dlgImagen.FileName;
                img_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Filtro1_Click(object sender, EventArgs e)
        {
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Escala_Grises(copia);
        }
    }
}

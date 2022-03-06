using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        Bitmap imgOriginal;
        bool isImageOriginal = true;

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
            obtener_Imagen_Original();
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Filtro_Escala_Grises(copia);
        }

        private void btn_Filtro2_Click(object sender, EventArgs e)
        {
            obtener_Imagen_Original();
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Filtro_Invertido(copia);
        }

        private void btn_Filtro3_Click(object sender, EventArgs e)
        {
            obtener_Imagen_Original();
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Filtro_Color_Rojo(copia);
        }

        private void btn_Filtro4_Click(object sender, EventArgs e)
        {
            obtener_Imagen_Original();
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Filtro_Brillo(copia);
        }

        private void btn_Filtro5_Click(object sender, EventArgs e)
        {
            obtener_Imagen_Original();
            Bitmap copia = new Bitmap(img_Imagen.Image);
            img_Imagen.Image = filtros.Filtro_Binario(copia);
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            img_Imagen.Image = imgOriginal;
            isImageOriginal = true;
        }

        private void btn_Descargar_Click(object sender, EventArgs e)
        {
            int longitud = 7;
            Guid miGuid = Guid.NewGuid();
            string token = miGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            img_Imagen.Image.Save("../../Imagenes/" + token + ".png", ImageFormat.Png);

            MessageBox.Show("Su imagen se ha descargado con exito", "Descarga de imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void obtener_Imagen_Original()
        {
            if (isImageOriginal) 
            {
                imgOriginal = new Bitmap(img_Imagen.Image);
                isImageOriginal = false;
            }
        }
    }
}

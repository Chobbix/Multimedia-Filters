using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros
    {
        public Filtros() { }

        public Bitmap Filtro_Escala_Grises(Bitmap original) 
        {
            Bitmap nuevo = null;

            for (int i=0; i < original.Width; i++)
            {
                for (int j=0; j < original.Height; j++)
                {
                    Color c1 = original.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    original.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }

            nuevo = original;
            return nuevo;
        }

        public Bitmap Filtro_Invertido(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes Ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                new float[]{-1, 0, 0, 0, 0},
                new float[]{0, -1, 0, 0, 0},
                new float[]{0, 0, -1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{1, 1, 1, 0, 1}
            });

            Ia.SetColorMatrix(cmPicture);
            Graphics gr = Graphics.FromImage(bmpinverted);

            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            gr.Dispose();

            return bmpinverted;
        }

        public Bitmap Filtro_Color_Rojo(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes Ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}
            });

            Ia.SetColorMatrix(cmPicture);
            Graphics gr = Graphics.FromImage(bmpinverted);

            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            gr.Dispose();

            return bmpinverted;
        }

        public Bitmap Filtro_Brillo(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes Ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{.5f, .5f, .5f, 0, 1}
            });

            Ia.SetColorMatrix(cmPicture);
            Graphics gr = Graphics.FromImage(bmpinverted);

            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, Ia);
            gr.Dispose();

            return bmpinverted;
        }
    }
}

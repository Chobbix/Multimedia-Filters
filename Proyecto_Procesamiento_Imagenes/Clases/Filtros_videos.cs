using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros_videos
    {
        public Filtros_videos() { }
        public Int32[] Bits { get; private set; }

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
    }
}

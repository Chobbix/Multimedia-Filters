using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros_videos
    {
        public Filtros_videos() { }
        public Int32[] Bits { get; private set; }
        public Bitmap Filtro_Escala_Grises(Bitmap img)
        {
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(img);


            unsafe
            {
                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                // Define variables for bytes per pixel, as well as Image Width & Height
                int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
                int heightInPixels = bmpData.Height;
                int widthInBytes = bmpData.Width * bytesPerPixel;
                // Define a pointer to the first pixel in the locked image
                // Scane gets or sets the address of the first pixel data in the bitmap.
                // This can also be thought of as the first scan line in the bitmap.
                byte* PtrFirstPixel = (byte*)bmpData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bmpData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        // GET: each pixel color (R, G, & B)
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        int gray = (byte)(.299 * oldRed + .587 * oldGreen + .114 * oldBlue);

                        // SET: kero out the Blue, copy Green and Red unchanged
                        currentLine[x] = (byte)gray;
                        currentLine[x + 1] = (byte)gray;
                        currentLine[x + 2] = (byte)gray;
                    }
                });

                bmp.UnlockBits(bmpData);
            }

            // Draw the modified image.
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

            return bmp;
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

        public Bitmap Filtro_Binario(Image img)
        {
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(img);


            unsafe
            {
                // Lock the bitmap's bits.  
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

                // Define variables for bytes per pixel, as well as Image Width & Height
                int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
                int heightInPixels = bmpData.Height;
                int widthInBytes = bmpData.Width * bytesPerPixel;
                // Define a pointer to the first pixel in the locked image
                // Scane gets or sets the address of the first pixel data in the bitmap.
                // This can also be thought of as the first scan line in the bitmap.
                byte* PtrFirstPixel = (byte*)bmpData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bmpData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        // GET: each pixel color (R, G, & B)
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        int gray = (byte)(.299 * oldRed + .587 * oldGreen + .114 * oldBlue);

                        if (gray <= 125)
                            gray = 0;
                        else
                            gray = 255;

                        // SET: kero out the Blue, copy Green and Red unchanged
                        currentLine[x] = (byte)gray;
                        currentLine[x + 1] = (byte)gray;
                        currentLine[x + 2] = (byte)gray;
                    }
                });

                bmp.UnlockBits(bmpData);
            }

            // Draw the modified image.
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);

            return bmp;
        }
    }
}

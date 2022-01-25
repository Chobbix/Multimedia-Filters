using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros
    {
        public Filtros() { }

        public Bitmap Escala_Grises(Bitmap original) 
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
    }
}

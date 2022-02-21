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
using Emgu.CV;
using Emgu.CV.Structure;
using Proyecto_Procesamiento_Imagenes.Clases;

namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    public partial class Form_Video : Form
    {
        VideoCapture videoCapture;
        bool pause = false;
        Filtros_videos filtros = new Filtros_videos();


        public Form_Video()
        {
            InitializeComponent();
        }

        private async void btn_Cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                videoCapture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                img_Video.Image = m.Bitmap;

                while (!pause)
                {
                    videoCapture.Read(m);

                    if(!m.IsEmpty)
                    {
                        //img_Video.Image = m.Bitmap;
                        //img_Video.SizeMode = PictureBoxSizeMode.StretchImage;
                        //img_Video.Image = filtros.Escala_Grises(m.Bitmap);
                        

                        Bitmap bitmapResultante = filtros.Filtro_Invertido(m.Bitmap);

                        img_Video.Image = bitmapResultante;
                        img_Video.SizeMode = PictureBoxSizeMode.StretchImage;

                        double fps = videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        await Task.Delay(1000/Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void btn_Filtro1_Click(object sender, EventArgs e)
        {

        }
    }
}

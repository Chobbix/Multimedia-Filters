using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace Proyecto_Procesamiento_Imagenes
{
    public partial class Form1 : Form
    {
        private bool isDevice = true;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        public void CargarDispositivos() 
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                isDevice = true;
                for (int i = 0; i < misDispositivos.Count; i++) 
                    comboBox1.Items.Add(misDispositivos[i].Name.ToString());

                comboBox1.Text = misDispositivos[0].ToString();
            }
            else 
            {
                isDevice = false;
            }
        }

        public void CerrarWebCam() 
        {
            if (miWebCam != null && miWebCam.IsRunning) 
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        private void btn_Empezar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(NombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            miWebCam.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs) 
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            img_Camara.Image= imagen;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}

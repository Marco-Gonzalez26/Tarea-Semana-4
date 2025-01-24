using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace _01_Primera_Vez.Views.Asistencias
{
    public partial class FrmAsistencias : Form
    {

        public FrmAsistencias()
        {
            InitializeComponent();
        }


        public void SetImage(Bitmap bitmap)
        {
            timeBox.Text = DateTime.Now.ToLongTimeString();

            lock (this)
            {
                Bitmap old = (Bitmap)pictureBox.Image;
                pictureBox.Image = bitmap;

                if (old != null)
                {
                    old.Dispose();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var cls_asistencia = new Controllers.cls_asistencia();
            var dto_asistecia = new Models.dto_asistencia();
            var cls_personal = new Controllers.cls_Personal();

            var personal = cls_personal.getOne(txtcedula.Text, false);
            if (personal.idPersonal == 0)
            {
                MessageBox.Show("No se encontro ningun registro con ese número de cedula");
                return;
            }
            dto_asistecia = new Models.dto_asistencia
            {
                Cedula = txtcedula.Text,
                IdPersonal = (int)personal.idPersonal

            };
            if (cls_asistencia.insertar(dto_asistecia))
            {
                MessageBox.Show("La asistencia se registro con exito");
            }

        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {

        }
    }
}
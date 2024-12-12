using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Primera_Vez.Views.Usuarios;
namespace _01_Primera_Vez.Views
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            CUPersonal cuPersonal = new CUPersonal();
            Panel_General.Controls.Clear();
            cuPersonal.Dock = DockStyle.Fill;

            Panel_General.Controls.Add(cuPersonal);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CU_Usuarios cuUsuarios = new CU_Usuarios();
            Panel_General.Controls.Clear();
            cuUsuarios.Dock = DockStyle.Fill;

            Panel_General.Controls.Add(cuUsuarios);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurarBD_Click(object sender, EventArgs e)
        {

        }


    }
}

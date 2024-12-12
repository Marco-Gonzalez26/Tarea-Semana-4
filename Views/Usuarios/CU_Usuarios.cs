using _01_Primera_Vez.Controllers;
using _01_Primera_Vez.Views.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Primera_Vez.Views.Usuarios
{
    public partial class CU_Usuarios : UserControl
    {
        public CU_Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();

            frmUsuario.Show();
        }
       
        private void CU_Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}

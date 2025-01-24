using _01_Primera_Vez.Controllers;
using _01_Primera_Vez.Models;
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
        cls_Usuario usersController = new cls_Usuario();
        public CU_Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(null);

            frmUsuario.ShowDialog();
            fillUsersList(false);

        }

        private void fillUsersList(bool search)
        {
            List<dto_Usuario> users;
            if (search)
            {
                users = usersController.search(txtBuscarUsuario.Text.Trim());
            }
            else
            {

                users = usersController.getAll();
            }



            var usersCount = users.Count;
            var usersCountText = usersCount > 1 ? "usuarios" : "usuario";
            lstUsers.DataSource = null;
            lstUsers.DataSource = users;
            lstUsers.ValueMember = "idUsuario";
            lstUsers.DisplayMember = "nombre";
            lblUsersCount.Text = $"{usersCount} {usersCountText}";
        }

        private void CU_Usuarios_Load(object sender, EventArgs e)
        {
            fillUsersList(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userId = lstUsers.SelectedValue;
            FrmUsuario frmUsuario = new FrmUsuario((int)userId);
            frmUsuario.ShowDialog();
            fillUsersList(false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var userId = lstUsers.SelectedValue;
            MessageBox.Show($"ID {userId}");



            var result = usersController.deleteOne((int)userId);
            string message = result ? "Usuario eliminado correctamente"
                : "Hubo un error en el proceso de eliminación";
            MessageBox.Show(message);
            fillUsersList(false);

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            fillUsersList(true);
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            fillUsersList(true);

        }
    }
}

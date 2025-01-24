using _01_Primera_Vez.Controllers;
using _01_Primera_Vez.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Primera_Vez.Views.Usuarios
{
    public partial class FrmUsuario : Form

    {
        cls_Usuario usersController = new cls_Usuario();
        int? userId = null;
        public FrmUsuario(int? userId)
        {
            if (userId != null)
            {
                this.userId = userId;
            }
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Funcion para comprobar si el texto del correo es un correo electrónico
        public bool isValidEmail(string email)
        {

            string regex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            return Regex.IsMatch(email, regex);
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            string result;
            if (txtCorreo.Text.Length == 0 || txtNombre.Text.Length == 0
             || txtNombreUsuario.Text.Length == 0
             )
            {

                MessageBox.Show("Rellene todos los campos");
                return;
            }

            if (!isValidEmail(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Formato de correo electrónico incorrecto");
                return;
            }

            dto_Usuario user = new dto_Usuario
            {
                correo = txtCorreo.Text,
                nombre = txtNombre.Text,
                nombre_usuario = txtNombreUsuario.Text
            };
            if (userId != null)
            {
                user.idUsuario = (int)userId;
                result = usersController.updateOne(user);

            }
            else
            {

                result = usersController.Insertar(user);
            }
            MessageBox.Show(result);
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Editar Usuario";
            if (userId != null) {
                dto_Usuario userToEdit = usersController.getOne((int)userId);
                if (userToEdit != null) { 
                    txtCorreo.Text  = userToEdit.correo;
                    txtNombre.Text = userToEdit.nombre;
                    txtNombreUsuario.Text = userToEdit.nombre_usuario;
                }
            }
        }
    }
}

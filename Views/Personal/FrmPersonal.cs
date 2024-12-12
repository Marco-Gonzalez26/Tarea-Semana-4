using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Primera_Vez.Controllers;
using _01_Primera_Vez.Models;

namespace _01_Primera_Vez.Views.Personal
{
    public partial class FrmPersonal : Form
    {
        public bool modoEdicion;
        public FrmPersonal(string modo)
        {


            InitializeComponent();
            if (modo != "n") this.modoEdicion = true;

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            if (!this.modoEdicion)
            {

                lblFrmPersonal.Text = "Ingreso de nuevo personal";
            }
            else {

                lblFrmPersonal.Text = "Actualizacion de personal";
            }

        

            cls_Pais paises = new cls_Pais();
            cmbPais.DataSource =  paises.Obtener();
            cmbPais.ValueMember= "idPais";
            cmbPais.DisplayMember = "detalle";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(char.IsControl(e.KeyChar).ToString());
            //MessageBox.Show(char.IsDigit(e.KeyChar).ToString());

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevoPersonal = new dto_Personal
            {
                cargo = txtCargo.Text,
                cedula = txtCedula.Text,
                idPais = (int)cmbPais.SelectedValue,
                nombre = txtNombresApellidos.Text,
                sueldo = Convert.ToDecimal(txtSueldo.Text)
            };

            var clsPersonal = new cls_Personal();


            var statusString = clsPersonal.Insertar(nuevoPersonal);

            MessageBox.Show(statusString);

            this.Hide();

        }
    }
}

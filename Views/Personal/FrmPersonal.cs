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
        public int idPersonal = 0;
        public FrmPersonal(string modo, int? id)
        {


            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdicion = true;
                this.idPersonal = (int)id;
            };

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            this.cargarPaises();
            if (!this.modoEdicion)
            {

                lblFrmPersonal.Text = "Ingreso de nuevo personal";
            }
            else
            {

                lblFrmPersonal.Text = "Actualizacion de personal";
                var logicaPersonal = new cls_Personal();
                var personal = logicaPersonal.getOne(idPersonal.ToString(), true);


                txtCargo.Text = personal.cargo;
                txtCedula.Text = personal.cedula;
                txtNombresApellidos.Text = personal.nombre;
                txtSueldo.Text = personal.sueldo.ToString();
                cmbPais.SelectedIndex = (int)personal.idPais;
            }




        }
        public void cargarPaises()
        {
            cls_Pais paises = new cls_Pais();
            cmbPais.DataSource = paises.Obtener();
            cmbPais.ValueMember = "idPais";
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

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSueldo.Text == "" ||
                txtCargo.Text == "" ||
                txtNombresApellidos.Text == "" ||
                txtCedula.Text == ""
                ) { 
            return;
            }
            var nuevoPersonal = new dto_Personal
            {
                cargo = txtCargo.Text,
                cedula = txtCedula.Text,
                idPais = (int)cmbPais.SelectedValue,
                nombre = txtNombresApellidos.Text,
                sueldo = Convert.ToDecimal(txtSueldo.Text)
            };
            var clsPersonal = new cls_Personal();
            try
            {
                if (this.modoEdicion)
                {
                    nuevoPersonal.idPersonal = this.idPersonal;
                    if (clsPersonal.updateOne(nuevoPersonal) == "ok")
                    {
                        MessageBox.Show("El personal se actualizo exitosamente");
                    }
                }
                else
                {

                    var statusString = clsPersonal.Insertar(nuevoPersonal);

                    MessageBox.Show(statusString);
                }



                this.Hide();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            var logicaPersonal = new cls_Personal();
           
            if (logicaPersonal.isCIDuplicated(txtCedula.Text))
            {
                txtCedula.Focus();
                MessageBox.Show("Numero de cedula ingresado ya esta registrado");
                clear();
            }
        }

        public void clear()
        {
            txtCedula.Text = "";
            txtCargo.Text = "";
            txtNombresApellidos.Text = "";
            txtSueldo.Text = "";
            cmbPais.SelectedIndex = -1;

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void cmbPais_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

        }
    }
}

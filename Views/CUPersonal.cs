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
using _01_Primera_Vez.Views.Personal;
namespace _01_Primera_Vez.Views
{
    public partial class CUPersonal : UserControl
    {
        public CUPersonal()
        {
            InitializeComponent();
        }


        private void btnNuevoPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal frmPersonal = new FrmPersonal("n");

            frmPersonal.Show();
        }

        private void CUPersonal_Load(object sender, EventArgs e)
        {
            /* Llamar al cls personal y 
             * cargar el procedimiento donde se muestren todos los registros
            */
            fillGridView();

        }
        public void fillGridView() {
            var logicaPersonal = new cls_Personal();

            dgvUsuarios.DataSource = "";
            dgvUsuarios.DataSource = logicaPersonal.getAll();
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvUsuarios.Columns.Add(autoIncrement);

            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            dgvUsuarios.Columns["cedula"].HeaderText = "Cédula";
            dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["cargo"].HeaderText = "Cargo";
            dgvUsuarios.Columns["sueldo"].HeaderText = "Salario";
            dgvUsuarios.Columns["detalle"].HeaderText = "País";
            dgvUsuarios.Columns["idPersonal"].Visible = false;
            dgvUsuarios.Columns["idPais"].Visible = false;

            dgvUsuarios.Columns.Add(btnEditar);
            dgvUsuarios.Columns.Add(btnEliminar);

        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            for (int i = 0; i < dgvUsuarios.Rows.Count; i++)
            {
                dgvUsuarios.Rows[i].Cells[0].Value = i + 1;
            }
        }

        public void EditarPersonal(int id) {
            MessageBox.Show("Editar: Id " + id);
        }
        public void EliminarPersonal(int id) { 
            MessageBox.Show("Eliminar: Id " + id);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvUsuarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn) {
                var filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];
                var idPersonal = filaSeleccionada.Cells["isPersonal"].Value;


                if (dgvUsuarios.Columns[e.ColumnIndex].HeaderText == "Editar") 
                {
                    EditarPersonal((int)idPersonal);
                }

                if (dgvUsuarios.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    EliminarPersonal((int)idPersonal);
                }

            }
        }
            
    }
}

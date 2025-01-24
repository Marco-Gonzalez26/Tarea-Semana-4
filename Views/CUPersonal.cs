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
            FrmPersonal frmPersonal = new FrmPersonal("n", 0);

            frmPersonal.Show();
        }

        private void CUPersonal_Load(object sender, EventArgs e)
        {
            /* Llamar al cls personal y 
             * cargar el procedimiento donde se muestren todos los registros
            */
            fillGridView(1);

        }

        /*
         int number = Parametro para identificar el tipo de carga de la grilla
        number = 1; llamar a getAll()
        number = 2; llamar a search()
         */
        public void fillGridView(int number)
        {
            var logicaPersonal = new cls_Personal();

            dgvUsuarios.DataSource = "";
            var autoIncrement = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dgvUsuarios.Columns.Add(autoIncrement);

            if (number == 1)
            {

                dgvUsuarios.DataSource = logicaPersonal.getAll();
            }
            else if (number == 2)
            {
                dgvUsuarios.DataSource = logicaPersonal.search(txtBuscarUsuario.Text.Trim());

            }


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

        public void EditarPersonal(int id)
        {
            
            FrmPersonal frmPersonal = new FrmPersonal("e", id);
            frmPersonal.ShowDialog();
        }
        public void EliminarPersonal(int id)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro?", "Eliminar Personal", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cls_Personal logicaPersonal = new cls_Personal();

                if (logicaPersonal.deleteOne(id))
                {
                    MessageBox.Show("Registro se ha eliminado correctamente");
                    this.fillGridView(1);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la eliminación");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvUsuarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];
                var idPersonal = filaSeleccionada.Cells["idPersonal"].Value;


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.fillGridView(2);
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            this.fillGridView(2);

        }
    }
}

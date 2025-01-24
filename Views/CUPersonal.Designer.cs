namespace _01_Primera_Vez.Views
{
    partial class CUPersonal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnNuevoPersonal = new Button();
            btnBuscar = new Button();
            txtBuscarUsuario = new TextBox();
            panel2 = new Panel();
            dgvUsuarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnNuevoPersonal);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 71);
            panel1.TabIndex = 0;
            // 
            // btnNuevoPersonal
            // 
            btnNuevoPersonal.BackColor = Color.FromArgb(1, 154, 162);
            btnNuevoPersonal.FlatAppearance.BorderSize = 0;
            btnNuevoPersonal.FlatStyle = FlatStyle.Flat;
            btnNuevoPersonal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoPersonal.ForeColor = Color.White;
            btnNuevoPersonal.Location = new Point(369, 21);
            btnNuevoPersonal.Name = "btnNuevoPersonal";
            btnNuevoPersonal.Size = new Size(144, 29);
            btnNuevoPersonal.TabIndex = 2;
            btnNuevoPersonal.Text = "Nuevo Personal";
            btnNuevoPersonal.UseVisualStyleBackColor = false;
            btnNuevoPersonal.Click += btnNuevoPersonal_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 0, 152);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(262, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuscarUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtBuscarUsuario.Location = new Point(13, 21);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(243, 29);
            txtBuscarUsuario.TabIndex = 0;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 48);
            panel2.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeight = 50;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 71);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 20;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(532, 381);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.DataBindingComplete += dgvUsuarios_DataBindingComplete;
            // 
            // CUPersonal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dgvUsuarios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CUPersonal";
            Size = new Size(532, 500);
            Load += CUPersonal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private TextBox txtBuscarUsuario;
        private Button btnBuscar;
        private Button btnNuevoPersonal;
    }
}

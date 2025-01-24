namespace _01_Primera_Vez.Views.Usuarios
{
    partial class CU_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CU_Usuarios));
            panelTop = new Panel();
            lblUsersCount = new Label();
            panel1 = new Panel();
            btnBuscarUsuario = new Button();
            label1 = new Label();
            txtBuscarUsuario = new TextBox();
            panelBottom = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNuevoUsuario = new Button();
            lstUsers = new ListBox();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblUsersCount);
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(btnBuscarUsuario);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(txtBuscarUsuario);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(547, 80);
            panelTop.TabIndex = 0;
            // 
            // lblUsersCount
            // 
            lblUsersCount.AutoSize = true;
            lblUsersCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsersCount.ForeColor = Color.FromArgb(0, 0, 39);
            lblUsersCount.Location = new Point(437, 50);
            lblUsersCount.Name = "lblUsersCount";
            lblUsersCount.Size = new Size(112, 21);
            lblUsersCount.TabIndex = 5;
            lblUsersCount.Text = "lblUsersCount";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 152);
            panel1.Location = new Point(29, 61);
            panel1.MaximumSize = new Size(50, 50);
            panel1.MinimumSize = new Size(256, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 10);
            panel1.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(0, 0, 152);
            btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnBuscarUsuario.Image = (Image)resources.GetObject("btnBuscarUsuario.Image");
            btnBuscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarUsuario.Location = new Point(302, 31);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(103, 40);
            btnBuscarUsuario.TabIndex = 2;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 39);
            label1.Location = new Point(29, 8);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 1;
            label1.Text = "Buscar Usuarios: ";
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.BackColor = Color.WhiteSmoke;
            txtBuscarUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarUsuario.Location = new Point(29, 32);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(256, 29);
            txtBuscarUsuario.TabIndex = 0;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Controls.Add(btnNuevoUsuario);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 433);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(547, 86);
            panelBottom.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(227, 38, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(14, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 58);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(1, 154, 162);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(203, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 58);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.Blue;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoUsuario.ForeColor = SystemColors.ControlLightLight;
            btnNuevoUsuario.Image = (Image)resources.GetObject("btnNuevoUsuario.Image");
            btnNuevoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoUsuario.Location = new Point(376, 14);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(148, 58);
            btnNuevoUsuario.TabIndex = 4;
            btnNuevoUsuario.Text = "Añadir";
            btnNuevoUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // lstUsers
            // 
            lstUsers.Dock = DockStyle.Fill;
            lstUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstUsers.ForeColor = Color.FromArgb(0, 0, 39);
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 21;
            lstUsers.Location = new Point(0, 80);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(547, 353);
            lstUsers.TabIndex = 2;
            // 
            // CU_Usuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lstUsers);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CU_Usuarios";
            Size = new Size(547, 519);
            Load += CU_Usuarios_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Button btnBuscarUsuario;
        private Label label1;
        private TextBox txtBuscarUsuario;
        private Panel panel1;
        private Button btnNuevoUsuario;
        private ListBox lstUsers;
        private Label lblUsersCount;
        private Button btnDelete;
        private Button btnEdit;
    }
}

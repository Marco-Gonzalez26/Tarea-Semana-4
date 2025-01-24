namespace _01_Primera_Vez.Views.Personal
{
    partial class FrmPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFrmPersonal = new Label();
            panel1 = new Panel();
            cmbPais = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombresApellidos = new TextBox();
            txtCargo = new TextBox();
            txtSueldo = new TextBox();
            txtCedula = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFrmPersonal
            // 
            lblFrmPersonal.AutoSize = true;
            lblFrmPersonal.Dock = DockStyle.Top;
            lblFrmPersonal.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrmPersonal.ForeColor = Color.FromArgb(0, 0, 42);
            lblFrmPersonal.Location = new Point(0, 0);
            lblFrmPersonal.Name = "lblFrmPersonal";
            lblFrmPersonal.Size = new Size(66, 30);
            lblFrmPersonal.TabIndex = 0;
            lblFrmPersonal.Text = "label1";
            lblFrmPersonal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbPais);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtNombresApellidos);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(txtSueldo);
            panel1.Controls.Add(txtCedula);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 398);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(193, 183);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(260, 29);
            cmbPais.TabIndex = 5;
            cmbPais.Text = "Seleccione un país";
            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            cmbPais.KeyDown += cmbPais_KeyDown;
            cmbPais.KeyPress += cmbPais_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 42);
            label5.Location = new Point(125, 186);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 10;
            label5.Text = "País: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 42);
            label4.Location = new Point(110, 109);
            label4.Name = "label4";
            label4.Size = new Size(62, 21);
            label4.TabIndex = 9;
            label4.Text = "Cargo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 42);
            label3.Location = new Point(50, 147);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 8;
            label3.Text = "Sueldo por hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 42);
            label2.Location = new Point(110, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 7;
            label2.Text = "Cédula: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 42);
            label1.Location = new Point(17, 73);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 6;
            label1.Text = "Nombres y Apellidos:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 0, 142);
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(0, 276);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(515, 61);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(227, 38, 54);
            btnCancelar.Dock = DockStyle.Bottom;
            btnCancelar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(0, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(515, 61);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtNombresApellidos
            // 
            txtNombresApellidos.Location = new Point(193, 73);
            txtNombresApellidos.Name = "txtNombresApellidos";
            txtNombresApellidos.Size = new Size(260, 29);
            txtNombresApellidos.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(193, 109);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(260, 29);
            txtCargo.TabIndex = 3;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(193, 144);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(260, 29);
            txtSueldo.TabIndex = 4;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(193, 38);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(260, 29);
            txtCedula.TabIndex = 0;
            txtCedula.TextChanged += textBox1_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            txtCedula.Leave += txtCedula_Leave;
            // 
            // FrmPersonal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(515, 428);
            Controls.Add(panel1);
            Controls.Add(lblFrmPersonal);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmPersonal";
            Text = "FrmPersonal";
            Load += FrmPersonal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrmPersonal;
        private Panel panel1;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombresApellidos;
        private TextBox txtCargo;
        private TextBox txtSueldo;
        private TextBox txtCedula;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox cmbPais;
        private Label label5;
        private Label label4;
    }
}
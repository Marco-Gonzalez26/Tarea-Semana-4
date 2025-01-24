namespace _01_Primera_Vez.Views.Usuarios
{
    partial class FrmUsuario
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
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardarUsuario = new Button();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardarUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 339);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(227, 38, 54);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(42, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 42);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.BackColor = Color.FromArgb(0, 0, 152);
            btnGuardarUsuario.FlatAppearance.BorderSize = 0;
            btnGuardarUsuario.FlatStyle = FlatStyle.Flat;
            btnGuardarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnGuardarUsuario.Location = new Point(206, 265);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(107, 42);
            btnGuardarUsuario.TabIndex = 14;
            btnGuardarUsuario.Text = "Guardar\r\n";
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 39);
            label3.Location = new Point(42, 169);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 13;
            label3.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(49, 193);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(264, 29);
            txtNombreUsuario.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 39);
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 11;
            label2.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(49, 124);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(264, 29);
            txtCorreo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 39);
            label1.Location = new Point(42, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(264, 29);
            txtNombre.TabIndex = 8;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(355, 339);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "FrmUsuario";
            Text = "Agregar Usuario";
            Load += FrmUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardarUsuario;
        private Label label3;
        private TextBox txtNombreUsuario;
        private Label label2;
        private TextBox txtCorreo;
        private Label label1;
        private TextBox txtNombre;
    }
}
namespace _01_Primera_Vez.Views
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRespaldo = new Button();
            btnRestaurarBD = new Button();
            btnPersonal = new Button();
            btnAsistencia = new Button();
            panel3 = new Panel();
            btnUsuarios = new Button();
            panel2 = new Panel();
            Panel_General = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            Panel_General.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRespaldo);
            panel1.Controls.Add(btnRestaurarBD);
            panel1.Controls.Add(btnPersonal);
            panel1.Controls.Add(btnAsistencia);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 8, 0, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 519);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.FromArgb(0, 0, 39);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(0, 434);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 6;
            label1.Text = "Sistema de Asistencia";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.sistemas;
            pictureBox1.Location = new Point(0, 455);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnRespaldo
            // 
            btnRespaldo.BackColor = Color.FromArgb(0, 0, 152);
            btnRespaldo.Dock = DockStyle.Top;
            btnRespaldo.FlatStyle = FlatStyle.Flat;
            btnRespaldo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRespaldo.ForeColor = SystemColors.Control;
            btnRespaldo.Image = (Image)resources.GetObject("btnRespaldo.Image");
            btnRespaldo.ImageAlign = ContentAlignment.MiddleLeft;
            btnRespaldo.Location = new Point(0, 322);
            btnRespaldo.Margin = new Padding(0, 8, 0, 8);
            btnRespaldo.Name = "btnRespaldo";
            btnRespaldo.Padding = new Padding(16, 0, 16, 0);
            btnRespaldo.Size = new Size(178, 69);
            btnRespaldo.TabIndex = 4;
            btnRespaldo.Text = "Respaldo";
            btnRespaldo.TextAlign = ContentAlignment.MiddleRight;
            btnRespaldo.UseVisualStyleBackColor = false;
            btnRespaldo.Click += btnRespaldo_Click;
            // 
            // btnRestaurarBD
            // 
            btnRestaurarBD.BackColor = Color.FromArgb(0, 0, 152);
            btnRestaurarBD.Dock = DockStyle.Top;
            btnRestaurarBD.FlatStyle = FlatStyle.Flat;
            btnRestaurarBD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurarBD.ForeColor = SystemColors.Control;
            btnRestaurarBD.Image = (Image)resources.GetObject("btnRestaurarBD.Image");
            btnRestaurarBD.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestaurarBD.Location = new Point(0, 254);
            btnRestaurarBD.Margin = new Padding(0, 8, 0, 8);
            btnRestaurarBD.Name = "btnRestaurarBD";
            btnRestaurarBD.Padding = new Padding(16, 0, 16, 0);
            btnRestaurarBD.Size = new Size(178, 68);
            btnRestaurarBD.TabIndex = 3;
            btnRestaurarBD.Text = "Restaurar BD";
            btnRestaurarBD.TextAlign = ContentAlignment.MiddleRight;
            btnRestaurarBD.UseVisualStyleBackColor = false;
            btnRestaurarBD.Click += btnRestaurarBD_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.BackColor = Color.FromArgb(0, 0, 152);
            btnPersonal.Dock = DockStyle.Top;
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPersonal.ForeColor = SystemColors.Control;
            btnPersonal.Image = Properties.Resources.trabajo_en_equipo;
            btnPersonal.ImageAlign = ContentAlignment.MiddleLeft;
            btnPersonal.Location = new Point(0, 186);
            btnPersonal.Margin = new Padding(0, 8, 0, 8);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Padding = new Padding(16, 0, 16, 0);
            btnPersonal.Size = new Size(178, 68);
            btnPersonal.TabIndex = 2;
            btnPersonal.Text = "Personal";
            btnPersonal.TextAlign = ContentAlignment.MiddleRight;
            btnPersonal.UseVisualStyleBackColor = false;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnAsistencia
            // 
            btnAsistencia.BackColor = Color.FromArgb(0, 0, 152);
            btnAsistencia.Dock = DockStyle.Top;
            btnAsistencia.FlatStyle = FlatStyle.Flat;
            btnAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsistencia.ForeColor = SystemColors.Control;
            btnAsistencia.Image = Properties.Resources.lista_de_verificacion;
            btnAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsistencia.Location = new Point(0, 118);
            btnAsistencia.Margin = new Padding(0, 8, 0, 8);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Padding = new Padding(16, 0, 16, 0);
            btnAsistencia.Size = new Size(178, 68);
            btnAsistencia.TabIndex = 1;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.TextAlign = ContentAlignment.MiddleRight;
            btnAsistencia.UseVisualStyleBackColor = false;
            btnAsistencia.Click += btnAsistencia_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnUsuarios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0, 8, 0, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 118);
            panel3.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(0, 0, 152);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = SystemColors.Control;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 50);
            btnUsuarios.Margin = new Padding(0, 8, 0, 8);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(16, 0, 16, 0);
            btnUsuarios.Size = new Size(178, 68);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(218, 247, 166);
            panel2.Controls.Add(Panel_General);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(178, 0);
            panel2.Margin = new Padding(0, 8, 0, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 519);
            panel2.TabIndex = 1;
            // 
            // Panel_General
            // 
            Panel_General.BackColor = Color.White;
            Panel_General.Controls.Add(label2);
            Panel_General.Dock = DockStyle.Fill;
            Panel_General.Location = new Point(0, 0);
            Panel_General.Margin = new Padding(3, 2, 3, 2);
            Panel_General.Name = "Panel_General";
            Panel_General.Size = new Size(547, 519);
            Panel_General.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 39);
            label2.Location = new Point(82, 201);
            label2.Name = "label2";
            label2.Size = new Size(368, 69);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido/a al sistema de control de asistencia";
            label2.Click += label2_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(0, 8, 0, 8);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Panel_General.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnPersonal;
        private Button btnRespaldo;
        private Button btnRestaurarBD;
        private Panel Panel_General;
        private Label label2;
        private Label label1;
        private Button btnUsuarios;
        private Button btnAsistencia;
        private PictureBox pictureBox1;
    }
}
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRespaldo = new System.Windows.Forms.Button();
            this.btnRestaurarBD = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_General = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRespaldo);
            this.panel1.Controls.Add(this.btnRestaurarBD);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 519);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(0, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema de Asistencia";
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.btnRespaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRespaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRespaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnRespaldo.Image")));
            this.btnRespaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRespaldo.Location = new System.Drawing.Point(0, 322);
            this.btnRespaldo.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnRespaldo.Size = new System.Drawing.Size(178, 69);
            this.btnRespaldo.TabIndex = 4;
            this.btnRespaldo.Text = "Respaldo";
            this.btnRespaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldo.UseVisualStyleBackColor = false;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // btnRestaurarBD
            // 
            this.btnRestaurarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.btnRestaurarBD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestaurarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarBD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestaurarBD.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestaurarBD.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarBD.Image")));
            this.btnRestaurarBD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurarBD.Location = new System.Drawing.Point(0, 254);
            this.btnRestaurarBD.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnRestaurarBD.Name = "btnRestaurarBD";
            this.btnRestaurarBD.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnRestaurarBD.Size = new System.Drawing.Size(178, 68);
            this.btnRestaurarBD.TabIndex = 3;
            this.btnRestaurarBD.Text = "Restaurar BD";
            this.btnRestaurarBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestaurarBD.UseVisualStyleBackColor = false;
            this.btnRestaurarBD.Click += new System.EventHandler(this.btnRestaurarBD_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPersonal.Image = global::_01_Primera_Vez.Properties.Resources.trabajo_en_equipo;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(0, 186);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnPersonal.Size = new System.Drawing.Size(178, 68);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.btnAsistencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAsistencia.Image = global::_01_Primera_Vez.Properties.Resources.lista_de_verificacion;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 118);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnAsistencia.Size = new System.Drawing.Size(178, 68);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 118);
            this.panel3.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(152)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 50);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(178, 68);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.Panel_General);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 519);
            this.panel2.TabIndex = 1;
            // 
            // Panel_General
            // 
            this.Panel_General.BackColor = System.Drawing.Color.White;
            this.Panel_General.Controls.Add(this.label2);
            this.Panel_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_General.Location = new System.Drawing.Point(0, 0);
            this.Panel_General.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_General.Name = "Panel_General";
            this.Panel_General.Size = new System.Drawing.Size(547, 519);
            this.Panel_General.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(82, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido/a al sistema de control de asistencia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::_01_Primera_Vez.Properties.Resources.sistemas;
            this.pictureBox1.Location = new System.Drawing.Point(0, 455);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Panel_General.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
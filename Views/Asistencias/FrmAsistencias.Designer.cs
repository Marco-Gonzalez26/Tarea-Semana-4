namespace _01_Primera_Vez.Views.Asistencias
{
    partial class FrmAsistencias
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
            pictureBox = new PictureBox();
            saveButton = new Button();
            label1 = new Label();
            timeBox = new TextBox();
            saveFileDialog = new SaveFileDialog();
            txtcedula = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = SystemColors.ControlDark;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(85, 64);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(455, 204);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(221, 382);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(203, 55);
            saveButton.TabIndex = 1;
            saveButton.Text = "Asistencias";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Snapshot time:";
            // 
            // timeBox
            // 
            timeBox.Location = new Point(221, 14);
            timeBox.Margin = new Padding(4);
            timeBox.Name = "timeBox";
            timeBox.ReadOnly = true;
            timeBox.Size = new Size(175, 23);
            timeBox.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "JPEG images (*.jpg)|*.jpg|PNG images (*.png)|*.png|BMP images (*.bmp)|*.bmp";
            saveFileDialog.Title = "Save snapshot";
            // 
            // txtcedula
            // 
            txtcedula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtcedula.Location = new Point(190, 333);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(255, 32);
            txtcedula.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 304);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(293, 26);
            label2.TabIndex = 5;
            label2.Text = "Ingrese su numero de cedula";
            // 
            // frmAsistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 544);
            Controls.Add(label2);
            Controls.Add(txtcedula);
            Controls.Add(timeBox);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(pictureBox);
            Margin = new Padding(4);
            Name = "frmAsistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snapshot";
            Load += frmAsistencias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label2;
    }
}
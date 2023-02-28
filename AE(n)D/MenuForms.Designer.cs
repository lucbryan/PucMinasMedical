namespace AE_n_D
{
    partial class MenuForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForms));
            this.ButtonConsulta = new System.Windows.Forms.Button();
            this.ButtonPaciente = new System.Windows.Forms.Button();
            this.ButtonMedicos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConsulta
            // 
            this.ButtonConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonConsulta.BackgroundImage = global::AE_n_D.Properties.Resources.Circulo_consulta;
            this.ButtonConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonConsulta.Location = new System.Drawing.Point(925, 332);
            this.ButtonConsulta.Name = "ButtonConsulta";
            this.ButtonConsulta.Size = new System.Drawing.Size(197, 147);
            this.ButtonConsulta.TabIndex = 6;
            this.ButtonConsulta.UseVisualStyleBackColor = false;
            this.ButtonConsulta.Click += new System.EventHandler(this.ButtonConsulta_Click);
            // 
            // ButtonPaciente
            // 
            this.ButtonPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonPaciente.BackgroundImage = global::AE_n_D.Properties.Resources.Circulo_paciente;
            this.ButtonPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPaciente.Location = new System.Drawing.Point(548, 332);
            this.ButtonPaciente.Name = "ButtonPaciente";
            this.ButtonPaciente.Size = new System.Drawing.Size(197, 147);
            this.ButtonPaciente.TabIndex = 5;
            this.ButtonPaciente.UseVisualStyleBackColor = false;
            this.ButtonPaciente.Click += new System.EventHandler(this.ButtonPaciente_Click);
            // 
            // ButtonMedicos
            // 
            this.ButtonMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonMedicos.BackgroundImage = global::AE_n_D.Properties.Resources.Circulo_medico;
            this.ButtonMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMedicos.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButtonMedicos.Location = new System.Drawing.Point(174, 332);
            this.ButtonMedicos.Name = "ButtonMedicos";
            this.ButtonMedicos.Size = new System.Drawing.Size(197, 147);
            this.ButtonMedicos.TabIndex = 4;
            this.ButtonMedicos.UseVisualStyleBackColor = false;
            this.ButtonMedicos.Click += new System.EventHandler(this.ButtonMedicos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::AE_n_D.Properties.Resources.Prancheta;
            this.pictureBox3.Image = global::AE_n_D.Properties.Resources.Prancheta;
            this.pictureBox3.Location = new System.Drawing.Point(928, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AE_n_D.Properties.Resources.Paciente;
            this.pictureBox2.Location = new System.Drawing.Point(551, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AE_n_D.Properties.Resources.Medico;
            this.pictureBox1.Location = new System.Drawing.Point(174, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1358, 737);
            this.Controls.Add(this.ButtonConsulta);
            this.Controls.Add(this.ButtonPaciente);
            this.Controls.Add(this.ButtonMedicos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuForms";
            this.Text = "this slowly..";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ButtonMedicos;
        private System.Windows.Forms.Button ButtonPaciente;
        private System.Windows.Forms.Button ButtonConsulta;
    }
}
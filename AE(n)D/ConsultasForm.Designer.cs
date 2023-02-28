namespace AE_n_D
{
    partial class ConsultasForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasForm));
            this.ConsultasCRTXB = new System.Windows.Forms.RichTextBox();
            this.buttonBuscarC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEspecialidadeC = new System.Windows.Forms.ComboBox();
            this.dataConsultaTXB = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasCRTXB
            // 
            this.ConsultasCRTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConsultasCRTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasCRTXB.Location = new System.Drawing.Point(489, 84);
            this.ConsultasCRTXB.Name = "ConsultasCRTXB";
            this.ConsultasCRTXB.ReadOnly = true;
            this.ConsultasCRTXB.Size = new System.Drawing.Size(306, 341);
            this.ConsultasCRTXB.TabIndex = 13;
            this.ConsultasCRTXB.Text = "";
            // 
            // buttonBuscarC
            // 
            this.buttonBuscarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarC.Location = new System.Drawing.Point(139, 112);
            this.buttonBuscarC.Name = "buttonBuscarC";
            this.buttonBuscarC.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarC.TabIndex = 12;
            this.buttonBuscarC.Text = "Buscar";
            this.buttonBuscarC.UseVisualStyleBackColor = false;
            this.buttonBuscarC.Click += new System.EventHandler(this.ButtonBuscarC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(526, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data consulta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Especialidade:";
            // 
            // comboBoxEspecialidadeC
            // 
            this.comboBoxEspecialidadeC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxEspecialidadeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEspecialidadeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEspecialidadeC.FormattingEnabled = true;
            this.comboBoxEspecialidadeC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxEspecialidadeC.Location = new System.Drawing.Point(191, 36);
            this.comboBoxEspecialidadeC.Name = "comboBoxEspecialidadeC";
            this.comboBoxEspecialidadeC.Size = new System.Drawing.Size(123, 24);
            this.comboBoxEspecialidadeC.TabIndex = 8;
            // 
            // dataConsultaTXB
            // 
            this.dataConsultaTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataConsultaTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataConsultaTXB.Location = new System.Drawing.Point(191, 69);
            this.dataConsultaTXB.Name = "dataConsultaTXB";
            this.dataConsultaTXB.Size = new System.Drawing.Size(123, 22);
            this.dataConsultaTXB.TabIndex = 7;
            this.dataConsultaTXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelData.Location = new System.Drawing.Point(645, 57);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 24);
            this.labelData.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.ConsultasCRTXB);
            this.Controls.Add(this.buttonBuscarC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEspecialidadeC);
            this.Controls.Add(this.dataConsultaTXB);
            this.Name = "ConsultasForm";
            this.Text = "charming";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsultasCRTXB;
        private System.Windows.Forms.Button buttonBuscarC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEspecialidadeC;
        private System.Windows.Forms.TextBox dataConsultaTXB;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
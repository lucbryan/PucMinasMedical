namespace AE_n_D
{
    partial class PacienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacienteForm));
            this.ConsultasPacientesRTXB = new System.Windows.Forms.RichTextBox();
            this.buttonBuscarP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDPacienteTB = new System.Windows.Forms.TextBox();
            this.listViewPaciente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ConsultasPacientesRTXB
            // 
            this.ConsultasPacientesRTXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConsultasPacientesRTXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasPacientesRTXB.Location = new System.Drawing.Point(477, 141);
            this.ConsultasPacientesRTXB.Name = "ConsultasPacientesRTXB";
            this.ConsultasPacientesRTXB.ReadOnly = true;
            this.ConsultasPacientesRTXB.Size = new System.Drawing.Size(306, 341);
            this.ConsultasPacientesRTXB.TabIndex = 13;
            this.ConsultasPacientesRTXB.Text = "";
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBuscarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarP.Location = new System.Drawing.Point(137, 72);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarP.TabIndex = 12;
            this.buttonBuscarP.Text = "Buscar";
            this.buttonBuscarP.UseVisualStyleBackColor = false;
            this.buttonBuscarP.Click += new System.EventHandler(this.ButtonBuscarP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(577, 114);
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
            this.label2.Location = new System.Drawing.Point(58, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Identificador:";
            // 
            // IDPacienteTB
            // 
            this.IDPacienteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IDPacienteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDPacienteTB.Location = new System.Drawing.Point(189, 29);
            this.IDPacienteTB.Name = "IDPacienteTB";
            this.IDPacienteTB.Size = new System.Drawing.Size(123, 22);
            this.IDPacienteTB.TabIndex = 7;
            this.IDPacienteTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listViewPaciente
            // 
            this.listViewPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewPaciente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViewPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPaciente.Location = new System.Drawing.Point(448, 29);
            this.listViewPaciente.Name = "listViewPaciente";
            this.listViewPaciente.Size = new System.Drawing.Size(357, 78);
            this.listViewPaciente.TabIndex = 6;
            this.listViewPaciente.UseCompatibleStateImageBehavior = false;
            this.listViewPaciente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total pago";
            this.columnHeader4.Width = 106;
            // 
            // PacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 498);
            this.Controls.Add(this.ConsultasPacientesRTXB);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDPacienteTB);
            this.Controls.Add(this.listViewPaciente);
            this.Name = "PacienteForm";
            this.Text = "wtver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsultasPacientesRTXB;
        private System.Windows.Forms.Button buttonBuscarP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDPacienteTB;
        private System.Windows.Forms.ListView listViewPaciente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
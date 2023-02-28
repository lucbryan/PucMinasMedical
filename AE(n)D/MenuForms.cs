using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE_n_D
{
    public partial class MenuForms : Form
    {
        private HashPacientes hashPacientes;
        private HashMedicos hashMedicos;

        public MenuForms()
        {
            InitializeComponent();
        }

        internal void HashM(HashMedicos hashMedicos) { this.hashMedicos = hashMedicos; }
        internal void HashP(HashPacientes hashPacientes) { this.hashPacientes = hashPacientes; }

        private void ButtonMedicos_Click(object sender, EventArgs e)
        {
            // Inicia o forms para a busca dos médicos.
            MedicoForm medicoForm = new MedicoForm();
            medicoForm.HashMedicos(hashMedicos);
            medicoForm.ShowDialog();
        }
        private void ButtonPaciente_Click(object sender, EventArgs e)
        {
            // Inicia o forms para a busca de pacientes.
            PacienteForm pacienteForm = new PacienteForm();
            pacienteForm.HashPacientes(hashPacientes);
            pacienteForm.ShowDialog();
        }
        private void ButtonConsulta_Click(object sender, EventArgs e)
        {
            // Inicia o forms para a busca de consultas.

            ConsultasForm consultasForm = new ConsultasForm();
            consultasForm.HashMedicos(hashMedicos);
            consultasForm.ShowDialog();
        }
    }
}

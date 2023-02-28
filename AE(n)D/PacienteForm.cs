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
    public partial class PacienteForm : Form
    {
        public PacienteForm()
        {
            InitializeComponent();
        }

        private HashPacientes hashPacientes = new HashPacientes();
        internal void HashPacientes(HashPacientes hashPacientes) { this.hashPacientes = hashPacientes; }


        private void ButtonBuscarP_Click(object sender, EventArgs e)
        {
            // Busca o paciente através do identificador.
            try
            {

                int id = Convert.ToInt32(IDPacienteTB.Text);
                Paciente paciente = hashPacientes.Pesquisar(id);
                Preencher(paciente);
                PreencherConsultas(paciente);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void Preencher(Paciente paciente)
        {
            listViewPaciente.Items.Clear();
            ListViewItem item = new ListViewItem
            {
                Text = (paciente.Nome)
            };
            item.SubItems.Add(paciente.Id.ToString());
            item.SubItems.Add(paciente.ValorTotal.ToString("c"));
            listViewPaciente.Items.Add(item);
        }
        private void PreencherConsultas(Paciente paciente)
        {
            string consultas = "";
            foreach (var item in paciente.Historico)
            {
                consultas += item.ToString() + "\n";
            }
            ConsultasPacientesRTXB.Text = consultas;
        }
    }
}


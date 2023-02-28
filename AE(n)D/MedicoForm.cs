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
    public partial class MedicoForm : Form
    {
        public MedicoForm()
        {
            InitializeComponent();
        }

        private HashMedicos hashMedicos = new HashMedicos();
        internal void HashMedicos(HashMedicos hashMedicos) { this.hashMedicos = hashMedicos; }

        private void ButtonBuscarM_Click(object sender, EventArgs e)
        {
            // Busca o médico através do identificador e da especialidade informados pelo usuário.

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                int especialidade = Convert.ToInt32(comboBoxEspecialidade.Text);

                Medico medico = hashMedicos.Pesquisar(especialidade, id);
                Preencher(medico);
                PreencherConsultas(medico);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void Preencher(Medico medico)
        {
            listViewMedico.Items.Clear();
            ListViewItem item = new ListViewItem
            {
                Text = (medico.Nome)
            };
            item.SubItems.Add(medico.Id.ToString());
            item.SubItems.Add(medico.Especialidade.ToString());
            item.SubItems.Add(medico.CalcularSalario().ToString("c"));
            listViewMedico.Items.Add(item);
        }
        private void PreencherConsultas(Medico medico)
        {
            string consultas = "";
            foreach(var item in medico.ListaConsultas)
            {
                consultas += item.ToString() + "\n"; 
            }
            ConsultasRTXB.Text = consultas;
        }
    }
}

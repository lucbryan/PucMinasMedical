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
    public partial class ConsultasForm : Form
    {
        public ConsultasForm()
        {
            InitializeComponent();
        }

        private HashMedicos hashMedicos = new HashMedicos();
        internal void HashMedicos(HashMedicos hashMedicos) { this.hashMedicos = hashMedicos; }
        private void ButtonBuscarC_Click(object sender, EventArgs e)
        {
            // Busca todas as consultas da especialidade e data informada.
            try
            {
                string data = dataConsultaTXB.Text;
                int especialidade = Convert.ToInt32(comboBoxEspecialidadeC.Text);
                string consultas = hashMedicos.BuscarConsultas(especialidade, data);
                if (consultas != "")
                {
                    labelData.Text = dataConsultaTXB.Text;
                    errorProvider1.Clear();
                    PreencherConsultas(consultas);
                }
                else
                {
                    labelData.Text = "";
                    errorProvider1.SetError(dataConsultaTXB, "Insira uma data válida.");
                    ConsultasCRTXB.Clear();
                }
            }
            catch (Exception error)
            {
                labelData.Text = "";
                MessageBox.Show(error.Message);
            }
        }
        private void PreencherConsultas(string consultas)
        {
            ConsultasCRTXB.Text = consultas;
        }

    }
}


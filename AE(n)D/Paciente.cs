using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class Paciente
    {
        private int id;
        private string nome;
        private int tipo;
        public Paciente Proximo;
        private double valorPago = new double();
        private List<Consulta> historicoConsultas = new List<Consulta>();

        public int Id { get { return id; }set { id = value; } }
        public int Tipo { get { return tipo; } set { tipo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public double ValorTotal { get { return valorPago; } set { valorPago = value; } }
        public List<Consulta> Historico { get { return historicoConsultas; } set { historicoConsultas = value; } }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.", id, nome, tipo);
        }
    }
}

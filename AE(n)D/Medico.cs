using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class Medico
    {
        private int id;
        private string nome;
        public Medico Proximo;
        private int especialidade;
        private double valorTotal = new double();
        private List<Consulta> listaConsultas = new List<Consulta>();


        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public double ValorTotal { get { return valorTotal; } set { valorTotal = value; } }
        public int Especialidade { get { return especialidade; } set { especialidade = value; } }
        public List<Consulta> ListaConsultas { get { return listaConsultas; } set { listaConsultas = value; } }

        public double CalcularSalario()
        {
            return ((valorTotal * 80) / 100);
        }
        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.", id, nome, especialidade);
        }


    }
}

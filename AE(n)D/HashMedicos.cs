using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class HashMedicos
    {
        private const int tamanho = 10;
        private ListaMedicos[] listaMedicos;
        private ListaMedicos[] ListaMedicos { get { return listaMedicos; } }

        public HashMedicos()
        {
            listaMedicos = new ListaMedicos[tamanho];
        }
        public void Inserir(Medico novosMedicos)
        {
            if (listaMedicos[novosMedicos.Especialidade-1] == null)
            { listaMedicos[novosMedicos.Especialidade-1] = new ListaMedicos(); }
            listaMedicos[novosMedicos.Especialidade-1].Inserir(novosMedicos);
        }
        public Medico Pesquisar(int especialidade, int id)
        {
            Medico medico = listaMedicos[especialidade-1].Pesquisar(id);
            return medico;
        }
        public Medico PesquisarMenor(int especialidade)
        {
            // retorna o médico com a menor quantidade de consultas dentre os demais de sua especialidade.
            return listaMedicos[especialidade-1].BuscaMenor();
        }
        public string BuscarConsultas(int especialidade, string data)
        {
            // retorna todas as consultas de uma especialidade específica em uma determinada data.
            return listaMedicos[especialidade - 1].BuscarData(data);
        }

    }
}

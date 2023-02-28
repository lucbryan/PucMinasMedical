using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class HashPacientes
    {
        private const int tamanho = 2500;
        private ListaPacientes[] listaPaciente;

        public HashPacientes()
        {
            listaPaciente = new ListaPacientes[tamanho];
        }
        private int FuncaoHash(int id)
        {
            int key = id % tamanho;
            return key;
        }
        public Paciente Pesquisar(int id)
        {
            Paciente paciente = listaPaciente[FuncaoHash(id)].Pesquisar(id);
            return paciente;
        }
        public void Inserir(Paciente novoPaciente)
        {
            int pos = FuncaoHash(novoPaciente.Id);
            if (listaPaciente[pos] == null)
            { listaPaciente[pos] = new ListaPacientes(); }
            listaPaciente[pos].Inserir(novoPaciente);

        }
        public Paciente InserirConsulta(Consulta consulta)
        {
            // Busca o paciente pelo identificador e insere a consulta em seu histórico.
            Paciente paciente = Pesquisar(consulta.Id);
            if (paciente != null && paciente.Id == consulta.Id)
            {
                paciente.ValorTotal += consulta.Valor;
                paciente.Historico.Add(consulta);
                return paciente;
            }
            return null;
        }
    }
}




using System;
using System.Collections.Generic;
using static System.Console;
using System.Text;
using System.IO;

namespace AE_n_D
{
    class Dados
    {
        private Boolean loaded = false;
        private string[] dados = new string[0];
        private HashMedicos hashMedicos = new HashMedicos();
        private HashPacientes hashPacientes = new HashPacientes();

        public HashMedicos GetMedicos() { return hashMedicos; }
        public HashPacientes GetPacientes() { return hashPacientes; }
        public Boolean GetValidacao { get { return loaded; } }


        private EscalonadorConsulta Escalonador = new EscalonadorConsulta();
        private StreamReader leitorPacientes = new StreamReader(@"Dados/AEDpacientes.txt");
        private StreamReader leitorMedicos = new StreamReader(@"Dados/AEDmedicos.txt");
        private StreamReader leitorConsultas = new StreamReader(@"Dados/AEDconsultas.txt");

        public void CarregarPacientes()
        {
            while (!leitorPacientes.EndOfStream)
            {
                dados = leitorPacientes.ReadLine().Split(';');

                Paciente paciente = new Paciente
                {
                    Id = Convert.ToInt32(dados[0]),
                    Nome = dados[1],
                    Tipo = Convert.ToInt32(dados[2])
                };
                hashPacientes.Inserir(paciente);
            }
            leitorPacientes.Close();
        }
        public void CarregarMedicos()
        {
            while (!leitorMedicos.EndOfStream)
            {
                dados = leitorMedicos.ReadLine().Split(';');

                Medico medico = new Medico
                {
                    Id = Convert.ToInt32(dados[0]),
                    Nome = dados[1],
                    Especialidade = Convert.ToInt32(dados[2])
                };

                hashMedicos.Inserir(medico);
            }
            leitorMedicos.Close();
        }
        public void CarregarConsultas()
        {
            while (!leitorConsultas.EndOfStream)
            {
                dados = leitorConsultas.ReadLine().Split(';');
                Consulta consulta = new Consulta
                {
                    Especialidade = Convert.ToInt32(dados[0]),
                    Id = Convert.ToInt32(dados[2]),
                    Tipo = Convert.ToChar(dados[1]),
                    Data = Convert.ToDateTime(dados[3])
                };
                switch (consulta.Tipo)
                {
                    case '0':
                        consulta.Valor = 50;
                        break;
                    case '1':
                        consulta.Valor = 100;
                        break;
                }
                hashMedicos = Escalonador.Escalonar(consulta, hashMedicos);
                hashPacientes.InserirConsulta(consulta);
            }
            leitorConsultas.Close();
            loaded = true;
        }

    }
}
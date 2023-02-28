using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class ModuloPesquisa
    {
        public void BuscarMedico(HashMedicos hashMedicos)
        {
            Console.WriteLine("Qual a especialidade? ");
            Console.WriteLine("Qual a id? ");
            Medico medico = hashMedicos.Pesquisar(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(medico.ToString());
            //medico.ListaConsultas.Imprimir();
        }
        public void BuscarPaciente(HashPacientes hashPacientes)
        {
            Console.WriteLine("Qual a id? ");
            Paciente paciente = hashPacientes.Pesquisar(int.Parse(Console.ReadLine()));
            Console.WriteLine(paciente.ToString());
            //paciente.HistoricoConsultas.Imprimir();

        }
        public void BuscarConsultas(HashMedicos hashMedicos)
        {
            Console.WriteLine("Qual a especialidade? ");
            Console.WriteLine("Qual a data? ");
            //string consultas = hashMedicos.PesquisarData(int.Parse(Console.ReadLine()), Console.ReadLine());
            //Console.WriteLine(consultas);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class EscalonadorConsulta
    {
        public HashMedicos Escalonar(Consulta consulta, HashMedicos hashMedicos)
        {
            Medico medico = hashMedicos.PesquisarMenor(consulta.Especialidade);
            medico.ListaConsultas.Add(consulta);
            medico.ValorTotal += consulta.Valor;
            return hashMedicos;
        }
    }
}

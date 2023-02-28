using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class SistemaClinica
    {
        private HashMedicos hashMedicos;
        private Dados dados = new Dados();
        private HashPacientes hashPacientes;

        public Dados GetDados { get { return dados; } }
        public SistemaClinica()
        {
            // Carrega os dados e inicializa o menu de buscas
            dados.CarregarPacientes();
            dados.CarregarMedicos();
            dados.CarregarConsultas();

            hashPacientes = dados.GetPacientes();
            hashMedicos = dados.GetMedicos();

            MenuForms form2 = new MenuForms();

            form2.HashM(hashMedicos);
            form2.HashP(hashPacientes);
            form2.ShowDialog();

        }


    }

}


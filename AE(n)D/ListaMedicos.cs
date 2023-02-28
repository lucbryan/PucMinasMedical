using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class ListaMedicos
    {
        private Medico primeiro;
        private Medico ultimo;
        private Medico aux;
        private int contador;

        public int GetContador { get { return contador; } }

        public ListaMedicos()
        {
            primeiro = new Medico();
            ultimo = primeiro;
        }
        public void Inserir(Medico novo)
        {
            ultimo.Proximo = novo;
            ultimo = ultimo.Proximo;
            contador++;
        }
        public Medico Pesquisar(int id)
        {
            if (Vazia() == true)
            { return null; }
            else
            {
                aux = primeiro.Proximo;
                while (aux != null)
                {
                    if (aux.Id == id)
                    {
                        return aux;
                    }
                    else
                    {
                        aux = aux.Proximo;
                    }
                }
                return aux;
            }
        }
        public Boolean Vazia()
        {
            if (primeiro == ultimo)
                return true;
            else
                return false;
        }

        public Medico BuscaMenor()
        {
            // Busca o medico cm a menor quantidade de consultas.
            if (Vazia() == true)
            { return null; }
            else
            {
                Medico menorM = new Medico();
                int menor = int.MaxValue;
                aux = primeiro.Proximo;
                while (aux != null)
                {
                    if (aux.ListaConsultas.Count < menor)
                    {
                        menorM = aux;
                        menor = aux.ListaConsultas.Count;
                    }
                    aux = aux.Proximo;
                }
                return menorM;

            }
        }
        public void Imprimir()
        {
            if (Vazia() == true)
            {; }
            else
            {
                aux = primeiro.Proximo;
                while (aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }

            }
        }
        public string BuscarData(string data)
        {
            // Busca dentre os médicos todas as consultas compativeis com a data de entrada do usuário.
            if(Vazia() == true) { return ""; }
            else
            {
                string consultas = "";
                aux = primeiro.Proximo;
                while(aux != null)
                {
                    foreach(var consulta in aux.ListaConsultas)
                    {
                        if(consulta.Data.ToShortDateString() == data)
                        {
                            consultas += consulta.ToString() + "\n";
                        }
                    }
                    aux = aux.Proximo;
                }
                return consultas;
            }
        }

    }
}
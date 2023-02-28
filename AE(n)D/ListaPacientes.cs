using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
    class ListaPacientes 
    {
        private Paciente primeiro;
        private Paciente ultimo;
        private Paciente aux;
        private int contador;

        public ListaPacientes()
        {
            primeiro = new Paciente();
            ultimo = primeiro;
            ultimo.Proximo = primeiro;
        }
        public Boolean Vazia()
        {
            if (primeiro == ultimo)
                return true;
            else
                return false;
        }
        public void Inserir(Paciente novo)
        {
            ultimo.Proximo = novo;
            ultimo = ultimo.Proximo;
            contador++;
        }
        public Paciente Pesquisar(int id)
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


    }
}

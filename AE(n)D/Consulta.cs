using System;
using System.Collections.Generic;
using System.Text;

namespace AE_n_D
{
     class Consulta
    {
        private int especialidade;
        private char tipo;
        private DateTime data;
        private double valor;
        private int id;

        public int Especialidade { get { return especialidade; } set { especialidade = value; } }
        public char Tipo { get { return tipo; } set { tipo = value; } }
        public int Id { get { return id; } set { id = value; } }
        public DateTime Data { get { return data; } set { data = value; } }
        public double Valor { get { return valor; } set { valor = value; } }

        public override string ToString()
        {
            return string.Format("{0} .{1} .{2} .{3} .{4}.", especialidade, tipo, id, data.ToShortDateString(), valor.ToString("c"));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAgenda
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }

        public override string ToString()
        {
            return $"{Dia}/{Mes}/{Ano}";
        }
    }
}

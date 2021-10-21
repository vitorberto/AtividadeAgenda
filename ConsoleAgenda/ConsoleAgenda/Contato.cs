using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAgenda
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public int getIdade()
        {
            return 2021 - dtNasc.Ano;
        }

        public override string ToString()
        {
            return 
                $"Email: {Email}\n" +
                $"Nome: {Nome}\n" +
                $"Telefone: {Telefone}\n";
        }
    }
}

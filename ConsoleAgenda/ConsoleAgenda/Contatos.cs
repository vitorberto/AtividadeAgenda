using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAgenda
{
    class Contatos
    {
        private List<Contato> agenda;

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        internal List<Contato> Agenda { get => agenda; set => agenda = value; }

        public bool adicionar(Contato c)
        {
            Agenda.Add(c);
            return true;
        }

        public Contato pesquisar(string nome)
        {
            return Agenda.Find(x => x.Nome.Contains(nome));
        }

        public bool alterar(string nome, Contato contatoNovo)
        {
            Contato contato = pesquisar(nome);
            if (contato != null)
            {
                int index = Agenda.IndexOf(contato);
                Agenda[index] = contatoNovo;
                return true;
            }

            return false;
        }

        public bool remover(Contato c)
        {
            return Agenda.Remove(c);
        }

        public bool Equals(Contato contato1, Contato contato2)
        {
            return contato1 == contato2;
        }

        public void Listar()
        {
            Console.WriteLine("Listando os contatos salvos\n");
            foreach (Contato contato in agenda)
            {
                Console.WriteLine(contato.ToString());
            }
        }
    }
}

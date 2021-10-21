using System;

namespace ConsoleAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecao = 0;
            Contatos agenda = new Contatos();

            do
            {
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("" +
                    "0. Sair\n" +
                    "1. Adicionar contato\n" +
                    "2. Pesquisar contato\n" +
                    "3. Alterar contato\n" +
                    "4. Remover contato\n" +
                    "5. Listar contatos\n");
                selecao = int.Parse(Console.ReadLine());

                if (selecao == 1)
                {
                    string nome, email, telefone;
                    int dDia, dMes, dAno;
                    Data data;
                    Contato contato;

                    Console.WriteLine("\nDigite o nome do contato");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite o email do contato");
                    email = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do contato");
                    telefone = Console.ReadLine();

                    Console.WriteLine("Digite o dia do nascimento do contato");
                    dDia = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o mes do nascimento do contato");
                    dMes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o ano do nascimento do contato");
                    dAno = int.Parse(Console.ReadLine());

                    data = new Data(dDia, dMes, dAno);

                    contato = new Contato(email, nome, telefone, data);

                    agenda.adicionar(contato);
                }

                else if (selecao == 2)
                {
                    string nome;

                    Console.WriteLine("Digite o nome do contato para a pesquisa");
                    nome = Console.ReadLine();

                    Contato pesquisado = agenda.pesquisar(nome);
                    if (pesquisado == null)
                    {
                        Console.WriteLine("Nenhum contato encontrado");
                    }
                    else
                    {
                        Console.WriteLine(pesquisado.ToString());
                    }
                }

                else if (selecao == 3)
                {
                    string nomeAntigo;

                    Console.WriteLine("Digite o nome do contato que você deseja alterar");
                    nomeAntigo = Console.ReadLine();

                    Contato contatoAntigo = agenda.pesquisar(nomeAntigo);
                    if (contatoAntigo == null)
                    {
                        Console.WriteLine("Nenhum contato encontrado");
                    }
                    else
                    {
                        string nome, email, telefone;
                        int dDia, dMes, dAno;
                        Data data;
                        Contato contatoNovo;

                        Console.WriteLine("Contato encontrado");

                        Console.WriteLine("\nDigite o nome do contato");
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite o email do contato");
                        email = Console.ReadLine();

                        Console.WriteLine("Digite o telefone do contato");
                        telefone = Console.ReadLine();

                        Console.WriteLine("Digite o dia do nascimento do contato");
                        dDia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o mes do nascimento do contato");
                        dMes = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o ano do nascimento do contato");
                        dAno = int.Parse(Console.ReadLine());

                        data = new Data(dDia, dMes, dAno);

                        contatoNovo = new Contato(email, nome, telefone, data);

                        bool resultado = agenda.alterar(nomeAntigo, contatoNovo);

                        if (resultado)
                            Console.WriteLine("Contato alterado com sucesso");
                        else
                            Console.WriteLine("Erro ao atualizar contato");
                    }
                }

                else if (selecao == 4)
                {
                    string nomeContato;
                    Contato contato;

                    Console.WriteLine("Digite o nome do contato que deseja remover");
                    nomeContato = Console.ReadLine();

                    contato = agenda.pesquisar(nomeContato);

                    if (contato == null)
                        Console.WriteLine("Nenhum contato encontrado");
                    else
                    {
                        bool resultado = agenda.remover(contato);
                        if (resultado)
                            Console.WriteLine("Contato removido com sucesso");
                        else
                            Console.WriteLine("Erro ao remover contato");
                    }
                }

                else if (selecao == 5)
                {
                    agenda.Listar();
                }
            } while (selecao != 0);
        }
    }
}

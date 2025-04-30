using System;
using System.Collections.Generic;

namespace library
{
    class Program
    {
        static List<LibraryItem> itens = new List<LibraryItem>();
        static List<Membro> membros = new List<Membro>();
        static List<Transaction> transacoes = new List<Transaction>();

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("\n--- Biblioteca ---");
                Console.WriteLine("1. Cadastrar Livro");
                Console.WriteLine("2. Cadastrar Revista");
                Console.WriteLine("3. Cadastrar Membro");
                Console.WriteLine("4. Realizar Empréstimo");
                Console.WriteLine("5. Exibir Itens");
                Console.WriteLine("6. Exibir Membros");
                Console.WriteLine("7. Exibir Transações");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1: CadastrarLivro(); break;
                    case 2: CadastrarRevista(); break;
                    case 3: CadastrarMembro(); break;
                    case 4: RealizarEmprestimo(); break;
                    case 5: ExibirItens(); break;
                    case 6: ExibirMembros(); break;
                    case 7: ExibirTransacoes(); break;
                    case 0: Console.WriteLine("Encerrando..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
            } while (opcao != 0);
        }

        static void CadastrarLivro()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Ano de Publicação: ");
            string ano = Console.ReadLine();
            Console.Write("Quantidade de Capítulos: ");
            int qtdCap = int.Parse(Console.ReadLine());

            itens.Add(new Livro(titulo, autor, isbn, ano, qtdCap));
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        static void CadastrarRevista()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Ano de Publicação: ");
            string ano = Console.ReadLine();
            Console.Write("Quantidade de Artigos: ");
            int qtdArt = int.Parse(Console.ReadLine());

            itens.Add(new Revista(titulo, autor, isbn, ano, qtdArt));
            Console.WriteLine("Revista cadastrada com sucesso!");
        }

        static void CadastrarMembro()
        {
            Console.Write("ID do Membro: ");
            string id = Console.ReadLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            membros.Add(new Membro { IdDoMembro = id, Nome = nome, Email = email, NumeroDeTelefone = telefone });
            Console.WriteLine("Membro cadastrado com sucesso!");
        }

        static void RealizarEmprestimo()
        {
            Console.Write("ID da Transação: ");
            string transId = Console.ReadLine();
            Console.Write("ID do Membro: ");
            string membroId = Console.ReadLine();
            Console.Write("ISBN do Item: ");
            string itemId = Console.ReadLine();

            transacoes.Add(new Transaction(transId, membroId, itemId));
            Console.WriteLine("Empréstimo registrado com sucesso!");
        }

        static void ExibirItens()
        {
            Console.WriteLine("\n--- Itens da Biblioteca ---");
            foreach (var item in itens)
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
        }

        static void ExibirMembros()
        {
            Console.WriteLine("\n--- Membros ---");
            foreach (var m in membros)
            {
                Console.WriteLine($"ID: {m.IdDoMembro}, Nome: {m.Nome}, Email: {m.Email}, Telefone: {m.NumeroDeTelefone}");
            }
        }

        static void ExibirTransacoes()
        {
            Console.WriteLine("\n--- Transações ---");
            foreach (var t in transacoes)
            {
                Console.WriteLine($"ID Transação: {t.TransactionID}, Membro: {t.MemberID}, Item: {t.LibraryItemID}, Data: {t.BorrowDate}");
            }
        }
    }
}

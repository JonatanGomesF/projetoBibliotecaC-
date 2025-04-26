using System;
using library;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        // Adicionando membros
        biblioteca.AdicionarMembro(new Membro { IdDoMembro = "001", Nome = "Jonatan", Email = "jonatan@gomes.com", NumeroDeTelefone = "99999-0000" });
        biblioteca.AdicionarMembro(new Membro { IdDoMembro = "002", Nome = "Maria", Email = "maria@email.com", NumeroDeTelefone = "88888-0000" });

        Console.WriteLine("\n--- Membros ---");
        biblioteca.ListarMembros();

        // Adicionando itens
        biblioteca.AdicionarItem(new Livro("C# Básico", "Autor A", "ISBN123", "2021", 12));
        biblioteca.AdicionarItem(new Revista("Revista Tech", "Editor B", "ISBN456", "2022", 5));

        Console.WriteLine("\n--- Itens da Biblioteca ---");
        biblioteca.ListarItens();

        // Emprestando
        biblioteca.EmprestarItem("001", "ISBN123");

        // Devolvendo
        biblioteca.DevolverItem("ISBN123");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

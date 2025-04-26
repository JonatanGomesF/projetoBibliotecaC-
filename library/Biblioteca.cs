using System;
using System.Collections.Generic;
using System.Linq;

namespace library
{
    internal class Biblioteca
    {
        private List<Membro> membros = new();
        private List<LibraryItem> itens = new();
        private List<Transaction> transacoes = new();

        public void AdicionarMembro(Membro membro) => membros.Add(membro);
        public void AtualizarMembro(string id, string nome, string email, string telefone)
        {
            var membro = membros.FirstOrDefault(m => m.IdDoMembro == id);
            if (membro != null)
            {
                membro.Nome = nome;
                membro.Email = email;
                membro.NumeroDeTelefone = telefone;
            }
        }
        public void ExcluirMembro(string id)
        {
            var membro = membros.FirstOrDefault(m => m.IdDoMembro == id);
            if (membro != null) membros.Remove(membro);
        }
        public void ListarMembros()
        {
            foreach (var m in membros)
                Console.WriteLine($"{m.IdDoMembro} - {m.Nome}, {m.Email}, {m.NumeroDeTelefone}");
        }

        public void AdicionarItem(LibraryItem item) => itens.Add(item);
        public void AtualizarItem(string isbn, LibraryItem novoItem)
        {
            var index = itens.FindIndex(i => i.ISBN == isbn);
            if (index >= 0) itens[index] = novoItem;
        }
        public void ExcluirItem(string isbn)
        {
            var item = itens.FirstOrDefault(i => i.ISBN == isbn);
            if (item != null) itens.Remove(item);
        }
        public void ListarItens()
        {
            foreach (var item in itens)
                item.DisplayInfo();
        }

        public void EmprestarItem(string memberId, string isbn)
        {
            var item = itens.FirstOrDefault(i => i.ISBN == isbn);
            var membro = membros.FirstOrDefault(m => m.IdDoMembro == memberId);
            if (item == null || membro == null)
            {
                Console.WriteLine("Item ou Membro não encontrado.");
                return;
            }

            var transacao = new Transaction(Guid.NewGuid().ToString(), memberId, isbn);
            transacoes.Add(transacao);
            Console.WriteLine("Item emprestado com sucesso.");
        }

        public void DevolverItem(string isbn)
        {
            var transacao = transacoes.LastOrDefault(t => t.LibraryItemID == isbn && t.ReturnDate == null);
            if (transacao != null)
            {
                transacao.ReturnDate = DateTime.Now;
                Console.WriteLine("Item devolvido com sucesso.");
            }
            else
            {
                Console.WriteLine("Transação não encontrada ou item já devolvido.");
            }
        }
    }
}

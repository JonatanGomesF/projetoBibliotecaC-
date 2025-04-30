using library;

namespace library
{
    public class Livro : LibraryItem
    {
        public int QtdCapitulo { get; set; }

        public Livro(string titulo, string autor, string isbn, string anoPublicacao, int qtdCapitulo)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            QtdCapitulo = qtdCapitulo;
        }
        public override void DisplayInfo()
        {
        base.DisplayInfo();
            Console.WriteLine($"Quantidade de capitulos: {QtdCapitulo}");
        }
    }
}

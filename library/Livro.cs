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
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Ano de Publicação: {AnoPublicacao}, Capítulos: {QtdCapitulo}");
        }
    }
}

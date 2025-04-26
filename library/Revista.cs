using library;

namespace library
{
    internal class Revista : LibraryItem
    {
        public int QtdArtigo { get; set; }
        public Revista(string titulo, string autor, string isbn, string anoPublicacao, int qtdArtigo)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            QtdArtigo = qtdArtigo;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Ano de Publicação: {AnoPublicacao}, Artigos: {QtdArtigo}");
        }
    }
}

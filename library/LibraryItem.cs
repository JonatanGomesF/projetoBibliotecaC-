namespace library
{
    public abstract class LibraryItem
    {
        public virtual string Titulo { get; set; }
        public virtual string Autor { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string AnoPublicacao { get; set; }

        public LibraryItem(string titulo, string autor, string isbn, string anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoPublicacao = anoPublicacao;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Ano: {AnoPublicacao}");
        }
    }
}

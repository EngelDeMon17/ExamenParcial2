using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenParcial2
{
    public class Libro
    {
        string titulo;
        string autor;
        string genero;
        DateTime añopublicacion;

        public Libro()
        {
            titulo = string.Empty;
            autor = string.Empty;
            genero = string.Empty;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Añopublicacion { get => añopublicacion; set => añopublicacion = value; }
    }
}

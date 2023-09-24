internal class Program
{
    private static void Main(string[] args)
    {
        // int?[] args2 = new int?[5];
        // Console.WriteLine(args2[0]);
        LinqQueries queries = new LinqQueries();
        // ImprimirValores(queries.AllCollection());
        // Console.WriteLine("Todos los libros");
        // ImprimirValores(queries.LibrosDespuesDe2000());
        // Console.WriteLine("Libros de android");
        // ImprimirValores(queries.LibrosDeAndroid());
        // Console.WriteLine("android despues de 2005");
        // ImprimirValores(queries.Android2005());
        // Console.WriteLine("Action mas de 250 paginas");
        // ImprimirValores(queries.action250());
        // if (queries.bookStatus())
        // {
        //     Console.WriteLine("El menos uno de los libros esta inactivo");
        // }
        // else
        // {
        //     Console.WriteLine("Todos los libros estan en estado activo");
        // }
        Console.WriteLine(queries.any2005());
    }


    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros = 0;
        // Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N. Paginas", "Fecha publicacion"); foreach (Book book in books)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            registros += 1;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }

    enum Color
    {
        Rojo, Verde
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class LinqQueries
{
    List<Book> lstBooks = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.lstBooks = System.Text.Json.JsonSerializer
            .Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? new List<Book>();
        }
    }
    public IEnumerable<Book> AllCollection()
    {
        return lstBooks;
    }
    /// <summary>
    ///     Metodo que permite seleccionar libros cuyo año de pub mayor 2000
    /// </summary>
    /// <returns>Book</returns>
    public IEnumerable<Book> LibrosDespuesDe2000()
    {
        return from book in lstBooks
               where book.PublishedDate.Year > 200
               select book;
    }
    /// <summary>
    ///     Metodo que permite seleccionar libros cuyo nombre sea android
    /// </summary>
    /// <returns>Book</returns>
    public IEnumerable<Book> LibrosDeAndroid()
    {
        return from book in lstBooks
               where book.Title.Contains("Android")
               select book;
    }
    public IEnumerable<Book> Android2005()
    {
        return from book in lstBooks
               where book.Title.Contains("Android")
               && book.PublishedDate.Year > 2005
               select book;
    }
    public IEnumerable<Book> action250()
    {
        return from book in lstBooks
               where book.Title.Contains("Action")
               && book.PageCount > 250
               select book;
    }
    public bool bookStatus()
    {
        bool retorno = lstBooks.Any(x => x.Status.Contains(""));
        return retorno;
    }
    public IEnumerable<Book> any2005()
    {
        bool retorno = lstBooks.Any(x => x.PublishedDate.Year == 2005);
        if (retorno)
        {
            return from book in lstBooks
                   where book.PublishedDate.Year == 2005
                   select book;
        }
        return default;
    }
}

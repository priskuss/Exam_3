using System.IO;
using System.Text.Json;
using System.Linq;

public class Book
{
    public string title { get; set; }
    public int publication_year { get; set; }
    public string author { get; set; }
    public string isbn { get; set; }
}
public static class MyBooks
{
    private static Book[] books;

    static MyBooks()
    {
        try
        {
            string json_text = File.ReadAllText(@"./books.json");
            books = JsonSerializer.Deserialize<Book[]>(json_text);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            books = new Book[0];
        }
    }

    public static Book[] TheBooks()
    {
        return books.Where(b => b.title.StartsWith("The")).ToArray();
    }

    public static Book[] TAuthors()
    {
        return books.Where(b => b.author.Contains('t')).ToArray();
    }

    public static int BooksAfter1992()
    {
        return books.Where(b => b.publication_year > 1992).Count();
    }

    public static int BooksBefore2004()
    {
        return books.Where(b => b.publication_year < 2004).Count();
    }

    public static string[] IsbnByAuthor(string author)
    {
        return books.Where(b => b.author == author).Select(b => b.isbn).ToArray();
    }

    public static Book[] Alphabetical(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.title).ToArray() : books.OrderByDescending(b => b.title).ToArray();
    }

    public static Book[] Chronological(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.publication_year).ToArray() : books.OrderByDescending(b => b.publication_year).ToArray();
    }

    public static Book[] GroupByLastName()
    {
        return books.OrderBy(b => b.author.Split(' ').Last()).ToArray();
    }

    public static Book[] GroupByFirstName()
    {
        return books.OrderBy(b => b.author.Split(' ').First()).ToArray();
    }
}
namespace Lab7;
class Book
{
    private string title;
    private string author;

    public Book()  // Default Constructor
    {
        title = "Unknown Title";
    }

    public Book(string title)  
    {
        this.title = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }
    
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
  
    public Book(string title, string author)  
    {
        this.title = title;
        this.author = author;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        Book book2 = new Book("Advanced C#"); 
        Console.WriteLine(book2.GetTitle());

        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());

        Book book4= new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());
    }
}
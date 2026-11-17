Book[] books =
{
    new Book("Crime and Punishment", "Fyodor Dostoevsky", 687),
    new Book("Les Misérables", "Victor Hugo", 320),
    new Book("The Alchemist", "Paulo Coelho", 184),
};

Console.WriteLine("ALL BOOKS:");
foreach (Book book in books)
{
    Console.WriteLine(book.Info());
}

Book mostPages = books[0];
foreach (Book book in books)
{
    if (book.Pages > mostPages.Pages)
    {
        mostPages = book;
    }
}
Console.WriteLine();
Console.WriteLine("BOOK WITH MOST PAGES:");
Console.WriteLine(mostPages.Info());
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private int pages;
    public int Pages
    {
       get
        { 
           return pages;
        }

        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Pages must be greater than 0");
            }
            pages = value;
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }

}




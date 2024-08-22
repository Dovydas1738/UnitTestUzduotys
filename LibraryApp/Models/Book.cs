namespace LibraryApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book (string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Book book = obj as Book;
            if (book.Title == Title && book.Year == Year && book.Author == Author) return true;
            return false;
        }
    }
}

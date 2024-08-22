using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Library : ILibrary
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(string title, string author, int year)
        {
            try
            {
                Book newBook = new Book(title, author, year);

                if (Books.Contains(newBook))
                {
                    throw new Exception("Book already exists!");
                }
                else
                {
                    Books.Add(newBook);
                }
     
            }
            catch
            {
                throw new Exception("Check inputs!");
            }
        }

        public void RemoveBook(string title)
        {
            Book foundBook = Books.Find(x => x.Title == title);

            if(foundBook != null)
            {
                Books.Remove(Books.Find(x => x.Title == title));
            }
            else
            {
                throw new Exception("No such book exists!");
            }

        }

        public List<Book> GetBooks()
        {
            return Books;
        }

        public Book FindBookByTitle(string title)
        {
            Book foundBook = Books.Find(x => x.Title == title);

            if (foundBook != null)
            {
                return foundBook;
            }
            else
            {
                throw new Exception("No such item found.");
            }
        }
    }

    public interface ILibrary
    {
        void AddBook(string title, string author, int year);
        void RemoveBook(string title);
        List<Book> GetBooks();
        Book FindBookByTitle(string title);
    }
}

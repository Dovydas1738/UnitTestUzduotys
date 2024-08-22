using LibraryApp.Models;

namespace LibraryAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddBookTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;

            operations.AddBook(title, author, year);

            Assert.Equal(1, operations.GetBooks().Count);
        }

        [Fact]
        public void AddBookFailTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;

            operations.AddBook(title, author, year);

            Assert.Throws<Exception>(()=>operations.AddBook(title, author, year));
        }

        [Fact]
        public void RemoveBookTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;

            operations.AddBook(title, author, year);
            operations.RemoveBook(title);

            Assert.Equal(0, operations.GetBooks().Count);
        }

        [Fact]
        public void RemoveBookFailTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;
            string title2 = "Game of Thrones";

            operations.AddBook(title, author, year);

            Assert.Throws<Exception>(() => operations.RemoveBook(title2));

        }

        [Fact]
        public void GetBookByTitleTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;

            operations.AddBook(title, author, year);
            Book foundBook = operations.FindBookByTitle(title);

            Assert.NotNull(foundBook);
        }

        [Fact]
        public void GetBookByTitleFailTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;
            string title2 = "Game of Thrones";

            operations.AddBook(title, author, year);

            Assert.Throws<Exception>(() => operations.FindBookByTitle(title2));

        }

        [Fact]
        public void GetAllBooksTest()
        {
            ILibrary operations = new Library();
            string title = "Moby Dick";
            string author = "Herman Melville";
            int year = 1851;

            operations.AddBook(title, author, year);

            Assert.NotEqual(0, operations.GetBooks().Count);
            Assert.NotNull(operations.GetBooks());
            Assert.Equal(title, operations.GetBooks()[0].Title);
        }
    }
}
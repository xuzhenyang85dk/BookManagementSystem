using System;
namespace BookManagementSystem
{
	public class Library
	{
        private List<Book> books = new List<Book>();

		public void AddBook()
		{
            Console.Write("What is the name of book?");
            string? title = Console.ReadLine();

            Console.Write("What is author of book?");
            string? author = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author))
            {
                books.Add(new Book(title, author));
                Console.WriteLine("Successfully added! ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invaild characters! ");
                Console.WriteLine();
            }
		}

        public void BorrowBook()
        {
            Console.WriteLine("Provide me the title of book you want to borrow? ");
            string title = Console.ReadLine();

            Book book = books.Find(b => b._title.Equals(title,StringComparison.OrdinalIgnoreCase));
            if(book != null)
            {
                if (!book._isBorrowed)
                {
                    book._isBorrowed = true;
                    Console.WriteLine("Succefully borrowed the book!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Can not find this book! ");
                    Console.WriteLine();
                }
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine("Pls type title of the book that you want to return");
            string title = Console.ReadLine();

            Book book = books.Find(b => b._title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if(book != null)
            {
                if (book._isBorrowed)
                {
                    book._isBorrowed = false;

                    Console.WriteLine("Your book has been returned.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This book haven't been borrowed!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Can not find this book. ");
                Console.WriteLine();
            }
        }

        // show all books, use string 
        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Found no books");
                Console.WriteLine();
                return;
            }
            Console.WriteLine(" === List of books ===");
            Console.WriteLine();

            foreach (var book in books)
            {
                Console.WriteLine(book.GetBookInfo());
                Console.WriteLine();
            }
        }
    }
}


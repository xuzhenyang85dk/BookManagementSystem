// Learning objectives
// Use List<Book> manage object collection
// Property encapsulation and status mangement
using BookManagementSystem;

class Program
{
    static void Main(string[] arg)
    {
        Library _library = new Library();
        bool isRunning = true;
        while(isRunning)
        {
            Console.WriteLine();
            Console.WriteLine("=== Library  Management System ===");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Borrow a book");
            Console.WriteLine("3. Return a book");
            Console.WriteLine("4. Display all books");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Provide me a number");
            Console.WriteLine();

            switch (Console.ReadLine())
        {
            case "1":
                _library.AddBook();
                break;
            case "2":
                _library.BorrowBook();
                break;
            case "3":
                _library.ReturnBook();
                break;
            case "4":
                _library.DisplayBooks();
                break;
        }
      };
    }
}
namespace Task4
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                 Library library = new Library();

                // Adding books to the library
                Console.WriteLine("Adding books to the library\n");
                Console.WriteLine(library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565")));
                Console.WriteLine(library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084")));
                Console.WriteLine(library.AddBook(new Book("1984", "George Orwell", "9780451524935")));
                Console.WriteLine();

                // Searching and borrowing books
                Console.WriteLine("Searching and borrowing books...\n");
                 Console.WriteLine(library.SearchBook("Gatsby"));
                Console.WriteLine(library.SearchBook("George Orwell"));
                Console.WriteLine(library.SearchBook("Mockingbird"));
                Console.WriteLine();
                Console.WriteLine(library.BorrowBook("The Great"));
                Console.WriteLine(library.BorrowBook("1984"));
                Console.WriteLine(library.BorrowBook("Harry Potter"));// This book is not in the library
                Console.WriteLine(library.BorrowBook("The Great Gatsby"));// This book is not in the library
                Console.WriteLine(library.BorrowBook("1984"));

                // Returning books
                Console.WriteLine("\nReturning books...\n");
                 Console.WriteLine(library.ReturnBook("The Great Gatsby"));
                Console.WriteLine(library.ReturnBook("Harry Potter")); // This book is not borrowed

                Console.ReadLine();

            }
        }
    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Library 
    {
        public  List<Book> books = new List<Book>();

        public  string AddBook(Book book)
        {
            books.Add(book);
            book.Availability = true;
            return $"Book : {book.Title} added successfully";
        }

        public  string SearchBook(string search)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(search.ToLower()) || book.Author.ToLower().Contains(search.ToLower()))
                {
                    if (book.Availability)
                    {
                        return $"Book : {book.Title} found";
                    }
                    else
                    {
                        return $"Book : {book.Title} not in library";
                    }
                }
            }
            return $"Book : {search} not found";
        }

        public  string BorrowBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(title.ToLower()) || book.Author.ToLower().Contains(title.ToLower()))
                {
                    if (book.Availability)
                    {
                        book.Availability = false;
                        return $"Book : {book.Title} borrowed successfully";
                    }
                    else
                    {
                        return $"Book : {book.Title} is not in the library";
                    }
                }
            }
            return $"Book : {title} not found";
        }

        public  string ReturnBook(string title)
        {
            bool found = false;
            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(title.ToLower()) || book.Author.ToLower().Contains(title.ToLower()))
                {
                    if (!book.Availability)
                    {
                        book.Availability = true;
                        return $"Book : {book.Title} returned successfully";
                    }
                    else
                    {
                        return $"Book : {book.Title} was not borrowed";
                    }
                }
            }
            return $"Book: {title} not found";
        }
    }
}


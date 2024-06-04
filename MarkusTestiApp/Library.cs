using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkusTestiApp
{
    internal class Library
    {
        List<Book> books= new List<Book>();
        int storeSize = 5;
        BookCategorizer bookCategorizer = new BookCategorizer();
        Library()
        {
      
        }

        void addBook(Book newBook) 
        {
            if (books.Count + 1 > storeSize)
            {
                Console.WriteLine("Too many books");
            }
            else
            {
                if (books.Contains(newBook))
                {
                    Console.WriteLine("Already contains that book!");
                }
                else
                {
                    if (books.Count == 0)
                    {
                        Console.WriteLine("Congratulations! You added first book");
                    }
                    books.Add(newBook);
                    if (newBook.category >=  bookCategories.Count)
                    {
                        Console.WriteLine("Wrong book category!");
                    }
                    else if (newBook.category < 0)
                    {
                        Console.WriteLine("Negative book category! Don't cheat!");
                    }
                    else
                    {
                        if (newBook.category == 0)
                        {
                            bookCategories[0].books.Add(newBook);
                            Console.WriteLine("Added horror book");
                        }
                        if (newBook.category == 1)
                        {
                            bookCategories[1].books.Add(newBook);
                            Console.WriteLine("Added comedy book");
                        }
                        if (newBook.category == 2)
                        {
                            bookCategories[2].books.Add(newBook);
                            Console.WriteLine("Added romance book");
                        }
                        if (newBook.category == 3)
                        {
                            bookCategories[3].books.Add(newBook);
                            Console.WriteLine("Added fantasy book");
                        }
                        if (newBook.category == 4)
                        {
                            bookCategories[4].books.Add(newBook);
                            Console.WriteLine("Added guide book");
                        }
                    }
              
                    //addBookToCategory(newBook);
                }
            }
        }

        public void addBookToCategory(Book newBook)
        {
       
        }


        void addBookMake(Book newBook)
        {
            if (books.Count+ 1 > storeSize)
            {
                Console.WriteLine("Too many books");
            }
            if (books.Count <= storeSize)
            {
                books.Add(newBook);
                Console.WriteLine("Added new book");
            }
            if(books.Count == 0)
            {
                books.Add(newBook);
                Console.WriteLine("Congratulations! You added first book");
            }

            if (books.Contains(newBook))
            {
                Console.WriteLine("Already contains that book!");
            }
        }

        bool canAddBook(Book newBook)
        {
            if (books.Count + 1 > storeSize)
            {
                Console.WriteLine("Too many books");
                return false;
            }
            if (books.Contains(newBook))
            {
                Console.WriteLine("Already contains that book!");
                return false;
            }
            return true;
        }

        void addBookMiika(Book newBook)
        {
            if (!canAddBook(newBook))
            {
                return;
            }
            
            if (books.Count == 0)
            {
                Console.WriteLine("Congratulations! You added first book");
            }
            books.Add(newBook);
               
        }

 
        void categorizeBooks(Book newBook)
        {
     
        }

        bool canAddBookNew(Book newBook)
        {
            if (books.Count + 1 > storeSize)
            {
                Console.WriteLine("Too many books");
                return false;
            }
            else if (books.Contains(newBook))
            {
                Console.WriteLine("Already contains that book!");
                return false;
            }
            return true;

        }

        void addBookNew(Book newBook)
        {
            if (!canAddBookNew(newBook))
                return;
          
            if (books.Count == 0)
            {
                Console.WriteLine("Congratulations! You added first book");
            }
            books.Add(newBook);
            bookCategorizer.categorize(newBook);
        }

    }
}

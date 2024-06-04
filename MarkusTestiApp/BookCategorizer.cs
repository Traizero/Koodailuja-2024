using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkusTestiApp
{
    internal class BookCategorizer
    {
        List<BookCategory> bookCategories = new List<BookCategory>();
        public BookCategorizer()
        {
            bookCategories = new List<BookCategory>();
            for (int i = 0; i < 5; i++)
            {
                BookCategory category = new BookCategory();
                category.categoryType = i;
                bookCategories.Add(category);
            }
        }

        bool canCategorizeBook(Book newBook)
        {
            if (newBook.category >= bookCategories.Count)
            {
                Console.WriteLine("Wrong book category!");
                return false;
            }
            else if (newBook.category < 0)
            {
                Console.WriteLine("Negative book category! Don't cheat!");
                return false;
            }
            return true;
        }
        public void categorize(Book newBook)
        {
            if (!canCategorizeBook(newBook))
                return;
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
    }
}

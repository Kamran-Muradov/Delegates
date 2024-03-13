using Delegates_Homework.Data;
using Delegates_Homework.Models;

namespace Delegates_Homework.Services
{
    public class BookService : IBookService
    {
        public List<Book> GetAll()
        {
            {
                return AppDbContext.books;
            }
        }

        public int Count(Predicate<Book> expression)
        {
            int count = 0;

            foreach (var item in AppDbContext.books)
            {
                if (expression(item))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

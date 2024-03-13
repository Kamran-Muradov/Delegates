using Delegates_Homework.Models;

namespace Delegates_Homework.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        int Count(Predicate<Book> expression);
    }
}

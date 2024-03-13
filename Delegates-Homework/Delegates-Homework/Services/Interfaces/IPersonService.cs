using Delegates_Homework.Models;

namespace Delegates_Homework.Services.Interfaces
{
    public interface IPersonService
    {
        List<Person> GetAll();
        List<Person> Search(Predicate<Person> expression);
    }
}

using Delegates_Homework.Data;
using Delegates_Homework.Models;
using Delegates_Homework.Services.Interfaces;

namespace Delegates_Homework.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            return AppDbContext.people;
        }

        public List<Person> Search(Predicate<Person> expression)
        {
            List<Person> foundPeople = new();

            foreach (var item in AppDbContext.people)
            {
                if (expression(item))
                {
                    foundPeople.Add(item);
                }
            }

            return foundPeople;
        }
    }
}

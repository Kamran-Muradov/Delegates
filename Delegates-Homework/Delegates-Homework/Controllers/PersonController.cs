using Delegates_Homework.Services;
using Delegates_Homework.Services.Interfaces;

namespace Delegates_Homework.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        public void GetAll()
        {
            var response = _personService.GetAll();

            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address);
            }
        }

        public void FilterBySalary()
        {
            var response = _personService.Search(m => m.Salary > 1000);

            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address);
            }
        }
    }
}

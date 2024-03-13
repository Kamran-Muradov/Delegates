using Delegates_Homework.Models;

namespace Delegates_Homework.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id = null);
        List<Customer> GetAllByAge(int age);
        int GetCount();
        List<Customer> OrderByAge(string ordering);
        List<Customer> Search(Func<Customer, bool> expression);

    }
}

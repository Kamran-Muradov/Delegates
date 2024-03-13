using Delegates_Homework.Data;
using Delegates_Homework.Helpers.Enums;
using Delegates_Homework.Models;
using Delegates_Homework.Services.Interfaces;

namespace Delegates_Homework.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id = null)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(string ordering)
        {
            switch (ordering)
            {
                case nameof(OrderType.asc):
                    return AppDbContext.customers.OrderBy(m => m.Age).ToList();
                case nameof(OrderType.desc):
                    return AppDbContext.customers.OrderByDescending(m => m.Age).ToList();
            }

            return AppDbContext.customers;
        }

        public List<Customer> Search(Func<Customer, bool> expression)
        {
            //List<Customer> foundCustomers = new List<Customer>();

            //foreach (var item in AppDbContext.customers)
            //{
            //    if (predicate(item))
            //    {
            //        foundCustomers.Add(item);
            //    }
            //}

            //return foundCustomers;

            return AppDbContext.customers.Where(expression).ToList();
        }
    }
}

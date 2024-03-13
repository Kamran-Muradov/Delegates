using Delegates_Homework.Models;

namespace Delegates_Homework.Services.Interfaces
{
    internal interface IUserService
    {
        User[] GetAll();
        User GetById(int id);
        void Delete(int id);


    }
}

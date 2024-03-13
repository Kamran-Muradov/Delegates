using Delegates_Homework.Helpers.Constants;
using Delegates_Homework.Helpers.Exceptions;
using Delegates_Homework.Services;
using Delegates_Homework.Services.Interfaces;

namespace Delegates_Homework.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void SignIn()
        {
            string email = "fatimacode.edu.az";
            string password = "fatime5123";

            try
            {
                if (!email.Contains('@'))
                {
                    throw new InvalidEmailException(ResponseMessages.EmailFormat);
                }

                bool response = _accountService.SingIn(email, password);

                if (response)
                    Console.WriteLine("Sign in success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using Delegates_Homework.Services;

namespace Delegates_Homework.Controllers
{
    public class BookController
    {
        private readonly IBookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }
        public void GetAll()
        {
            var response = _bookService.GetAll();

            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.AuthorName);
            }
        }

        public void CountByAuthorName()
        {
            var response = _bookService.Count(m => m.AuthorName == "Nizami");

            Console.WriteLine(response);
        }
    }
}

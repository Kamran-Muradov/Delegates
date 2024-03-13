using Delegates_Homework.Models;

namespace Delegates_Homework.Data
{
    internal class AppDbContext
    {
        public static List<Customer> customers;
        public static List<Person> people;
        public static List<Book> books;

        static AppDbContext()
        {
            customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FullName = "Fexriyye Tagizade",
                    Address = "28 may",
                    Age = 21
                },
                new Customer
                {
                    Id = 2,
                    FullName = "Elmir Qafarzade",
                    Address = "Sahil",
                    Age = 21
                },
                new Customer
                {
                    Id = 3,
                    FullName = "Sirac Memmedov",
                    Address = "Masazir",
                    Age = 23
                },
                new Customer
                {
                    Id = 4,
                    FullName = "Reshad Agayev",
                    Address = "Neftciler",
                    Age = 21
                },
                new Customer
                {
                    Id = 5,
                    FullName = "Behruz Eliyev",
                    Address = "Kurdexani",
                    Age = 33
                },
            };

            people = new List<Person> {
                new() {Id=1, Name="Kamran",Surname="Muradov",Address="Sumqayit",Salary=1500},
                new() {Id=2, Name="Elmir",Surname="Qafarzade",Address="Sahil",Salary=700},
                new() {Id=3, Name="Sirac",Surname="Memmedov",Address="Masazir",Salary=1800},
                new() {Id=4, Name="Reshad",Surname="Agayev",Address="Neftciler",Salary=450},
                new() {Id=5, Name="Behruz",Surname="Eliyev",Address="Kurdexani",Salary=1200},
            };

            books = new List<Book> {
                new() { Id = 1, Name = "Isgendername", AuthorName = "Nizami" } ,
                new() { Id = 2, Name = "Sefiller", AuthorName = "Victor Hugo" },
                new() { Id = 3, Name = "Suc ve ceza", AuthorName = "Fyodor Dostoevsky" },
                new () { Id = 4, Name = "Leyli ve mecnun", AuthorName = "Nizami" },
                new () { Id = 5, Name = "Yeddi gozel", AuthorName = "Nizami" } };
        }
    }
}

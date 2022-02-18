using MVM.Model;

namespace MVM.Data.TestData
{
    public static partial class Employees
    {
       static string  ipUser = "";

        public static List<Employee> player {get; }= new ()
            {
                new Employee { Id = 1, LastName = "Антон", FirstName = "Александрович", Patronymic = "Сергеев", Age = 19, IP = ipUser},
                new Employee { Id = 2, LastName = "Андрей", FirstName = "Евгеньевич", Patronymic = "Александрович", Age = 29, IP = ipUser},
                new Employee { Id = 3, LastName = "Николай", FirstName = "Борисович", Patronymic = "Владимирович", Age = 56, IP = ipUser },
                new Employee { Id = 4, LastName = "Ибрагим", FirstName = "Абдулаевич", Patronymic = "Абдолбин", Age = 81, IP = ipUser },
            };
    }
}

using MVM.Model;

namespace MVM.Services
{
    public class InMemoryEmpData : IEmpData
    {
        private readonly ICollection<Employee> Employees;
        private readonly ILogger<InMemoryEmpData> Logger;
        private int MaxID;

        public InMemoryEmpData(ILogger<InMemoryEmpData> logger)
        {
            Employees = MVM.Data.TestData.Employees.player;
        MaxID = Employees.DefaultIfEmpty().Max(a=> a?.Id ?? 0)+ 1;
            //имитация мак.числа сотрудников первый свободный
            //DefaultIfEmpty-коллекция пустая
        }

        public int Add(Employee employee)
        {
            if(Employees == null)
               throw new ArgumentNullException(nameof(employee));
            if (Employees.Contains(employee))
            {
                return employee.Id;
            }

            employee.Id=MaxID++;
            Employees.Add(employee);
            return employee.Id;
        }

        public bool Delete(int id)
        {
            var t = Employees.FirstOrDefault(x => x.Id == id);
            if (t != null)
            {
                Employees.Remove(t);
                return true;
            }
          
            return false;
        }

        public bool Edit(Employee employee)
        {
            if (Employees == null)
                throw new ArgumentNullException(nameof(employee));
            if (Employees.Contains(employee))
            {
                return true;
            }
            var db_emp =GetById(employee.Id);
            if (db_emp == null)
            {
                Logger.LogWarning("Noy User id= {0}", employee.Id);
                return false;
            }

            db_emp.Id = employee.Id;
            db_emp.FirstName=employee.FirstName;
            db_emp.LastName=employee.LastName;
            db_emp.Patronymic = employee.Patronymic;
            db_emp.Age = employee.Age;
            db_emp.IP=employee.IP;


            return true;
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employees;
        }

        public Employee GetById(int id)
        {
           return Employees.FirstOrDefault(x => x.Id == id);
        }
    }
}

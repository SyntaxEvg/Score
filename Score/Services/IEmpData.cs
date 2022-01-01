using MVM.Model;
using MVM.ViewModel;
using System.Collections.Generic;
using System.Linq;
namespace MVM.Services
{
    public interface IEmpData
    {
        //управления юзерами обработка логики тут 
        //IEnumerable<EmployeeEditViewModel> GetAll();
        //EmployeeEditViewModel GetById(int id);

       public IEnumerable<Employee> GetAll();
       public Employee GetById(int id);       
       public bool Edit(Employee employee);
       public bool Delete(int id);
       public int Add(Employee employee);

    }
}

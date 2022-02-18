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

      IEnumerable<Employee> GetAll();
      Employee? GetById(int id);       
      bool Edit(Employee employee);
      bool Delete(int id);
      int Add(Employee employee);

    }
}

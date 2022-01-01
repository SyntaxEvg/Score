using Microsoft.AspNetCore.Mvc;
using MVM.Model;
using MVM.Services;
using MVM.ViewModel;
using System.Linq;
namespace MVM.Controlles
{
    public class EmployeesController : Controller
    {
        //ICollection<Employee> _employees;
        private  IEmpData EmpData;

        public EmployeesController(IEmpData empData)
        {
            EmpData=empData;
        }


        public IActionResult Index()
        {
           var _employees = EmpData.GetAll();
            var ipUser = HttpContext?.Connection.RemoteIpAddress.ToString() ?? "";
            foreach (var item in _employees)
            {
                item.IP = ipUser;
            }

            return View(_employees);
        }
        //[HttpGet]
        //[Route("Employees/Emplooyees")]
        public IActionResult Details(int id)
        {
            var _player = EmpData.GetById(id);
            if (_player == null) return NotFound("Error");

            return View(_player);
        }

        public IActionResult Create() => View();

        public IActionResult Edit(int? id)
            {
            if (id is null)
            {
                return View(new Employee());
            }
            var _player = EmpData.GetById((int)id);
            if (_player == null) 
                return NotFound("Error");

            var Emp = new EmployeeEditViewModel();
            Emp.Id = _player.Id;
            Emp.FirstName= _player.FirstName;
            Emp.LastName= _player.LastName;
            Emp.Patronymic = _player.Patronymic;
            Emp.Age = _player.Age;

            return View(Emp);
            }

        [HttpPost]
        public IActionResult Edit(EmployeeEditViewModel emp)
        {
           // ModelState.AddModelError("что не нравитсяв модели", "Имя ошибки";
            if (!ModelState.IsValid)
            {
                return View(emp);
            }

              var temp= new Employee
                {
                Id = emp.Id,
                FirstName = emp.FirstName,
                LastName= emp.LastName,
                Patronymic = emp.Patronymic,
                Age = emp.Age,
                IP=emp.IP,
            };
            if (emp.Id == 0)
            {
                EmpData.Add(temp);
            }

            if (EmpData.Edit(temp))
            {
                return RedirectToAction("Index");
            }
            return NotFound();

           
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            if (!EmpData.Delete(id))
                return NotFound();

            //_Logger.LogInformation("Сотрудник с id:{0} удалён", id);

            return RedirectToAction("Index");
        }

        public IActionResult Delete() => View();
    }
}

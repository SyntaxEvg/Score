namespace MVM.ViewModel
{
    public class EmployeeEditViewModel
    {  //нужно для показа   сотрудников  и фильтрации...
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string IP { get; set; }
    }
}

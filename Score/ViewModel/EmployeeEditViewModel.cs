using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVM.ViewModel
{
    public class EmployeeEditViewModel
    {  //нужно для показа   сотрудников  и фильтрации...
         [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Обязательно для заполнения {0}")]
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        [StringLength(40, ErrorMessage ="Длина большая")]
        [RegularExpression("*")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Возраст")]
        [Range(10,88)]
        public int Age { get; set; }
        [Display(Name ="IP adress")]
        public string IP { get; set; }
    }
}

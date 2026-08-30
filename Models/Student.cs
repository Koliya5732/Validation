using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Validation.Models
{
    public class Student
    {
        // ідентифікатор студента
        public int Id { get; set; }

        // ім'я студента
        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Display(Name = "Ім'я студента")]
        public string? Name { get; set; }

        // прізвище студента
        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Display(Name = "Прізвище студента")]
        public string? Surname { get; set; }

        // вік студента
        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Range(15, 60, ErrorMessage = "Вік повинен бути від 15 до 60 років")]
        [Display(Name = "Вік")]
        public int Age { get; set; }

        // середній бал
        [Required(ErrorMessage = "Поле має бути заповнене")]
        [Range(0.0, 12.0, ErrorMessage = "Середній бал повинен бути від 0 до 12")]
        [Display(Name = "Середній бал")]
        public double GPA { get; set; }

        // електронна адреса
        [Required(ErrorMessage = "Поле має бути заповнене")]
        [RegularExpression(
            @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Некоректна адреса")]
        [Remote(
            action: "CheckEmail",
            controller: "Students",
            ErrorMessage = "Email вже використовується")]
        [Display(Name = "Адреса електронної пошти")]
        public string? Email { get; set; }
    

        /* також можна було б додати:
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage="Паролі не збігаються!")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
  
        DataType:
        - Currency        відображає текст як валюту
        - DateTime        відображає дату і час
        - Date            відображає тільки дату, без часу
        - Time            відображає тільки час
        - Text            відображає одностроковий текст
        - MultilineText   відображає багатостроковий текст (елемент textarea)
        - Password        відображає символи з маскуванням
        - Url             відображає рядок URL
        - EmailAddress    відображає електронну адресу
         */
    }
}
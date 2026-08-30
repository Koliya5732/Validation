using System.ComponentModel.DataAnnotations;
using Validation.Annotations;

namespace Validation.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле має бути заповнене.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина рядка має бути від 3 до 50 символів.")]
        [Display(Name = "Назва")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Автор")]
        [MyAuthors(new string[] { "Шилдт", "Троелсен", "Нейгел", "Ріхтер", "Страуструп" }, ErrorMessage = "Невірний автор")]
        public string? Author { get; set; }

        [Required]
        [Display(Name = "Рік")]
        public int Year { get; set; }
    }
}
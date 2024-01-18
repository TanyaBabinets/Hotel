
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class LoginModel1
    {

        [Required(ErrorMessage = "Логин или пароль неверный")]
        [Display(Name = "Введите логин: ")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Пароль или логин неверный")]
        [Display(Name = "Введите пароль: ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}



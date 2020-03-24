using System.ComponentModel.DataAnnotations;

namespace TestWebApplication
{
    public class Account
    {
        [Required(ErrorMessage = "Введите счёт")]
        [RegularExpression(@"[0-9]", ErrorMessage = "Введите правильный счёт")]
        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        [Required(ErrorMessage = "Введите БИК")]
        [RegularExpression(@"[0-9]", ErrorMessage = "Введите правильный БИК")]
        public string BIC { get; set; }

        [Required(ErrorMessage = "Введите остаток на счёте")]
        public double AccountBalance { get; set; }
    }
}
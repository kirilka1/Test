using System.ComponentModel.DataAnnotations;

namespace TestWebApplication
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Введите наименование организации")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Введите ИНН организации")]
        [RegularExpression(@"[0-9]", ErrorMessage = "Введите правильный ИНН")]
        public string INN { get; set; }

        public string Address { get; set; }
    }
}
namespace WebLib.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Books
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        public string title { get; set; }

        [Required(ErrorMessage = "Автор обязателен")]
        public string author { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "'В наличии' должно быть неотрицательным числом")]
        public int availability { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "'Всего' должно быть неотрицательным числом")]
        [CustomValidation(typeof(Books), "ValidateAmount")]
        public int amount { get; set; }

        public static ValidationResult ValidateAmount(int amount, ValidationContext context)
        {
            var instance = context.ObjectInstance as Books;
            if (instance != null && amount < instance.availability)
            {
                return new ValidationResult("'Всего' должно быть больше или равно 'В наличии'");
            }
            return ValidationResult.Success;
        }
    }
}

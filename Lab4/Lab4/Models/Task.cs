using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models
{
    public class CustomDateValidation: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return false;
            }
            if (value is DateTime date)
            {
                return date.Date >= DateTime.Today;
            }
            return false;
        }
    }
    public class Task
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage = "Nu a fost introdus titlu")]
        [StringLength(100,MinimumLength =3,ErrorMessage = "Lungimea textului trebuie sa fie minim de 3 caractere")]
        public string title { get; set; }

        [StringLength(500,ErrorMessage ="Descrierea trebuie sa aiba maxim 500 caractere")]
        public string? description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        
        [Required(ErrorMessage ="Nu a fost introdusa termenul limita")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}")]
        [CustomDateValidation(ErrorMessage ="Termenul limita trebuie sa inceapa de azi")]
        public DateTime? due_date { get; set; }

        [ForeignKey("idCategory")]
        public virtual Category? category { get; set; }

        public virtual ICollection<Tag>? tags { get; set; }
    }
}

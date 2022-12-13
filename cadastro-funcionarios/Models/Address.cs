using System.ComponentModel.DataAnnotations;

namespace cadastro_funcionarios.Models
{
    public class Address
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Road { get; set; }

        [Required]
        public string Neighborhood { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int EmployeeForeignKey { get; set; }


        [Required]
        public Employee Employee { get; set; }

    }
}

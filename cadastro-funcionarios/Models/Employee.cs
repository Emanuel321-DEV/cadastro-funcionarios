using System.ComponentModel.DataAnnotations;

namespace cadastro_funcionarios.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Role { get; set; }


        [Required]
        public decimal Salary { get; set; }


        [Required]
        public Address Address { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace cadastro_funcionarios.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

    }
}

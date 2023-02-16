using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models
{
    public class Ator
    {
        [Key]
        [Required]
        public int Id { get; internal set; }

        [Required(ErrorMessage = "O nome do ator é obrigatório")]
        public string NameAtor { get; set; }
    }
}

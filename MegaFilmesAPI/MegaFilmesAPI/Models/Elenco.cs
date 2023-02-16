using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models
{
    public class Elenco
    {
        [Key]
        [Required]
        public int IdElenco { get; internal set; }
        
        [Required(ErrorMessage = "O papel do ator é obrigatório")]
        public string PapelAtor { get; set; }
    }
}

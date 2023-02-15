using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models
{
    public class Elenco
    {
        [Key]
        [Required]
        public int Id { get; internal set; }
        [Required (ErrorMessage ="O nome do ator é obrigatório")]
        public string NameAtor { get;  set; }
        [Required(ErrorMessage = "O papel do ator é obrigatório")]
        public string PapelAtor { get; set; }
    }
}

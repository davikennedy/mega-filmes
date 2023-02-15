using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos
{
    public class CreateElencoDto
    {
        [Required(ErrorMessage = "O nome do ator é obrigatório")]
        public string NameAtor { get; set; }
        [Required(ErrorMessage = "O papel do ator é obrigatório")]
        public string PapelAtor { get; set; }
    }
}

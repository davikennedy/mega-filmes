using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.AtorDtos
{
    public class ReadAtorDto
    {
        [Required(ErrorMessage = "O nome do ator é obrigatório")]
        public string NameAtor { get; set; }
    }
}

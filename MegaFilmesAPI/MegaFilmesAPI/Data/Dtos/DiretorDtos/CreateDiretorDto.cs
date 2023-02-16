using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.DiretorDtos
{
    public class CreateDiretorDto
    {
        [Required]
        public string Nome { get; set; }
    }
}

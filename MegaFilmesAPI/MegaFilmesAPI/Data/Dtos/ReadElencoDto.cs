using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos
{
    public class ReadElencoDto
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }
    }
}

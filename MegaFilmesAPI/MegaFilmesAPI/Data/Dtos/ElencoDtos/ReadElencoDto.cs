using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.ElencoDtos
{
    public class ReadElencoDto
    {
        [Required(ErrorMessage = "O papel do ator é obrigatório")]
        public string PapelAtor { get; set; }
    }
}

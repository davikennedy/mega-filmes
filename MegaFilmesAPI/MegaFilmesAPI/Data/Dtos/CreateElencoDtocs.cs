using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos
{
    public class CreateElencoDtocs
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }
    }
}

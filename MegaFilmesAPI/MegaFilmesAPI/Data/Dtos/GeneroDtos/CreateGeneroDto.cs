using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.GeneroDtos;

public class CreateGeneroDto
{
    [Required]
    public string GeneroFilme { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.AvaliacaoDtos
{
    public class ReadAvaliacaoDto
    {
        [Required(ErrorMessage = " O critério é obrigatorio")]
        [Range(1, 5, ErrorMessage = "O critério deverá conter valores entre 1 a 5")]
        public int Criterio { get; set; }
        [StringLength(200, ErrorMessage = "O comentário deve ter no máximo 200 caracteres")]
        public string? Comentario { get; set; }
    }
}

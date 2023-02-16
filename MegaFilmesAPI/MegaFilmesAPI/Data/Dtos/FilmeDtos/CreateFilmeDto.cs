using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Data.Dtos.FilmeDtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O nome do filme é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do filme é obrigatória")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O ano do filme é obrigatório")]
    public int Ano { get; set; }

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public int DiretorId { get; set; }
    //public string Diretor { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    public string Genero { get; set; }
}

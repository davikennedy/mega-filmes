using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models;

public class Filme 
{
    /*[Key]
    [Required]
    public int Id { get; internal set; }*/

    [Required(ErrorMessage = "O nome do filme é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do filme é obrigatória")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O ano do filme é obrigatório")]
    public int Ano { get; set; }

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public string Diretor { get; set; }

    [Required]
    public string Genero { get; set; }
}

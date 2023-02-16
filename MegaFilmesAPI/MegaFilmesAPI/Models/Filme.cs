using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models;

public class Filme 
{
    [Key]
    [Required]
    public int Id { get; internal set; }

    [Required(ErrorMessage = "O nome do filme é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição do filme é obrigatória")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O ano do filme é obrigatório")]
    public int Ano { get; set; }

    [Required]
    public int GeneroId { get; set; }

    [Required]
    public int DiretorId { get; set; }

    [Required(ErrorMessage = "O diretor do filme é obrigatório")]
    public virtual Diretor Diretor { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models;

public class Diretor
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; }
    public virtual ICollection<Filme> Filmes { get; set; }

    public Diretor ()
    {
        Nome = Nome.Trim();
    }
}

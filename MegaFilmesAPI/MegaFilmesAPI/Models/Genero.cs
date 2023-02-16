using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models;

public class Genero
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Nome { get; set; }
    public virtual ICollection<Filme> Filmes { get; set; }

    public Genero(string nome)
    {
        Nome = nome.Trim();
    }
}


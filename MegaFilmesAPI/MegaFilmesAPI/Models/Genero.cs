using System.ComponentModel.DataAnnotations;

namespace MegaFilmesAPI.Models;

public class Genero
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string GeneroFilme { get; set; }
    public virtual ICollection<Filme> Filmes { get; set; }

    public Genero()
    {
        GeneroFilme = GeneroFilme.Trim();
    }
}


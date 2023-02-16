using MegaFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmesAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Avaliacao> Avaliacoes { get; set; }
    public DbSet<Elenco> Elencos { get; set; }
    public DbSet<Diretor> Diretores { get; set; }
    public DbSet<Ator> Atores { get; set; }


}
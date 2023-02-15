using MegaFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmesAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
    }

    public DbSet<Filme> Filmes { get; set; }

    public DbSet<Avaliacao> Avaliacaos { get; set; }
}
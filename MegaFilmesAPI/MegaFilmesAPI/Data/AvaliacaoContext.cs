using MegaFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmesAPI.Data
{
    public class AvaliacaoContext : DbContext
    {
        public AvaliacaoContext(DbContextOptions<AvaliacaoContext> options) : base(options)
        {
        }

        public DbSet<Avaliacao> Avaliacaos { get; set; }
    }
}

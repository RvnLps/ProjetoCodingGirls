using Microsoft.EntityFrameworkCore;
using ProjetoCodingGirls.Models;

namespace ProjetoCodingGirls_Escola.Models
{
    public class TurmaContext : DbContext
    {
        public TurmaContext(DbContextOptions<TurmaContext> options)
            : base(options)
        {
        }

        public DbSet<Turma> Turma{ get; set; }
    }
}






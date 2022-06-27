using Microsoft.EntityFrameworkCore;

namespace ProjetoCodingGirls_Escola.Models
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
    }
}



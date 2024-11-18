using healthsync_back.Models;
using Microsoft.EntityFrameworkCore;

namespace healthsync_back.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Defina suas tabelas aqui
        //Exemplo de tabela abaixo:
        public DbSet<User> Users { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}

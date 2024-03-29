using backEndTest.Data.Map;
using backEndTest.Models;
using Microsoft.EntityFrameworkCore;

namespace backEndTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Credito> Creditos { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CreditoMap());
            modelBuilder.ApplyConfiguration(new ResultadoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace db_portafolio
{
    public class PortafolioContext : DbContext
    {
        public PortafolioContext(DbContextOptions<PortafolioContext> options)
            : base(options)
        {
            
        }

        public DbSet<PF_Link_Grp> PF_Link_Grp { get; set; }
        public DbSet<PF_Link> PF_Link { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PF_Link_Grp>().ToTable("pf_link_grp");
            modelBuilder.Entity<PF_Link>().ToTable("pf_link");
        }
    }
}
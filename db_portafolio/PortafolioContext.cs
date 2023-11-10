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
        public DbSet<PF_Project> PF_Project { get; set; }
        public DbSet<PF_Project_List> PF_Project_List { get; set; }
        public DbSet<PF_Pro_Prol> PF_Pro_Prol { get; set; }
        public DbSet<PF_Language> PF_Language { get; set; }
        public DbSet<PF_Pro_Lang> PF_Lang { get; set; }
        public DbSet<PF_Technology> PF_Technology { get; set; }
        public DbSet<PF_Pro_Tech> PF_Pro_Tech { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PF_Link_Grp>().ToTable("pf_link_grp");
            modelBuilder.Entity<PF_Link>().ToTable("pf_link");
            modelBuilder.Entity<PF_Project>().ToTable("pf_project");
            modelBuilder.Entity<PF_Project_List>().ToTable("pf_project_list");
            modelBuilder.Entity<PF_Pro_Prol>().ToTable("pf_pro_prol").HasKey(e => new { e.id_project, e.id_project_list});
            modelBuilder.Entity<PF_Language>().ToTable("pf_language");
            modelBuilder.Entity<PF_Pro_Lang>().ToTable("pf_pro_lang").HasKey(e => new { e.id_project, e.id_language });
            modelBuilder.Entity<PF_Technology>().ToTable("pf_technology");
            modelBuilder.Entity<PF_Pro_Tech>().ToTable("pf_pro_tech").HasKey(e => new { e.id_project, e.id_technology });
        }
    }
}
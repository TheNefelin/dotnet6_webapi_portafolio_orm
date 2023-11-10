using Microsoft.EntityFrameworkCore;

namespace db_portafolio
{
    public class PortafolioContext : DbContext
    {
        public PortafolioContext(DbContextOptions<PortafolioContext> options)
            : base(options)
        {
            
        }
    }
}
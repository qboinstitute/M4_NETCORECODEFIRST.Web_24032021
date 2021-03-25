using Microsoft.EntityFrameworkCore;

namespace M4_NETCORECODEFIRST.Web.Models
{
    public class EurocopaDBContext : DbContext
    {
        public EurocopaDBContext(DbContextOptions<EurocopaDBContext> options) : base(options)
        {

        }

        public DbSet<Player> Player { get; set; }

        public DbSet<SoccerPosition> SoccerPosition { get; set; }

        public DbSet<Team> Team { get; set; }

    }
}

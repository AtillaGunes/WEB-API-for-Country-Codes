using Microsoft.EntityFrameworkCore;

namespace CountryCodes.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context>options)
            :base(options)
        {

        }
        public DbSet<Country> Country { get; set; } = null!;
    }
}

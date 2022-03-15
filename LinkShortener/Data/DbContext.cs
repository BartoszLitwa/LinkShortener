using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LinkShortener.Data
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }


    }
}

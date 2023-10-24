using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WellSpring.Data
{
    public class WellSpringDbContext : IdentityDbContext
    {
        public WellSpringDbContext(DbContextOptions<WellSpringDbContext> options) : base(options)
        {
        }
    }
}

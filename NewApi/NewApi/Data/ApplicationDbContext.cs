using Microsoft.EntityFrameworkCore;
 
namespace NewApi.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }
    }
}

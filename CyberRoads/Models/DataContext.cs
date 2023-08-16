using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CyberRoads.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
        {

        }
        public DbSet<SignIn> SignIns { get; set; }
    }
}

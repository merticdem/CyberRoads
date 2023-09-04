using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace CyberRoads.Models
{
    public class DataContext:IdentityDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

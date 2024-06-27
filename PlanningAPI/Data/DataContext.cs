using Microsoft.EntityFrameworkCore;
using PlanningAPI.Models;

namespace PlanningAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ToDoTask> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=planningdb;Username=postgres;Password=");
        }
    }
}

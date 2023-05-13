using Microsoft.EntityFrameworkCore;

namespace BlazorTodo.Data
{
    public class BlazoTaskDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public BlazoTaskDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("BlazorTaskDB"));

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Task> Tasks { get; set; }
    }
}

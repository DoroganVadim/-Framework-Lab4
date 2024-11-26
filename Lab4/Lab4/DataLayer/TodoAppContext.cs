using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.DataLayer
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions<TodoAppContext> options) : base(options)
        {
            ;
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Lab3.Models.Task> tasks { get; set; }
        public DbSet<Tag> tags { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TodoDemo.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<Todo> Todos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", CategoryName = "Work" },
                new Category { CategoryId = "home", CategoryName = "Home" },
                new Category { CategoryId="ex", CategoryName="Exercise"},
                new Category { CategoryId="shop", CategoryName="Shopping"},
                new Category { CategoryId="call", CategoryName="Contact" });

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", StatusName="Open"},
                new Status { StatusId = "closed", StatusName = "Completed" }
                );
        }
    }
}

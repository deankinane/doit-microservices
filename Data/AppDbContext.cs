using doit.backend.Models;
using Microsoft.EntityFrameworkCore;

namespace doit.backend.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
       {
       } 

       public DbSet<TodoList> TodoLists {get; set;}
       public DbSet<TodoItem> TodoItems {get; set;}
       public DbSet<User> Users { get; set; }
    }
}

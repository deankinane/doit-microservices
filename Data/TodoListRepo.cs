using doit.backend.Models;

namespace doit.backend.Data
{
    public class TodoListRepo : GenericRepository<TodoList>
    {
        public TodoListRepo(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}

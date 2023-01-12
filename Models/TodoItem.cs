using System.ComponentModel.DataAnnotations;

namespace doit.backend.Models {
    public class TodoItem 
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; } 
    }
}

using System.ComponentModel.DataAnnotations;

namespace doit.backend.Models {
    public class TodoList : IEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

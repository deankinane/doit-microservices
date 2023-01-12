using System.ComponentModel.DataAnnotations;

namespace doit.backend.Models
{
   public class User
   {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
   } 
}

using System.ComponentModel.DataAnnotations;

namespace Bookshelf.Core
{
    public class User
    {
      [Key]
      public int Id { get; set; }
      public string Email { get; set; }
      public string PasswordHash { get; set; }
      public bool IsAdmin { get; set; }
    }
}
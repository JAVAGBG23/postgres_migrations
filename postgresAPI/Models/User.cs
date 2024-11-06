using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postgresAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // PostgreSQL auto-incremented ID

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Store roles as a JSONB column
        [Column(TypeName = "jsonb")]
        public List<string> Roles { get; set; } = new List<string>();
    }
}


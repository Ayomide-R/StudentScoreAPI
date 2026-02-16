using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentScoreAPI.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cpf")]
        public long Cpf { get; set; } // Changed to long for CPF

        [Required]
        [EmailAddress]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column("password")] // Assuming 'senha' maps to password
        public string Password { get; set; } = string.Empty;

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        // Constructor for EF Core
        public Student() { }

        public Student(long cpf, string email, string name, string password)
        {
            Cpf = cpf;
            Email = email;
            Name = name;
            Password = password;
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Data
{
    class PasswordData
    {
        [Required]
        [StringLength(10, ErrorMessage = "Password is too long.")]
        public string Password { get; set; }
    }
}
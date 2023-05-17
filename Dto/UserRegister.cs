using System.ComponentModel.DataAnnotations;

namespace UserAppAuth.System.Dto
{
    public class UserRegistraionRequestDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
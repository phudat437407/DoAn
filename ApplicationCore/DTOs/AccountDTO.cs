using System.ComponentModel.DataAnnotations;
namespace ApplicationCore.DTOs
{
    public class AccountDTO
    {
        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Username { get; set; }

        public bool Gender { get; set; }

        [StringLength(20, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        public STATUS Status { get; set; }

        [Required]
        public string PersonId { get; set; }
        public PersonDTO Person { get; set; }
    }
}
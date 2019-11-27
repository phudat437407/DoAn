using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;
using ApplicationCore.Entities;
using System;
namespace ApplicationCore.DTOs
{
    public class PersonDTO
    {
        [StringLength(5, MinimumLength = 5)]
        [Required]
        public string Id { get; set; }

        //Ten 
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Số điện thoại không đúng")]
        [Required]
        public string Phone { get; set; }

        public AddressDTO Address { get; set; }

        public AccountDTO Account { get; set; }

        public STATUS Status { get; set; }
    }

}
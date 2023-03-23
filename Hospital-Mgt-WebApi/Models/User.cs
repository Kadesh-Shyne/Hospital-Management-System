using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Range(100, 999, ErrorMessage = "Min Value is 100 and Max Value is 999.")]
        [Required(ErrorMessage = "User Type Code is a required field.")]
        public int UserTypeCode { get; set; }

        [Required(ErrorMessage = "FirstName is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum string length is 50.")]
        public string? User_FirstName { get; set; }

        [Required(ErrorMessage = "LastName is a required field.")]
        [StringLength(50, ErrorMessage = "Maximum string length is 50.")]
        public string? User_LastName { get; set; }

        [Required(ErrorMessage = "Phone Number is a required field.")]
        [StringLength(12, ErrorMessage = "Maximum string length is 12.")]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? User_Email { get; set; }

        [Required(ErrorMessage = "Address is a required field.")]
        [StringLength(500, ErrorMessage = "Maximum length is 500 character.")]
        public string? Address { get; set; }
    }
}

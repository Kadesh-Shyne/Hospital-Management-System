using HIMS_Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Domain.Entities
{
    public class Employee : AuditableBaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage = "JobTitle is a required field.")]
        public string? JobTitle { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Employee Specialization is a required field")]
        public string? EmployeeSpecialization { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="Employee Level is a required field.")]
        public string? Employee_Level { get; set; }

        [ForeignKey(nameof(Department))]
        public int Department_Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "FirstName is a required field.")]
        public string? FirstName { get; set; }

        [StringLength(30)]
        public string? MiddleName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "FamilyName is a required field.")]
        public string? FamilyName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "House_Address is a required field.")]
        public string? House_Address { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Area_Locality is a required field.")]
        public string? Area_Locality { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "City is a required field.")]
        public string? City { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "State is a required field.")]
        public string? State { get; set; }

        [StringLength(30)]
        public string? Country { get; set; }


        public DateTime DateOfBrith { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "Gender is a required field.")]
        public string? Gender { get; set; }


        [StringLength(30)]
        public string? Email { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "Phone Number is a required field.")]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateHired { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateLeft { get; set; }
    }
}

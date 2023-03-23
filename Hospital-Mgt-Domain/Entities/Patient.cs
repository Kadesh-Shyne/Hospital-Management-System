using HIMS_Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Domain.Entities
{
    public class Patient : AuditableBaseEntity
    {
        [Key]
        [Required(ErrorMessage = "PatientHealthCareNumber is a required field.")]
        public int PatientHealthCareNumber { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "PatientType is a required field.")]
        public string? PatientType { get; set; }

        [StringLength(10)]        
        public string? HMOPolicyNumber { get; set; }

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
        public string? Patient_Email { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "Phone Number is a required field.")]
        public string? Patient_PhoneNumber { get; set; }
    }
}

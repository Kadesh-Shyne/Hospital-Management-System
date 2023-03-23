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
    public class Department : AuditableBaseEntity
    {
        [StringLength(100)]
        [Required(ErrorMessage ="Department is a required field.")]
        public string? Department_Name { get; set; }

        [ForeignKey(nameof(Employee))]
        public int HeadOfDepartment { get; set; }

    }
}

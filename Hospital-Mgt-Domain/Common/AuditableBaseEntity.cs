using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIMS_Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="CreatedBy is a required field.")] 
        public string? CreatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        [StringLength(30)]
        public string? ModifiedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateModified { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}

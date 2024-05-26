
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class EmployeesChild
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeesChildId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [StringLength(20)]
        public required string FirstName { get; set; }

        [StringLength(20)]
        public required string LastName { get; set; }

        public int Age { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}

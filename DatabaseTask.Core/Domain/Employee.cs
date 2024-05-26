using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(20)]
        public required string FirstName { get; set; }
        [StringLength(20)]
        public required string LastName { get; set; }
        public int PersonalIdentificationNumber { get; set; }

        [StringLength(100)]
        public string? ContactAddress { get; set; }

        public int ContactPhoneNumber { get; set; }

        [StringLength(30)]
        public string? ContactEmail { get; set; }

        public DateTime AtWorkSince { get; set; }

        public DateTime? AtWorkUntil { get; set; }

        [ForeignKey("JobTitle")]
        public int JobTitleId { get; set; }
        public required JobTitle JobTitle { get; set; }

        [ForeignKey("AccessLevel")]
        public int AccessLevelId { get; set; }

        public decimal Salary { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }  

        public ICollection<WorkTime> WorkTimes { get; set; }           
    }

}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class JobTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobTitleId { get; set; }

        [StringLength(30)]
        public required string Title { get; set; }

        [StringLength(30)]
        public required string Description { get; set; }

        public decimal SalaryLevel { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}
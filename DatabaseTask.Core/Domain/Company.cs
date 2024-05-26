using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        public int RegistryNumber { get; set; }

        [StringLength(20)]
        public required string Name { get; set; }

        [StringLength(100)]
        public required string Address { get; set; }

        [StringLength(20)]
        public string? ContactPerson { get; set; }

        public int ContactPhoneNumber { get; set; }

        [StringLength(30)]
        public string? ContactEmail { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
        
        public ICollection<BranchOffice> BranchOffices { get; set; }

    }
}
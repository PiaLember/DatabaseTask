
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Hint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HintId { get; set; }

        [StringLength(25)]
        public required string Topic { get; set; }

        [StringLength(1000)]
        public required string Description { get; set; }

        public bool Anonymous { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}

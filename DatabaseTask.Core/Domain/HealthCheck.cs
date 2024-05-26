
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HealthCheckId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public required DateTime Date { get; set; }

        [StringLength(300)]
        public required string Result { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}

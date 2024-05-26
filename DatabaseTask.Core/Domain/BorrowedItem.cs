
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class BorrowedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BorrowedItemId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [StringLength(30)]
        public required string ItemName { get; set; }

        public required DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}

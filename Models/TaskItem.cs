using System;
using System.ComponentModel.DataAnnotations;

namespace OritsoTaskManagement.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public string? Status { get; set; }

        public string? Remarks { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? UpdatedOn { get; set; }

        public string? CreatedByName { get; set; }
        public int? CreatedById { get; set; }

        public string? UpdatedByName { get; set; }
        public int? UpdatedById { get; set; }
    }
}
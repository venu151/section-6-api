using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models
{
 
        [Table("Sch")]
        public class School
        {
            [Key]
            public int RollNo { get; set; }
            public int SchoolId { get; set; }
            public int marks { get; set; }
            public string Student { get; set; }
            public string Subject { get; set; }

        }
    }


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesStudent.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

         [StringLength(60, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }

        [Display(Name="Certified Date")]
        [DataType(DataType.Date)]
        public DateTime CertifiedDate { get; set; }
        
        public string Location { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName ="decimal(18, 2)")]
        public decimal TandF { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Program { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{
    public class StudentModel
    {
        [Key]
        [Display(Name ="Enter your id")]
        [Required]
        public int studentId { get; set; }

        [Required]
        [Display(Name = "Enter your name")]
        public string stdName { get; set; }

        [Display(Name = "Enter your fees")]
        public double stdFees { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$",ErrorMessage ="Please enter valid Email Id")]
        [Display(Name = "Enter your email")]
        public string stdMail { get; set; }

        [Required]
        [StringLength(20,MinimumLength =6)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Compare("password",ErrorMessage ="password and confirm password does not match")]
        [Display(Name = "Enter password again")]
        [DataType(DataType.Password)]
        public string confPass { get; set; }

        [Range(5,20)]
        public int age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestPract1.Models
{
    public class SemClassViewModels
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string courseName { get; set; }

        [Required]
        [Display(Name = "Course Number")]
        public int courseNumber { get; set; }

        [Required]
        [Display(Name = "Semester")]
        public string semester { get; set; }
    }
}

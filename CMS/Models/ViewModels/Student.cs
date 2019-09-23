using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Student
    {
        [Key]
        [Display(Name = "Student Admin")]
        public string studentAdmin { get; set; }
       [Required]
        [Display(Name = "Student Name")]
        public string studentName { get; set; }
        [Required]
        [Display(Name = "Project Id")]
        public int projectId { get; set; }
        [Required]
        [Display(Name = "student's Age")]
        public int studentYear { get; set; }
        [Required]
        [Display(Name = "Created Date")]
        public DateTime dateCreated { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class ShortCourses
    {
        [Key]
        public int courseId { get; set; }
        [Display(Name = "Course Name")]
        [Required]
        public string courseName { get; set; }
        [Display(Name = "Course Subject")]
        [Required]
        public string courseSubject { get; set; }
        [Display(Name = "Course Instructor")]
        [Required]
        public string courseInstructor { get; set; }
        [Display(Name = "Course Venue")]
        [Required]
        public string courseVenue { get; set; }
        [Display(Name = "Create date")]
        public DateTime dateCreated { get; set; }

    }
}

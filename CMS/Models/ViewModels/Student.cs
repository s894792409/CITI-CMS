
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Student
    {
        [Key]
        [Required]
        [Display(Name = "Student Admin")]
        public string studentAdmin { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string studentName { get; set; }
        
        [Display(Name = "Project")]
        public int projectId { get; set; }
        [Required]
        [Display(Name = "student's Age")]
        public int studentYear { get; set; }

        [Display(Name = "Create date")]
        public DateTime dateCreated { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoType { get; set; }

    }
}

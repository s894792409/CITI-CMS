
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
        [Display(Name = "Admin")]
        public string studentAdmin { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string studentName { get; set; }
        
        [Display(Name = "NYP Project")]
        public int projectId { get; set; }
        [Required]
        [Display(Name = "Birthday")]
        public DateTime studentBirthday { get; set; }

        [Display(Name = "Create date")]
        public DateTime dateCreated { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoType { get; set; }
        [Display(Name = "Portfolio")]
        public string studentPortfolio { get; set; }
    }
}

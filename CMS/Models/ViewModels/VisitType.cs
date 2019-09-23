using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class VisitType
    {
        [Key]
        public int visitTypeId { get; set; }
        [Display(Name = "Visit Type")]
        [Required]
        public string visitType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Visits
    {
        [Key]
        [Required]
        public int VisitId { get; set; }
        public int? No { get; set; }
        [Required]
        [Display(Name = "Start DateTime")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End DateTime")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "CompanyName")]
        public string Name { get; set; }
        [Required]
        public int Pax { get; set; }
        [Required]
        public string SIC { get; set; }
        [Required]
        public string Host { get; set; }
        [Required]
        [Display(Name = "Foreign Visit")]
        public bool ForeignVisit { get; set; }
        [Display(Name = "Create date")]
        public DateTime dateCreated { get; set; }
    }
}

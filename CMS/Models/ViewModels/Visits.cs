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
        public int visitId { get; set; }
        [Display(Name ="Company Name")]
        [Required]
        public String companyName { get; set; }
        [Display(Name = "Company Type")]
        [Required]
        public int companyTypeId { get; set; }
        [Display(Name = "Number of Visitor")]
        [Required]
        public int noOfPax { get; set; }
        [Display(Name = "Visit Date")]
        [Required]
        public DateTime visitDate { get; set; }
        [Display(Name = "Visit Type")]
        [Required]
        public int visitTypeId { get; set; }
        [Display(Name = "Created Date ")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime dateCreated { get; set; }

    }
}

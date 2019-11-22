using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Awards
    {
        [Key]
        public int awardId { get; set; }
        [Display(Name = "Award Name")]
        [Required]
        public string awardName { get; set; }
        [Display(Name = "Achievement")]
        [Required]
        public string awardLevel { get; set; }
        [Display(Name = "Number of Recipients")]
        [Required]
        public int noOfRecipients { get; set; }
        [Display(Name = "Award Type")]
        [Required]
        public string awardType { get; set; }
        [Display(Name ="Create date")]
        public DateTime dateCreated { get; set; }
    }
}

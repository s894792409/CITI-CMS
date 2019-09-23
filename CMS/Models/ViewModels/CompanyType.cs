using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class CompanyType
    {
        [Key]
        [Required]
        public int companyTypeId { get; set; }
        [Display(Name ="Company Type")]
        [Required]
        public string companyType { get; set; }
    }
}

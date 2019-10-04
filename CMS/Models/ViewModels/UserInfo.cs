using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class UserInfo
    {
        
        [Required]
        public string UserName { get; set; }
        [Key]
        public string Id { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string NormalizedEmail { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public bool Admin { get; set; }
    }
}

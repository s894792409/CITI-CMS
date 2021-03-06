﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class UserInfo
    {
        
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Key]
        public string Id { get; set; }

        [Required]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public string UserKey { get; set; }
        [Required]
        [Display(Name ="Role")]
        public bool Admin { get; set; }
    }
}

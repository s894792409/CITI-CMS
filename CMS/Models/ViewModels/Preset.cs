﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Preset
    {
        [Key]
        public int presetId { get; set;}
        
        [Display(Name ="Created Date")]
        public DateTime dateCreated { get; set; }
        [Required]
        [Display(Name = "Theme Id")]
        public int themeId { get; set; }
        [Required]
        [Display(Name = "Visit Company")]
        public int visitId { get; set; }
    }
}

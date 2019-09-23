using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Preset
    {
        [Key]
        public int presetId { get; set;}
        [Required]
        [Display(Name ="Created Date")]
        public DateTime dateCreated { get; set; }
        [Required]
        [Display(Name = "Theme ID")]
        public int themeId { get; set; }
        [Required]
        [Display(Name = "Visit Id")]
        public int visitId { get; set; }
    }
}

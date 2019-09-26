using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Theme
    {
        [Key]
        public int themeId { get; set;}
        [Display(Name ="Created Date")]
        public DateTime dateCreated { get; set; }
        [Required]
        [Display(Name ="Background Color")]
        public string backgroundColor { get; set; }
        [Required]
        [Display(Name ="Font Style")]
        public string fontStyle { get; set; }
        [Required]
        [Display(Name = "Theme Name")]
        public string themeName { get; set; }
    }
}

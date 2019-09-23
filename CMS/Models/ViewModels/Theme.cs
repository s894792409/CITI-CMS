using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Theme
    {
        [Key]
        public int themeId { get; set;}
        [Required]
        public DateTime dateCreated { get; set; }
        [Required]
        public string backgroundColor { get; set; }
        [Required]
        public string fontStyle { get; set; }
    }
}

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
        public DateTime dateCreated { get; set; }
        [Required]
        public int themeId { get; set; }
        [Required]
        public int visitId { get; set; }
    }
}

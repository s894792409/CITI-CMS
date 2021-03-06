﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.ViewModels
{
    public class Projects
    {
        [Key]
        public int projectId { get; set; }
       [Required]
       [Display(Name = "Project Name")]
        public string projectName { get; set; }
        [Required]
        [Display(Name = "Project State")]
        public string projectState { get; set; }
        [Required]
        [Display(Name = "Number Of Students")]
        public int noOfStudents { get; set; }
        [Display(Name = "Create date")]
        public DateTime dateCreated { get; set; }

    }
}

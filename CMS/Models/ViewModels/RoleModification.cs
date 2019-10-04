﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models.ViewModels
{
    public class RoleModification
    {
        [Required]
        public string Name { get; set; }
        [Key]
        public string Id { get; set; }
    }
}

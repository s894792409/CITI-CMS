using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public partial class User
    {
        [Key]
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Role { get; set; }
        public string NormalizedEmail { get;  set; }
    }
}

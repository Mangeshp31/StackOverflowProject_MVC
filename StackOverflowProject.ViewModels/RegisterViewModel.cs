using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflowProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [RegularExpression(@"^[a - zA - Z0 - 9 + _.-] +@[a-zA-Z0-9.-]+$")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]  
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9_]{7,29}$")]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }
    }
}

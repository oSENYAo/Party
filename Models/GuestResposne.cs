using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Party.Models
{
    public class GuestResposne
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please enter a valid email adress")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Please enter youre number phone")]
        public string Phone{ get; set; }
        [Required(ErrorMessage = "Please select what you attend")]
        public bool? WillAttend { get; set; }
    } 
}

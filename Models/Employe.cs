using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Full Name"), Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Phone#")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Please Enter 10 Digit Number")]
        public string Phone {  get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invaild Email Id")]
        public string Email { get; set; }
    }
}
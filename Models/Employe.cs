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

        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Phone#")]
        public string Phone {  get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invaild Email Id")]
        public string Email { get; set; }
    }
}
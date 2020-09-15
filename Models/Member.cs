using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Models
{
    public class Member
    {
        public int MemberId {get; set;} // Primary Key
        
        [Display(Name = "Name")]
        [StringLength(40)]
        [Required]
        public string Name {get; set;}

        [Display(Name = "Classification")]
        [StringLength(40)]
        [Required]
        public string year {get; set;}

        [Display(Name = "Email Address")]
        [StringLength(40)]
        [Required]
        public string email {get; set;}

        public Team Team {get; set;}
        public int TeamId {get; set;}
    }
}
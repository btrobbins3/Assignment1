using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Models
{
    public class Team
    {
        public int TeamId {get; set;} // Primary Key
        
        [Display(Name = "Team Name")]
        [StringLength(40)]
        [Required]
        public string teamName {get; set;}

        public List<Member> Members {get; set;}

        public List<Project> Projects {get; set;}
    }
}
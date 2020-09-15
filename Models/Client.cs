using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Models
{
    public class Client
    {
        public int ClientId {get; set;} // Primary Key
        
        [Display(Name = "Name")]
        [StringLength(40)]
        [Required]
        public string Name {get; set;}

        public List<Project> Projects {get; set;}
    }
}
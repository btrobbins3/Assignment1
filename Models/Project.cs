using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Models
{
    public class Project
    {
        public int ProjectId {get; set;} // Primary Key

        [Display(Name = "Project Name")]
        [StringLength(40)]
        [Required]
        public string Name {get; set;}

        public Team Team {get; set;}
        public int TeamId {get; set;}

        public Client Client {get; set;}
        public int ClientId {get; set;}
    }
}
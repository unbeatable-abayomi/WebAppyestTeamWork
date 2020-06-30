using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppyest.ViewModel
{
    public class ActivitiesViewModel
    {
        [Required(ErrorMessage = "Please enter an activity number")]
        [Display(Name = "Activity Number")]
        public long ActivityNumber { get; set; }

        [Required(ErrorMessage = "Please enter an activty title")]
        [Display(Name = "Activity Title")]
        public string ActivityTitle { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Minimum of 10 character")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select team")]
        public string SelectTeam { get; set; }

        [Display(Name = "Activity Image")]
        public IFormFile ActImage { get; set; }

        [Display(Name = "Activity Manager Image")]
        public IFormFile ActManagerImage { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}

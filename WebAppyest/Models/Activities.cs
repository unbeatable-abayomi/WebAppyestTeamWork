using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppyest.Models
{
    public class Activities
    {
        [Key]
        public long ActivitiesId { get; set; }
        [Required(ErrorMessage = "Please enter an activity number")]
        [Display(Name = "Activity Number")]
        public long ActivityNumber { get; set; }

        [Required(ErrorMessage = "Please enter an activty title")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minimum of 5 character")]
        [Display(Name = "Activity Title")]
        public string ActivityTitle { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Minimum of 10 character")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select team")]
        public string SelectTeam { get; set; }

        [Display(Name = "Activity Image")]
        public string ActivityImage { get; set; }

        [Display(Name = "Activity Manager Image")]
        public string ActivityManagerImage { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}

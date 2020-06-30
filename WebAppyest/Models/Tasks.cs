using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppyest.Models
{
    public class Tasks
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Number")]
        public string TaskNumber { get; set; }

        [Required]
        public string DescriptionTitle { get; set; }

        [Required]
        public string Description { get; set; }

        //[NotMapped]
        [Required]
        public string Team { get; set; }
        //public List<string> Team { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public double Duration { get; set; }

    }
}

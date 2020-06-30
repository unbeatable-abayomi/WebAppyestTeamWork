using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppyest.Models
{
    public class ActivityTitle
    {
        [Key]
        public long ActivityId { get; set; }

        //[Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
    }
}

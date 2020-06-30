using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.ActivitiesViewModels
{
    public class MultipleActivityModel
    {
        public ActivitiesViewModel ActViewModel { get; set; }
        public List<Activities> Act { get;set; }
        public List<ActivityTitle> ActT { get; set; }
        public ActivityTitle Acts { get; set; }
    }
}

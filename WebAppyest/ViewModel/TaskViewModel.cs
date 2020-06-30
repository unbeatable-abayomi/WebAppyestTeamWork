using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.ViewModel
{
    public class TaskViewModel
    {
        public Tasks TaskBoard { get; set; }
        public List<Tasks> TaskBoards { get; set; }
    }
}

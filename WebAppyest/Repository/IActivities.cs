using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.Repository
{
    public interface IActivities
    {
        IEnumerable<Activities> Activity { get; }
        public void AddActivities(Activities activity);
        IQueryable<Activities> Search(string act, long actnum);
    }
}

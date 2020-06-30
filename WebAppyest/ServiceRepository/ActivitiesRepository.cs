using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.ServiceRepository
{
    public class ActivitiesRepository : IActivities
    {
        private readonly DataContext context;
        public ActivitiesRepository(DataContext ctx) => context =ctx;

        public IEnumerable<Activities> Activity 
        {
            get
            {
                return context.ActivitiesTable;
            }
        }
        public void AddActivities(Activities activity)
        {
            context.ActivitiesTable.Add(activity);
            context.SaveChanges();
        }
        public IQueryable<Activities> Search(string act, long actnum)
        {
            var acts = context.ActivitiesTable.Where(s => s.ActivityTitle.Contains(act) || s.ActivityNumber.Equals(actnum) || s.Description.Contains(act));
            return acts;
        }
    }
}

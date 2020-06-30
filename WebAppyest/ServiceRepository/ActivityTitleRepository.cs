using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.ServiceRepository
{
    public class ActivityTitleRepository : IActivityTitle
    {
        private readonly DataContext context;
        public ActivityTitleRepository(DataContext ctx) => context =ctx;


        public IEnumerable<ActivityTitle> ActTitle 
        {
            get
            {
                return context.ActivityTitleTable;
            }
        }
        public void AddTitle(ActivityTitle title)
        {
            context.ActivityTitleTable.Add(title);
            context.SaveChanges();
        }

        public ActivityTitle Delete(long Id)
        {
            ActivityTitle act = context.ActivityTitleTable.Find(Id);
            if(act != null)
            {
                context.ActivityTitleTable.Remove(act);
                context.SaveChanges();
            }
            return act;

        }
        public ActivityTitle GetTitle(long Id)
        {
            return context.ActivityTitleTable.Find(Id);
        }
        public void EditTitle(ActivityTitle tit)
        {
            context.Entry(tit).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

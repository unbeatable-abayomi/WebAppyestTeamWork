using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.ServiceRepository
{
    public interface IActivityTitle
    {
        IEnumerable<ActivityTitle> ActTitle { get; }
        public void AddTitle(ActivityTitle title);

        ActivityTitle Delete(long Id);
        ActivityTitle GetTitle(long Id);
        void EditTitle(ActivityTitle tit);
    }
}

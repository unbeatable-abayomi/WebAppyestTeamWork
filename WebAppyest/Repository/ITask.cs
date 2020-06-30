using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.Repository
{
    public interface ITask
    {
        IEnumerable<Tasks> Tasks { get; }

        public Tasks AddTask(Tasks tasks);

        public Task<Tasks> Delete(int ID);

        public Task<Tasks> GetTask(int ID);

        public Task<Tasks> SaveTask(Tasks tasks);

        IQueryable<Tasks> Search(string input);
    }
}

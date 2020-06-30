using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Data;
using WebAppyest.Models;

namespace WebAppyest.Repository
{
    public class TaskRepo : ITask
    {
        private readonly DataContext context;

        public TaskRepo(DataContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Tasks> Tasks => context.Tasks;

        public Tasks AddTask(Tasks tasks)
        {
            context.Tasks.Add(tasks);
            context.SaveChanges();
            return tasks;
        }

        public async Task<Tasks> Delete(int ID)
        {
            Tasks task = context.Tasks.Find(ID);
            if (task != null)
            {
                context.Tasks.Remove(task);
                //After remove the employee then save changes to database
                await context.SaveChangesAsync();
            }
            return task;
        }

        public async Task<Tasks> GetTask(int ID)
        {
            return await context.Tasks.FindAsync(ID);
        }

        public async Task<Tasks> SaveTask(Tasks tasks)
        {
            context.Entry(tasks).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return tasks;
        }

        public IQueryable<Tasks> Search(string input)
        {
            var task = context.Tasks.Where(C => C.TaskNumber.Contains(input) || C.Description.Contains(input));

            return task;
        }
    }
}

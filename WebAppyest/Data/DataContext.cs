using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppyest.Models;

namespace WebAppyest.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> Opts) : base(Opts) { }

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Activities> ActivitiesTable { get; set; }
        public DbSet<ActivityTitle> ActivityTitleTable { get; set; }
    }
}

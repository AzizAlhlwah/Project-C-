using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectForTryIdeas.Models;

namespace ProjectForTryIdeas.Data
{
    public class ProjectForTryIdeasContext : DbContext
    {
        public ProjectForTryIdeasContext (DbContextOptions<ProjectForTryIdeasContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectForTryIdeas.Models.Car> Car { get; set; }

        public DbSet<ProjectForTryIdeas.Models.Person> Person { get; set; }
    }
}

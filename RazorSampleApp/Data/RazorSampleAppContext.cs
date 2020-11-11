using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorSampleApp.Models;

namespace RazorSampleApp.Data
{
    public class RazorSampleAppContext : DbContext
    {
        public RazorSampleAppContext (DbContextOptions<RazorSampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorSampleApp.Models.Movie> Movie { get; set; }
    }
}

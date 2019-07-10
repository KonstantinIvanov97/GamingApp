using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GamingApp.Data
{
    public class GamingAppDbContextFactory : IDesignTimeDbContextFactory<GamingAppDbContext>
    {
        public GamingAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GamingAppDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=GamingApp;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new GamingAppDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abp.Template.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class TemplateMigrationsDbContextFactory : IDesignTimeDbContextFactory<TemplateMigrationsDbContext>
    {
        public TemplateMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();
            var builder = new DbContextOptionsBuilder<TemplateMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new TemplateMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

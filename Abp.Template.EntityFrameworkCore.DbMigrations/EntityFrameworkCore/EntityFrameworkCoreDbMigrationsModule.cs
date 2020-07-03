using Abp.Template.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Abp.Template.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    [DependsOn(
        typeof(EntityFrameworkCoreModule)
        )]
    public class EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TemplateMigrationsDbContext>();
        }
    }
}

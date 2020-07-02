using Abp.Template.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Template.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class TemplateMigrationsDbContext : AbpDbContext<TemplateMigrationsDbContext>
    {
        public TemplateMigrationsDbContext(DbContextOptions<TemplateMigrationsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /* 在迁移数据库上下文中包含模块 */

            //modelBuilder.ConfigureTenantManagement();
            //modelBuilder.ConfigureIdentity();

            /* 在 Configure_Template 方法中配置您自己的表或者实体 */
            modelBuilder.Configure_Template();
        }
    }
}

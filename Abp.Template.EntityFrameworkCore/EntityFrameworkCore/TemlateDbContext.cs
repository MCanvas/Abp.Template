using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Template.EntityFrameworkCore.EntityFrameworkCore
{
    public class TemlateDbContext : AbpDbContext<TemlateDbContext>
    {
        public TemlateDbContext(DbContextOptions<TemlateDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //在 Configure_Template 方法中配置您自己的表或者实体
            modelBuilder.Configure_Template();
        }
    }
}

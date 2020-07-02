using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Abp.Template.EntityFrameworkCore.EntityFrameworkCore
{
    public static class TemplateDbContextModelCreatingExtensions
    {
        public static void Configure_Template (this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* 在这里配置您自己的表或者实体 */
        }
    }
}

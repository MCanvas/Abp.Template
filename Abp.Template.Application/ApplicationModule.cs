using Abp.Template.Domain;
using System;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Abp.Template.Application
{
    [DependsOn(
        typeof(DomainModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ApplicationModule>();
            });
        }
    }
}
 
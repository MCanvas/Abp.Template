using Abp.Template.Application.Contracts;
using System;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Abp.Template.HttpApi
{
    /// <summary>
    /// 
    /// </summary>
    [DependsOn(
        typeof(AbpAspNetCoreMvcModule),
        typeof(ApplicationContactsModule)
        )]
    public class HttpApiModule : AbpModule
    {
         
    }
}

using Abp.Template.Application;
using Abp.Template.HttpApi;
using Abp.Template.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Autofac;
using Volo.Abp.ExceptionHandling;
using Volo.Abp.Modularity;

namespace Abp.Template.WebApi
{
    [DependsOn(
        typeof(HttpApiModule),
        typeof(ApplicationModule),
        typeof(AbpAutofacModule)
        )]
    public class WebApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //移除框架自带的异常中间件
            Configure<MvcOptions>(options =>
            {
                var filterMetadata = options.Filters.FirstOrDefault(x => x is ServiceFilterAttribute attribute && attribute.ServiceType.Equals(typeof(AbpExceptionFilter)));
                options.Filters.Remove(filterMetadata);
            });

            context.Services.AddSwagger();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

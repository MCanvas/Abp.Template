using Abp.Template.Application.Contracts.Test.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Template.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HellowWorldController : AbpController
    {
        private readonly IHelloWorldService _helloWorldService;
        public HellowWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        /// <summary>
        /// 测试输出
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string HellowWorld()
        {
            return _helloWorldService.HelloWorld();
        }
    }
}

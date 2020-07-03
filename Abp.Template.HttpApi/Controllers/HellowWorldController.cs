using Abp.Template.Application.Contracts.Test.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Template.HttpApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HellowWorldController : AbpController
    {
        private readonly IHelloWorldService _helloWorldService;
        /// <summary>
        /// 
        /// </summary>
        public IHelloWorldService _1helloWorldService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="helloWorldService"></param>
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
            return "我是构造函数注入 : " + _helloWorldService.HelloWorld() + " $$  我是属性注入 : " + _1helloWorldService.HelloWorld();
        }
    }
}

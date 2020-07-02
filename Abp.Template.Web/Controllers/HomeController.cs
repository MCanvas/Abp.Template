using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Abp.Template.Web.Models;
using Abp.Template.Application.Contracts.Test.HelloWorld;
using Volo.Abp.AspNetCore.VirtualFileSystem;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Template.Web.Controllers
{
    public class HomeController : AbpController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHelloWorldService _helloWorldService;
        public IHelloWorldService _1helloWorldService { get; set; }

        public HomeController(ILogger<HomeController> logger, IHelloWorldService helloWorldService)
        {
            _logger = logger;
            _helloWorldService = helloWorldService;
        }

        public IActionResult Index()
        {
            ViewBag.output = "我是属性注入：" + _1helloWorldService.HelloWorld();
            ViewBag.output1 = "我是构造函数注入: " + _helloWorldService.HelloWorld();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

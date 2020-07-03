using Abp.Template.Application.Contracts.Test.HelloWorld;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Abp.Template.Application.Test.HelloWorld
{
    public class HelloWorldService : ApplicationServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}

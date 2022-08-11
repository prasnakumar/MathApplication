using Microsoft.AspNetCore.Mvc;
using Services.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathApplication.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DependenceInjectionController : Controller
    {
        private IServiceProvider _serviceProvider1;
        private readonly IMathScoped _mathScoped;
        private readonly IMathSingleton _mathSingleton;
        private readonly IMathTransient _mathTransient;
      public DependenceInjectionController(IServiceProvider serviceProvider, IMathScoped mathScoped, IMathSingleton mathSingleton,IMathTransient mathTransient)
        {
            _serviceProvider1 = serviceProvider;
            _mathScoped = mathScoped;
            _mathSingleton = mathSingleton;
            _mathTransient = mathTransient;
        }

        [HttpGet]
        [Route("DependencyInjection")]
        public string  DependencyInjection()
        {
           



            var cs = _serviceProvider1.GetService(typeof(IMathScoped));//scopped will excute only once 
            var cs1 = _serviceProvider1.GetService(typeof(IMathScoped));
         
            var ss = _serviceProvider1.GetService(typeof(IMathSingleton));//Singleton  will create only one instance 
            var ss1 = _serviceProvider1.GetService(typeof(IMathSingleton));
         
            var ts = _serviceProvider1.GetService(typeof(IMathTransient));//Singleton  will create only one instance  everytime it is being called 
            var ts1 = _serviceProvider1.GetService(typeof(IMathTransient));
            var ts2 = _serviceProvider1.GetService(typeof(IMathTransient));
            Console.WriteLine("----------------------------------------------------------------------\n");




            return null;
        }
    }
}

using MathApplication.Controllers.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathApplication.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MathLogicController : ControllerBase
    {
       
        public  readonly IMathServices _math;
        

        //
        public MathLogicController(IMathServices mathRepo, IServiceProvider serviceProvider)
        {
            _math = mathRepo;
          


        }
        
        [HttpGet]
        [Route("hello")]
        [CustomActionFIlterAttributes("check_hello_World")]
        public string check()
        {
            //var s = HttpContext.Items["entity"] as string;
            return "hello world ";
        }
        [HttpGet]
        [Route("Add")]
        [CustomActionFIlterAttributes("AddController")]
        public async Task<IActionResult> Add( double value1,double value2)
        {
            
            try
            {
                MathValue value = new MathValue() { value1 = value1, value2 = value2 };
                double result =  _math.Add(value);
                string s = $"{value1} + { value2} = {result}";
                return Ok(s);
            }
            catch(Exception e)
            {
                return BadRequest("Wrong Input");
            }
        }
        [HttpGet]
        [Route("Sub")]
        public async Task<IActionResult> Sub(double value1, double value2)
        {
            try
            {
                MathValue value = new MathValue() { value1 = value1, value2 = value2 };
                double result = _math.Sub(value);
                string s = $"{value1} - { value2} = {result}";
                return Ok(s);
            }
            catch (Exception e)
            {
                return BadRequest("Wrong Input");
            }
        }
        [HttpGet]
        [Route("Multiple")]
        public async Task<IActionResult> Multiple(double value1, double value2)
        {
            try
            {
                MathValue value = new MathValue() { value1 = value1, value2 = value2 };
                double result = _math.Multiple(value);
                string s = $"{value1} * { value2} = {result}";
                return Ok(s);
            }
            catch (Exception e)
            {
                return BadRequest("Wrong Input");
            }
        }
        [HttpGet]
        [Route("Div")]
        public async Task<IActionResult> div(double value1, double value2)
        {
            try
            {
                MathValue value = new MathValue() { value1 = value1, value2 = value2 };
                double result = _math.div(value);
                string s = $"{value1} / { value2} = {result}";
                return Ok(s);
            }
            catch (Exception e)
            {
                return BadRequest("Wrong Input");
            }
        }
    }
}

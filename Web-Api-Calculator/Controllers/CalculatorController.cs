using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api_Calculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public double Addition(int lValue, int rValue)
        {
            return lValue + rValue;
        }


        [HttpGet]
        public double Subtraction(int lValue, int rValue)
        {
            return lValue - rValue;
        }


        [HttpGet]
        public double Multiplication(int lValue, int rValue)
        {
            return lValue * rValue;
        }


        [HttpGet]
        public double Division(int lValue, int rValue)
        {


            if (lValue != 0 || rValue != 0)
            {
                return lValue / rValue;

            }
            else
            {
                throw new ArgumentException();
                

            }
        


        }
        [HttpGet]

        public double Percentage(int lValue, int rValue)
        {
             return lValue % rValue;
           // return (number1 * number2) / 100;
        }
    }
}

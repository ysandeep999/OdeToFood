using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetGreeting();
    }
    public class Greeter : IGreeter
    {
        private string _greeting;
        private string str = " hhhhhhhh";

        public Greeter(IConfiguration configuration)
        {
            //Console.Write("testinggg");
            _greeting = configuration["Greetings"];
        }
        public string GetGreeting()
        {
            //Console.Write(" test _greeting varible: " + _greeting + " str is : " + str);
            return _greeting;
        }
    }
}

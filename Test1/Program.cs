using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            PrintCharacterXTimes("salad", 3);
        }

        static string PrintCharacterXTimes(string character, int times)
        {
            string characters = character;
        	for (int i = 0; i < times; i++)
        	{
        		characters += character;
        	}
            return characters;
        }
    }
}

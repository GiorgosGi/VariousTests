using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2testarisma
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(ReturnCharacterXTimes("papates", 5));
        }

		static string ReturnCharacterXTimes(string character, int times)
		{

			string characters = character + "\n";

			for (int i = 1; i < times; i++)
			{
				characters += character;
				
			}
			return characters;
		}
	}
}

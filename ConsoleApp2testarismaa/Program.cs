using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2testarismaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FillArrayWithNullValues(5));
        }

        static string[] FillArrayWithNullValues(int sizeOfArray)
        {

            string[] A = new string[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                A[i] = "0";
            }
            return A;
        }
    }
}

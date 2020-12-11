using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2test
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(fillArrayWithNullValues(5));
        }

        static string[] fillArrayWithNullValues(int sizeOfArray)
        {
            string[] A;
            for (int i = 0; i < sizeOfArray; i++)
            {
                A[i] = 0;
            }
            return A;
        }
    }
}

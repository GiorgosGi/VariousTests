using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(DivideTwoNumbers(8, 4));
        }

		static int DivideTwoNumbers(int x, int y)
		{

			return x / y;
		}

		//// static void MergeTwoStringsAndPrint(string s1, string s2)

		//static void MergeTwoStringsAndPrint(string s1, string s2)
		//{

		//	Console.WriteLine(s1 + s2);
		//}
		//// static string MergeTwoStrings(string s1, string s2)

		//static string MergeTwoStrings(string s1, string s2)
		//{

		//	return s1 + s2;
		//}

		//// static void PrintSumOfIntegers(int[] array)

		//static void PrintSumOfIntegers(int[] array)
		//{

		//	Console.WriteLine(array.Sum());
		//}

		//// static void PrintCharacterXTimes(string character, int times)

		//static void PrintCharacterXTimes(string character, int times)
		//{

		//	for (int i = 0; i < times; i++)
		//	{
		//		Console.WriteLine(character);
		//	}
		//}

		//// static string ReturnCharacterXTimes(string character, int times)

		//static string ReturnCharacterXTimes(string character, int times)
		//{

		//	string characters = character;

		//	for (int i = 1; i < times; i++)
		//	{
		//		characters = characters + character;
		//	}
		//	return characters;
		//}
		//// static string[] fillArrayWithNullValues(int sizeOfArray)

		//static string[] fillArrayWithNullValues(int sizeOfArray)
		//{

		//	string[] A;
		//	for (int i = 0; i < sizeOfArray; i++)
		//	{
		//		A[i] = 0;
		//	}
		//	return A;
		//}
	}
}

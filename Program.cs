using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = fnc1();
			int[] arr2 = fnc1();
			NewMethod(arr);

		}

		private static void NewMethod(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

		private static int[] fnc1()
		{
			Random rdd = new Random();

			int[] mar = new int[10];
			for (int i = 0; i < mar.Length; i++)
			{
				mar[i] = rdd.Next(1, 1000);
		
			}
			return (mar);
			

		}
		
		
	}
}

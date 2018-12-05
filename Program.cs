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
			int[] a = { 2, 3, 5 };

			NewMethod(a);
		}

		private static double[] NewMethod(int[] array)
		{
			double[] myArray = new double[array.Length];

			for(int i = 0; i < array.Length; i++)
			{
				myArray[i] = array[i];
			}
			return myArray;



			

		}
	}
}

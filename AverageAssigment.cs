using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
			double sum = 0;
			int i = 0;
			Console.WriteLine("Enter numbers to calculate Average (negative numbers will terminate the process):");

			int x = Convert.ToInt32(Console.ReadLine());

			while (x>=0)
			{
				sum = sum + x;
				i++;
				x = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("The Average is:");
			Console.WriteLine(sum/i);
		}
	}
}

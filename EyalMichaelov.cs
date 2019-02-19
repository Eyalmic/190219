using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Please enter a number:");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter an additional number to print greater:");
			int b = Convert.ToInt32(Console.ReadLine());

			if (a>b)
				{
				Console.WriteLine(a);
				}
			else
				{
				if (a == b)
					{
					Console.WriteLine("The numbers are even");
					}
				else
					{
					Console.WriteLine(b);
					}
				}

		}
	}
}

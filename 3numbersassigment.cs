using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter 3 Numbers, if the multiplicative value of the first 2 is equal the 3rd you win!");
			int a, b, c;
			do
			{
				Console.WriteLine("Enter your numbers:");
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32(Console.ReadLine());
				c = Convert.ToInt32(Console.ReadLine());
			}
			while (a * b != c);
			Console.WriteLine("you Win!");
		}
	}
}

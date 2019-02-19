using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter 3 numbers to check for greatest:");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			int c = Convert.ToInt32(Console.ReadLine());
			if (a>b && a>c)
				{
				Console.WriteLine("The greatest number is:");
				Console.WriteLine(a);
				}
			else if (b>c)
				{
				Console.WriteLine("The greatest number is:");
				Console.WriteLine(b);
				}
			else
				{
				Console.WriteLine("The greatest number is:");
				Console.WriteLine(c);
				}

		}
	}
}

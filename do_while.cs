using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = 1;
			int i = 0;
			Double sum = 0;
			do
			{
				Console.WriteLine("enter a number:");
				number = Convert.ToInt32(Console.ReadLine());
				i = i+ 1;
				sum = sum + number;
				
			}

			while (number != 0);
			i = i - 1;
			Console.WriteLine(sum/i);
		}
	}
}

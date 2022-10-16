using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 5; i >=0 ; i--)
			{
				int space = 5 - i;
				int star = i;
				string row = new string(' ', space) + new string('*', star);
				Console.WriteLine(row);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HissiSimulaatio
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Console.WriteLine("Welcome! What's the max floor? -3 to quit.");
			var UserInput = Console.ReadLine();

			if (UserInput == "-3")
			{
				break;
			}*/
		}

		static int PyydaKokonaisLuku(string kehote)
		{
			int paluu;
			Write($"{kehote} ");
			do
			{
				try
				{
					paluu = int.Parse(ReadLine());
					break;
				}
				catch
				{
					WriteLine("Syöte ei ole kokonaisluku.");
				}
			} while (true);
			return paluu;
		}
	}
}

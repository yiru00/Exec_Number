using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//百元買百雞想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
			//公雞(Cock)x, 母雞(Hen)y, 小雞(Chicken)y

			for (int x = 0; x < 100; x++)
			{
				for (int y = 0; y < 100; y++)
				{
					for (int z = 0; z < 100; z++)
					{
						if (x+y+3*z==100 && 5*x+3*y+z==100)
						{
							Console.WriteLine($"公雞{x}隻、母雞{y}隻、小雞{z}隻");
						}
					}
				}
			}

		}
	}
}

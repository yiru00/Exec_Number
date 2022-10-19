using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//找出數值區間內的所有質數: 1~99
			Console.WriteLine("1~99中的質數有: ");
			for (int i = 1; i < 99; i++)
			{
				
				for (int k = 2; k <= 99;k++)
				{
					
					if (i==k)
					{
						Console.WriteLine(i);
					}
					if (i % k == 0)
					{
						break;
					}
						
				}

			}

		}
		
	}
}


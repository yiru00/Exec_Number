using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//判斷某數值是不是質數
			Console.Write("請輸入一個數");
			string input=Console.ReadLine();
			bool isInt=int.TryParse(input, out int value);
			if (isInt == false)
			{
				Console.WriteLine("錯誤，請輸入數字");
				return;
			}
			int valueSqrt =(int)Math.Ceiling(Math.Sqrt(value));

			//Console.WriteLine(valueSqrt);

			for (int i = 2; i <= valueSqrt ; i++)
			{
				if (value == 2)
				{
					Console.WriteLine("這是質數");
					return ;
				}
				if (value % i == 0)
				{
					Console.WriteLine("這不是質數");
					return;
				}
			}

			Console.WriteLine("這是質數");

		}
	}
}

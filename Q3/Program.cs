using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//有一個數值,是四位數左邊二位的數字相同右邊二位的數字相同這個四位數值, 剛好也是某整數的平方請問這個四位數值是什麼 ?

			//找出所有可能的數 iikk
			for(int i = 1100; i <10000 ; i += 1100)
			{
				for(int k=11; k<100; k += 11)
				{
					int value = i + k;
					double root = Math.Sqrt(value);
					//判斷iikk開根號後是否為整數
					bool check = int.TryParse(root.ToString(), out int result); //若是整數，回傳true
					if (check)
					{
						Console.WriteLine(value);
					}
				}
			}
		}
	}
}

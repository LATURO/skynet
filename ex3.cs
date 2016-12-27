using System;

namespace lllll
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int a;
			int s = 0;
			a = int.Parse(Console.ReadLine());
	
			int[,] array = new int[a, a];
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < a; j++)
				{
					array[i, j] = 1;
				}
			}
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < i+1; j++)
				{
					Console.Write("{0} ", array[i, j]);
				
				}
				Console.WriteLine();
			}

		}
	}
}

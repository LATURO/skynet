using System;

namespace lllll
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			int a;
			a = int.Parse(Console.ReadLine());
			int[][] array = new int[a][];
			for (int i = 0; i < a; i++) {
				array[i] = new int[i+1];
			}
				for (int i = 0; i < a; i++)
				{
					for (int j = 0; j < i+1; j++)
					{
						array[i][j] = i+1 ;
					}
				}
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < i+1; j++)
				{
					Console.Write("{0} ", array[i][j]);

				}
				Console.WriteLine();
			}

		}
	}
}

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
			Random l = new Random();
			int[,] array = new int[a, a];
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < a; j++)
				{
					array[i, j] = l.Next(0,100);
				}
			}
			Console.WriteLine("Матрица");
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < a; j++)
				{
					Console.Write("{0} ", array[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("То что надо посчитать:");
			for (int i = 0; i < a; i++)
			{
				for (int j = 0; j < i+1; j++)
				{
					Console.Write("{0} ", array[i, j]);
					s += array[i, j];
				}
				Console.WriteLine();
			}
			Console.WriteLine("сумма {0}", s);
		}
	}
}

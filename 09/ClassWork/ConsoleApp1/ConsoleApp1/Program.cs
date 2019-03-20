using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		/*
		 * x=y
		 * x<y
		 * x++
		 * 
		 * 
		 */
		static void Main(string[] args)
		{
			var stopwatch = new Stopwatch();
			for (var k = 1; k < 20; k++)
			{


				int[] intialArray = GetTestArray(k * 1000, 1_000_000);

				//WriteArrayState("Initial state: ", intialArray);

				int[] bubbleSortedArray = (int[])intialArray.Clone();



				stopwatch.Start();
				BubbleSort(bubbleSortedArray);
				stopwatch.Stop();

				//WriteArrayState("Sorted state: ", bubbleSortedArray);
				Console.WriteLine($"Bubble sort done in {stopwatch.ElapsedMilliseconds} ms:");
				int[] dotNetSortedArray = (int[])intialArray.Clone();
				stopwatch.Restart();
				Array.Sort(dotNetSortedArray);
				stopwatch.Stop();
				Console.WriteLine($".NET sort done in {stopwatch.ElapsedMilliseconds} ms:");
			}
		}

		private static int [] GetTestArray(int length, int maxValue)
		{

			var result = new int[length];
			var rnd = new Random();
			
			for(var i = 0;i < result.Length;i++)
			{
				result[i] = rnd.Next(maxValue);
			}

			return result;
		}

		private static void WriteArrayState (string message,int[] arr)
		{
			Console.WriteLine(message);

			for (var i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
		
		private static void BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				var limit = arr.Length - 1-i;

				for (int j = 0; j < limit; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}
	}
}

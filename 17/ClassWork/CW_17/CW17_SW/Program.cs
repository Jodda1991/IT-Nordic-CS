using System;
using System.IO;
using System.IO.Compression;

namespace CW17_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			RandomDataGenerator dataGenerator = new RandomDataGenerator();
			dataGenerator.RandomDataGenerated += DataGenerator_RandomDataGenerated;
			dataGenerator.RandomDataGenerationDone += DataGenerator_RandomDataGenerationDone;
			var allBytes = dataGenerator.GetRandomData(100, 10);
			string result = Convert.ToBase64String(allBytes);
			Console.WriteLine(result);
			File.WriteAllBytes("bytesfile.txt", allBytes);

		}

		private static void DataGenerator_RandomDataGenerationDone(object sender, EventArgs e)
		{
			Console.WriteLine("Work Done");
		}

		private static void DataGenerator_RandomDataGenerated(int byteDone, int totalBytes)
		{
			Console.WriteLine($"Generated {totalBytes} from {byteDone}");
		}
	}
}

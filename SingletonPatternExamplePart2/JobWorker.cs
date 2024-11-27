using BaseElements;

namespace SingletonPatternExamplePart2;

public class JobWorker : PatternWorker
{
	public override string Name => "Singleton - Creational Pattern";

	public override void Worker()
	{
		Console.WriteLine("Test Initial...");
		Console.WriteLine();
		MainJob();

		Console.WriteLine("\nTest End...");
		Console.WriteLine();
		MainJob();
	}

	private static void MainJob()
	{
		try
		{
			var chocoEggs = ChocolateMixer.GetInstance();
			chocoEggs.Fill();
			chocoEggs.Boil();
			chocoEggs.Drain();
		}
		catch (Exception)
		{

			Console.Write("Oops");
		}
	}
}

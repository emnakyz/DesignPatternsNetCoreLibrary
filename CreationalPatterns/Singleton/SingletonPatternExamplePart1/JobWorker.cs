using BaseElements;
using SingletonPatternExamplePart1.Services;

namespace SingletonPatternExamplePart1;

public class JobWorker : PatternWorker
{
	public override string Name => "SingletonPatternExamplePart1";

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
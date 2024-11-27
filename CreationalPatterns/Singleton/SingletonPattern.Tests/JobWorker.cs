using BaseElements;

namespace SingletonPattern.Tests;

public class JobWorker : PatternWorker
{
	public override string Name => "SingletonPattern.Tests";

	public override void Worker()
	{
		Console.WriteLine("Test Initial...");
		Console.WriteLine();
		MainJob();
	}

	private static void MainJob()
	{
		SingletonPatternTests singletonPatternTests = new();
		singletonPatternTests.GetInstance_CreateInstanceTwice_AreEqual();
	}
}
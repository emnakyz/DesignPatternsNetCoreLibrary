using BaseElements;
using SingletonPatternExample.Types;

namespace SingletonPatternExample;


public class JobWorker : PatternWorker
{
	public override string Name => "Singleton - Creational Pattern";

	public override void Worker()
	{
		Console.WriteLine("Initial greetings...");
		Console.WriteLine();
		Greet();

		Console.WriteLine("\nGoodbye greetings...");
		Console.WriteLine();
		Greet();
	}

	private static void Greet()
	{
		//SimpleGreeter.Instance.Greet();
		//SimpleThreadSafetyGreeter.Instance.Greet();
		//DoubleCheckGreeter.Instance.Greet();
		//LocklessGreeter.Instance.Greet();
		//LocklessFullyLazyGreeter.Instance.Greet();
		DotNetLazyGreeter.Instance.Greet();
	}
}

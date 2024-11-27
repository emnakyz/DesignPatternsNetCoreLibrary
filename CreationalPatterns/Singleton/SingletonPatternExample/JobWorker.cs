using BaseElements;
using SingletonPatternExample.Types;

namespace SingletonPatternExample;

/// <summary>
/// .NET 4 (veya üzeri) kullanıyorsanız, tembelliği gerçekten basit hale getirmek için Lazy<T> türünü kullanabilirsiniz.
/// Ayrıca, ihtiyacınız varsa, örneğin henüz IsValueCreated özelliğiyle
/// oluşturulup oluşturulmadığını kontrol etmenize olanak tanır.
/// Bu kod, iş parçacığı güvenlik modu olarak dolaylı olarak LazyThreadSafetyMode.ExecutionAndPublication kullanır.
/// Gereksinimlerinize bağlı olarak, diğer modlarla denemeler yapmak isteyebilirsiniz.
/// </summary>
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
		//DotNetLazyGreeter.Instance.Greet();
		DotNetLazyGreeter.Instance.Greet();
	}
}

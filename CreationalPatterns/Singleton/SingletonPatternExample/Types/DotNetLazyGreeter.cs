using SingletonPatternExample.Types.Common;

namespace SingletonPatternExample.Types;
/// <summary>
/// .NET 4 (veya üzeri) kullanıyorsanız, tembelliği gerçekten basit hale getirmek için Lazy<T> türünü kullanabilirsiniz.
/// Ayrıca, ihtiyacınız varsa, örneğin henüz IsValueCreated özelliğiyle
/// oluşturulup oluşturulmadığını kontrol etmenize olanak tanır.
/// Bu kod, iş parçacığı güvenlik modu olarak dolaylı olarak LazyThreadSafetyMode.ExecutionAndPublication kullanır.
/// Gereksinimlerinize bağlı olarak, diğer modlarla denemeler yapmak isteyebilirsiniz.
/// </summary>
public class DotNetLazyGreeter : BaseGreeter
{
	private static readonly Lazy<DotNetLazyGreeter> Lazy = new(() => new DotNetLazyGreeter());

	private DotNetLazyGreeter()
	{

	}
	public static DotNetLazyGreeter Instance => Lazy.Value;
}

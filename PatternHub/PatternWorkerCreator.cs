using BaseElements;


namespace PatternHub;

public class PatternWorkerCreator // Tasarım deseni çalışanlarını yöneten bir sınıf.
{
	// Singleton deseni uygulanıyor. Bu alan sınıfın tek bir örneğini tutar.
	private static PatternWorkerCreator? _instance;
	// PatternWorker öğelerini tutan sıralı bir sözlük. Anahtar olarak int, değer olarak PatternWorker kullanılıyor.
	private readonly SortedDictionary<int, PatternWorker> _workers;

	// Constructor, yalnızca sınıf içinde çağrılabilir. Singleton deseni gereği dışarıdan erişilemez.
	private PatternWorkerCreator()
	{

		var patternWorkers = new List<PatternWorker>
		{
			new SingletonPatternExample.JobWorker(),
			new SingletonPatternExamplePart1.JobWorker(),
			new SingletonPattern.Tests.JobWorker(),
		};
		// Her PatternWorker için benzersiz bir anahtar olarak kullanılacak sayaç.
		var itemNumber = 1;
		// Sıralı bir sözlük oluşturuluyor.
		_workers = new SortedDictionary<int, PatternWorker>();
		foreach (var workers in patternWorkers.OrderBy(e => e.Name))
		{
			_workers.Add(itemNumber++, workers);
			// PatternWorker listesindeki öğeler, adlarına (Name özelliğine) göre sıralanıyor.
			// Sıralanan öğeler sözlüğe ekleniyor ve anahtar olarak itemNumber kullanılıyor.
		}
	}

	// Singleton deseni için static bir erişim noktası. Eğer _instance null ise, yeni bir örnek oluşturulur.
	public static PatternWorkerCreator Instance => _instance ??= new PatternWorkerCreator();

	// Tüm PatternWorker öğelerini döndüren bir yöntem
	public SortedDictionary<int, PatternWorker> GetAll() => _workers;

}

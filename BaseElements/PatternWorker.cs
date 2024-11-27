namespace BaseElements;

// <summary>
// Tüm tasarım deseni örneklerinin bir PatternWorker'dan türeyen bir yürütücü sınıfı olması gerekir.
// </summary>
public abstract class PatternWorker // Abstract bir sınıf tanımlanıyor. Diğer sınıflar bu sınıftan türeyerek spesifik deseni uygular.
{
	// Bu özellik, yürütücü sınıfın adını döndürür. 
	// "virtual" olduğu için türetilmiş sınıflarda gerekirse override edilebilir.
	public virtual string Name => GetType().Name;

	/// <summary>
	/// Worker yöntemi, çalıştırılabilir bir tasarım deseni örneğinin giriş noktasıdır.
	/// Komut menüsünden rastgele bir tasarım deseni seçildiğinde, çağrılan ilk metottur.
	/// </summary>
	public abstract void Worker();

	// Her tasarım deseni örneğinin kendi Worker metodu olmalıdır. 
	// Bu metodun içeriği türetilmiş sınıflarda tanımlanır.
}

using BaseElements;

namespace PatternHub;

public class Program
{
	private const string TerminationCode = "q";
	private static readonly SortedDictionary<int, PatternWorker> Workers = PatternWorkerCreator.Instance.GetAll();

	private static void Main(string[] args)
	{
		while (!IsExitRequested(out string? choice))
		{
			if (IsChoiceDenied(choice, out int choiceKey))
			{
				Console.WriteLine("Lütfen aşağıdaki seçeneklerden birini seçin!");
				continue;
			}

			Workers[choiceKey].Worker();
			WaitForNextStep();
		}

		Console.WriteLine("Çıkış yapıldı..");
		Console.ReadLine();
	}

	private static bool IsExitRequested(out string? choice)
	{
		DisplayMenuOptions();
		choice = SelectMenuOption();

		return choice is TerminationCode;
	}

	private static void DisplayMenuOptions()
	{
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.WriteLine(Environment.NewLine);

		foreach (var workers in Workers)
		{
			Console.WriteLine($"{workers.Key}. {workers.Value.Name}");
		}

		Console.WriteLine($"{TerminationCode}. Çıkış Yap");
	}

	private static string? SelectMenuOption()
	{
		Console.ForegroundColor = ConsoleColor.DarkGray;
		Console.WriteLine("\nSeçiminiz: ");

		var choice = Console.ReadLine();

		Console.ResetColor();

		return choice;
	}

	private static bool IsChoiceDenied(string? choice, out int choiceKey)
	{
		if (choice == null || !int.TryParse(choice, out int key) || !Workers.ContainsKey(key))
		{
			choiceKey = -1;
			return true;
		}

		choiceKey = key;
		return false;
	}

	private static void WaitForNextStep()
	{
		Console.ForegroundColor = ConsoleColor.DarkGreen;
		Console.WriteLine("\n\nSonuçlar yukarıda bulunabilir. Devam etmek için ENTER'a basın.");
		Console.ReadLine();
		Console.ResetColor();
	}
}

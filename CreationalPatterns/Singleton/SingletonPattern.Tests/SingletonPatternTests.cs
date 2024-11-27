using SingletonPatternExamplePart1.Services;

namespace SingletonPattern.Tests;

[TestFixture]
public class SingletonPatternTests
{
	[Test]
	public void GetInstance_CreateInstanceTwice_AreEqual()
	{
		// Arrange, Act
		var firstAttemptInstance = ChocolateMixer.GetInstance();
		var secondAttemptInstance = ChocolateMixer.GetInstance();

		// Assert
		Assert.That(firstAttemptInstance, Is.EqualTo(secondAttemptInstance));
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternExample.Types.Common
{
	public abstract class BaseGreeter
	{
		public virtual void Greet() =>
	          Console.WriteLine($"Selamlar {GetType().Name}!");
	}
}

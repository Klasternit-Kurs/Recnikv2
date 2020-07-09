using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recnikv2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nekiBrojevi = new List<int>();

			Dictionary<string, int> recnik = new Dictionary<string, int>();

			recnik.Add("Prvi kljuc", 1);
			recnik.Add("Drugi kljuc", 2);
			recnik.Add("Treci kljuc", 3);
			recnik.Add("Cetvrti kljuc", 1);

			if (!recnik.ContainsKey("Prvi kljuc"))
			{
				recnik.Add("Prvi kljuc", 6);
			}

			foreach (string kljuc in recnik.Keys)
			{
				Console.WriteLine($"{kljuc} -- {recnik[kljuc]}");
			}

			//Console.WriteLine(recnik.Values.ToList()[1]);

			//Console.WriteLine(recnik["Drugi kljuc"]);
			Console.ReadKey();
		}
	}
}

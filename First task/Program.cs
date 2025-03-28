internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Введите строку для поиска в ней символов x и w");
		string? listOfSimbol = Console.ReadLine();
		if (listOfSimbol != null && listOfSimbol != "")
		{
			Program.Cycle(listOfSimbol);
		}
		else
			Console.WriteLine("-1");
	}
	private static void Cycle(string listOfSimbol)
	{
		for (int i = 0; i < listOfSimbol.Length; i++)
		{
			if ((string?)listOfSimbol.Substring(i, 1) == "x" || (string?)listOfSimbol.Substring(i, 1) == "X")
			{
				Console.WriteLine("Результат x");
				break;
			}
			else if ((string?)listOfSimbol.Substring(i, 1) == "w" || (string?)listOfSimbol.Substring(i, 1) == "W")
			{
				Console.WriteLine("Результат w");
				break;
			}
			else if (i == listOfSimbol.Length - 1)
			{
				Console.WriteLine("-1");
			}

		}
	}
}


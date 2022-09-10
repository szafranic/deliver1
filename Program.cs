using System;	

public class Program
{
	public static void Main()
	{
		string restart;
		do
		{
			const int loafSlices = 28;
			const int pbScoops = 32;
			const int jellyScoops = 48;

			Console.WriteLine("How many people are we making PB and J sandwiches for?");
			int people = int.Parse(Console.ReadLine());
			Console.WriteLine(people);

			double neededBread = 2 * people;
			double neededPB = 2 * people;
			double neededJelly = 4 * people;

			Console.WriteLine("You will need: ");
			Console.WriteLine(neededBread + " slices of bread.");
			Console.WriteLine(neededPB + " tablespoons of peanut butter.");
			Console.WriteLine(neededJelly + " teaspoons of jelly.");


			double totalLoaves = neededBread /= loafSlices;
			double totalPB = neededPB /= pbScoops;
			double totalJelly = neededJelly /= jellyScoops;
			totalLoaves = Math.Ceiling(totalLoaves);
			totalPB = Math.Ceiling(totalPB);
			totalJelly = Math.Ceiling(totalJelly);

			Console.WriteLine("Which totals to: ");
			Console.WriteLine((totalLoaves) + " loaves of bread.");
			Console.WriteLine((totalPB) + " jars of peanut butter.");
			Console.WriteLine((totalJelly) + " jars of jelly.");

			Console.WriteLine("Would you like to restart ? Enter yes or y to continue, or enter any other key to exit.");
			restart = Console.ReadLine();
		} while (restart == "yes" || restart == "y");
		Console.WriteLine("Goodbye!");
	}
}
using System;
using static System.Console;

namespace DailyTemps
{				
	public class Program
	{
		public static void Main()
		{
			const int LOW = -20;
			const int HIGH = 130;
			int sum = 0;
			int count = 0;
			double average = 0;
       			string temperatureString;
			int temperature;
		
			Console.Write ("Enter a temperature between -20 and 130 degrees Fahrenheit. When finished enter ##. ");
		
			temperatureString = Console.ReadLine();
			temperature = Convert.ToInt32(temperatureString);
			  
			while(temperatureString != "##")
			{
				while(temperature < LOW || temperature > HIGH)
				{
					Console.Write("Input of {0} is not a valid temperature. Enter a valid temperature.", temperatureString);
					temperatureString = Console.ReadLine();
					temperature = Convert.ToInt32(temperatureString);
				}
			sum += temperature;
			count++;
			Console.Write ("Enter a temperature between -20 and 130 degrees Fahrenheit. When finished enter ##.");
			temperatureString = Console.ReadLine();
			}
		
			if(temperatureString == "##")
			{
				average = sum / count;
				Console.WriteLine("The number of temperatures entered was {0} with an average of {1}.", count, average);
			}
		}
	}
}

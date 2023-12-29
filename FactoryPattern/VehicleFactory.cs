using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public static string InputChecker(string input, string condition1, string condition2)
		{
			while (input != condition1 && input != condition2)
			{
				Console.WriteLine("Please Enter a Valid Input");
				Console.WriteLine($"Please enter either {condition1} or {condition2}.");
				input = Console.ReadLine().ToLower();
            }

			return input;
		}

		public static IVehicle GetVehicle()
		{
			Console.WriteLine("Let's Build a Car!");
			Console.WriteLine("Would you like 2 or 4 tires?");

            string tires = InputChecker(Console.ReadLine(), "2", "4");

			if (tires == "2")
			{
                Console.WriteLine("You've built a motorcycle!");
                return new Motorcycle(); 
			}
			else
			{
				Console.WriteLine("Would you like to build a car or a truck?");
                string vehicleType = InputChecker(Console.ReadLine().ToLower(), "car", "truck");

				if (vehicleType == "car")
				{
					Console.WriteLine("You've built a car!");
					return new Car();
				} else
				{
                    Console.WriteLine("You've built a truck!");
                    return new Truck();
				}

			}

		}

		
	}
}


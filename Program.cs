using System;

class Program
{
    static void Main ()
    {
        Console.Write("Enter the number of cities: ");
        int numberOfCities = int.Parse(Console.ReadLine());

        string[] cityNames = new string[numberOfCities];
        int[] contacts = new int[numberOfCities];
        int[] diseaseLevels = new int[numberOfCities];

        for (int i = 0; i < numberOfCities; i++)
        {
            Console.Write($"\nEnter the name of city {i}: ");
            cityNames[i] = Console.ReadLine();

            Console.Write("Enter the number of cities connected to this city: ");
            contacts[i] = int.Parse(Console.ReadLine());

            while (contacts[i] >= i || contacts[i] == i + 1 || contacts[i] >= numberOfCities)
            {
                Console.WriteLine("Invalid ID");
                Console.Write("Enter the number of cities connected to this city: ");
                contacts[i] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nCity Details:");
        for (int i = 0; i < numberOfCities; i++)
        {
            Console.WriteLine($"City ID: {i}, City Name: {cityNames[i]}, Disease Level: {diseaseLevels[i]}");
        }

        string eventMessage = "";
        while (eventMessage != "Exit")
        {
            Console.Write("\nEnter an event (Outbreak, Vaccinate, Lock down, Spread, or Exit): ");
            eventMessage = Console.ReadLine();

            if (eventMessage == "Outbreak" || eventMessage == "Vaccinate" || eventMessage == "Lock down")
            {
                Console.Write("Enter the city ID where the event occurred: ");
                int cityId = int.Parse(Console.ReadLine());

                while (cityId >= numberOfCities)
                {
                    Console.WriteLine("Invalid ID");
                    Console.Write("Enter the city ID where the event occurred: ");
                    cityId = int.Parse(Console.ReadLine());
                }

                if (eventMessage == "Outbreak")
                {
                    diseaseLevels[cityId] += 2;

                    for (int i = 0; i < numberOfCities; i++)
                    {
                        if (contacts[i] == cityId)
                        {
                            diseaseLevels[i] += 1;
                        }
                    }
                }
                else if (eventMessage == "Vaccinate")
                {
                    diseaseLevels[cityId] = 0;
                }
                else if (eventMessage == "Lock down")
                {
                    diseaseLevels[cityId] -= 1;

                    for (int i = 0; i < numberOfCities; i++)
                    {
                        if (contacts[i] == cityId)
                        {
                            diseaseLevels[i] -= 1;
                        }
                    }
                }

                Console.WriteLine("\nUpdated City Details:");
                for (int i = 0; i < numberOfCities; i++)
                {
                    Console.WriteLine($"City ID: {i}, City Name: {cityNames[i]}, Disease Level: {diseaseLevels[i]}");
                }
            }
            else if (eventMessage == "Spread")
            {
                bool isSpread = false;

                for (int i = 0; i < numberOfCities; i++)
                {
                    if (diseaseLevels[i] > 0)
                    {
                        for (int j = 0; j < numberOfCities; j++)
                        {
                        }
                    }
                }
            }
        }
    }
}
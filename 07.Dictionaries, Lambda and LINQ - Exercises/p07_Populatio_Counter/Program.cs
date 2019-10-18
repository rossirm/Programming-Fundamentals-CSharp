using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> lands = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            string country;
            string city;
            long population;
            while (input[0] != "report")
            {
                country = input[1];
                city = input[0];
                population = long.Parse(input[2]);
                if (!lands.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);

                    lands.Add(country, currentCity);
                }
                else
                {
                    if (!lands[country].ContainsKey(city))
                    {
                        lands[country].Add(city, population);
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }
            foreach (var pair in lands.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}

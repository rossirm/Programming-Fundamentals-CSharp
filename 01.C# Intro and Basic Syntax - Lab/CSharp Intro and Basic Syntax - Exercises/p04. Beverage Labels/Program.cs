using System;

namespace p04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            short volume = short.Parse(Console.ReadLine());
            short energyContentPer100Ml = short.Parse(Console.ReadLine());
            short sugarContentPer100Ml = short.Parse(Console.ReadLine());

            double energyContent = (volume / 100.0) * energyContentPer100Ml;
            double sugarContent = (volume / 100.0) * sugarContentPer100Ml;

            Console.Write("{0}ml ", volume);
            Console.WriteLine("{0}:", name);
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars ");
        }
    }
}
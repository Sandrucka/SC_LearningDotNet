using System;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Colors = { "White", "Green", "Yellow", "Red", "Blue" };

            Console.WriteLine("Array of colors:");

            foreach (String a in Colors)

                Console.WriteLine(a);
            
            int[] Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            Console.WriteLine("\nArray of numbers:");

            for (int i = Numbers.Length -1; i >=0 ; i--)
            
                Console.WriteLine(Numbers[i]);
            
        }
    }
}

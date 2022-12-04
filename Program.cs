using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int validCombination = 0;

            for (int leftNumber = startInterval; leftNumber <= endInterval; leftNumber++)
            {
                for (int rightNumber = startInterval; rightNumber <= endInterval; rightNumber++)
                {
                    counter++;
                    int sum = leftNumber + rightNumber;
                    if (sum == magicNumber)
                    {
                        validCombination++;

                        Console.WriteLine($"Combination N:{counter} ({leftNumber} + {rightNumber} = {sum})");

                        break;
                    }

                }
                if (validCombination == 1)
                {
                    break;
                }
            }
            if (validCombination != 1)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}

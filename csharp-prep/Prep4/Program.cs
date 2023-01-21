using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        float sum = 0;
        List<float> numbers = new List<float>();
        float end = 0;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        bool check = true;

        while (check)
        {
            Console.Write("Enter a number: ");
            string strNum = Console.ReadLine();
            float num = int.Parse(strNum);

            if (num != end)
            {
                numbers.Add(num);
            }
            else
            {
                check = false;
            }
        }

        float maxNumber = numbers[0];
        List<float> postiveNums = new List<float>();

        foreach (var number in numbers)
        {
            sum += number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            if (number > 0)
            {
                postiveNums.Add(number);
            }
        }

        float minPostiveNumber = postiveNums[0];

        foreach(var positveNum in postiveNums)
        {
            if (positveNum < minPostiveNumber)
            {
                minPostiveNumber = positveNum;
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {minPostiveNumber}");

    }
}
  35  
csharp-prep/Prep5/Program.cs
@@ -4,6 +4,39 @@ class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
       DisplayWelcome();
       string name = PromptUserName();
       int number = PromptUserNumber();
       int squareOfNumber = SquareNumber(number);
       DisplayResult(name, squareOfNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);

        return number;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;

        return squareNumber;
    }
    static void DisplayResult(string name, int squareOfNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareOfNumber}");
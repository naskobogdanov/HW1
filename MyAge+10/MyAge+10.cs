using System;

class MyAge10
{
    static void Main()
    {
        Console.WriteLine("Please enter your birth year below...");

        int startingYear = 1900;
        int nowadays = DateTime.Now.Year;
        int birthYear = int.Parse(Console.ReadLine());
        int currentAge = (nowadays - birthYear);
        int inTenYears = currentAge + 10;

        
        if (birthYear >= startingYear && birthYear < nowadays)
        {
            Console.WriteLine("You are now " + currentAge + " Years Old");

            Console.WriteLine("10 Years from now you will be: " + inTenYears + " Years Old");
        }
        else
        {
            Console.WriteLine("Sorry! You either entered a wrong Birth Year or you're too old!");
        }
        Console.ReadKey();
    }
}

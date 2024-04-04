namespace ConsoleApp7;

public static class Extension
{
    public static void IsPrime(this int number)
    {
        if (number == 1) Console.WriteLine("Number is 1");
        else if (number ==2) Console.WriteLine("Number is 2");
        else if (number <= 0) Console.WriteLine("Number must be more than 0");
        else
        {
            int count = 0;
            for (int i = 3; i<=number/2; i++)
            {
                if (number%i==0) count++;
            }
            if (count == 0) Console.WriteLine("Number is prime");
            else Console.WriteLine("Number is not prime");
        }
    }
    public static void Factorial(this int number)
    {
        if (number == 0 && number == 1) Console.WriteLine($"Result : 1");
        else if (number < 0) Console.WriteLine("Enter number more than 0");
        else
        {
            int temp = 1;
            for (int i = number; i>1; i--)
            {
                temp *= i;
            }
            Console.WriteLine($"Result : {temp}");
        }
    }
    public static double Fahrenheit(this int number)
    {
        return (number * 1.8) + 32;
    }
    public static int Celcius(this int number)
    {
        return (int)Math.Round((number - 32) / 1.8);
    }
}

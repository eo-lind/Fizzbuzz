for (int theNumber = 1; theNumber <= 100; theNumber++)
{
    if (theNumber % 15 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (theNumber % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (theNumber % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(theNumber);
    }
}
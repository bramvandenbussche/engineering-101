namespace Demo;

public class Calculator
{
    public double Value;

    public double DoSum(double a, int b)
    {
        var sum = a + b;
        Value = sum;
        return sum;
    }

    public void Display(string x)
    {
        Console.WriteLine(x);
    }
}

public class Car
{
    public int NumberOfSeats;

    public string Make;

    public string Model;

    public string MakeNoise()
    {
        return $"{Make} {Model} does vroem vroem";
    }
}
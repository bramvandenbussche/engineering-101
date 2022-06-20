namespace Demo;

public class Calculator
{
    public double Value;

    public double DoSum(double a, int b)
    {
        return a + b;
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
}
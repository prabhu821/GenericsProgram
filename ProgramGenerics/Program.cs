namespace ProgramGenerics;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generics Program");
        int output = FindMaxNumber.MaxIntegerNumber(10, 3, 5);
        Console.WriteLine(output);
    }
}
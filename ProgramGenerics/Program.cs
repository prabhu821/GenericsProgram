namespace ProgramGenerics;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generics Program");
        int output = FindMaxNumber.MaxIntegerNumber(10, 3, 5);
        Console.WriteLine(output);

        double output1 = FindMaxNumber.MaxFloatNumber(10.2, 3.3, 5.4);
        Console.WriteLine(output1);

        string stringoutput = FindMaxNumber.MaxString("Strawberry", "Apple", "Banana");
        Console.WriteLine(stringoutput);
    }
}
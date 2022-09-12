internal class Program
{
    private static void Main(string[] args)
    {
        // Input two value into the program
        Console.WriteLine("Input value a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input value b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        //Create some calculations
        int c = a + b;
        Console.WriteLine("Sum of a and b is equal to: " + c);
        int d = a - b;
        Console.WriteLine("Subtract of a and b is equal to: " + d);
        int e = a * b;
        Console.WriteLine("Multiplication of a and b is: " + e);
        int f = a / b;
        Console.WriteLine("Division of a to b is: " + f);
        int g = a % b;
        Console.WriteLine("Modulus between a and b is: " + g);

    }
}
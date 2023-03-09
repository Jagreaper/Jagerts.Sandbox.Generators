
using Jagerts.Sandbox.Generators.AutoProperties.Sample.Models;

namespace Jagerts.Sandbox.Generators.AutoProperties.Sample;

internal static class Program
{
    public static void Main(string[] args)
    {
        Shape square = new() { Length = 5, Width = 5 };

        Console.WriteLine($"Length: {square.Length}");
        Console.WriteLine($"Width: {square.Width}");
        Console.WriteLine($"Area: {square.Length * square.Width}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
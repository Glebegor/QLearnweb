using QLearn.Bootstrap;

namespace QLearn;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Server server = new Server("localhost", 5000);
    }
}

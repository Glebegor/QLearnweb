using backend.Bootstrap;

namespace backend;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
		App app = new App();
        app.Run();
    }
}

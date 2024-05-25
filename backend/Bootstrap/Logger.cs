namespace backend.Bootstrap;

public class Logger
{
    private Config config;
    
    public Logger(Config config)
    {
        this.config = config;
    }

    public void LoggToConsole(string message, ConsoleColor color)
    {   
        // Save the current console color
        ConsoleColor originalColor = Console.ForegroundColor;

        // Set the desired color
        Console.ForegroundColor = color;

        // Write the message part in the specified color
        if (color == ConsoleColor.Red)
        {
            Console.Write("ERROR - ");
            Console.ForegroundColor = originalColor;
            Console.WriteLine(DateTime.Now + "; " + message);
        }
        else if (color == ConsoleColor.Green)
        {
            Console.Write("ACCEPT - ");
            Console.ForegroundColor = originalColor;
            Console.WriteLine(DateTime.Now + "; " + message);
        }
        
    }
    // public LoggError()
    // {
    //     
    // };
    // public LoggRequests() {};
}
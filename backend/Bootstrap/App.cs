namespace backend.Bootstrap;


public class App
{
    private Server server;

    public App()
    {
        this.server = new Server("localhost", 3500);
    }
    public void Run()
    {
        server.Run();
    }
}
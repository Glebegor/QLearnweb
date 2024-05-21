namespace QLearn.Bootstrap;

public class Server
{
    private int port;
    private string host;
    private string url;
    
    public Server()
    {
        this.args = args;
        this.port = 5000;
        this.host = "http://localhost";
        this.url = $"{this.host}:{this.port}";
    }
}
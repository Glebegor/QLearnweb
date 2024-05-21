using System.Net;
using System.Net.Sockets;

namespace backend.Bootstrap;

public class Server
{
    public HttpListener httpListener;
    private int port;
    private string host;
    private string url;
    
    public Server(string host, int port)
    {
        this.httpListener = new HttpListener();
        this.port = port;
        this.host = host;
        this.url = $"{this.host}:{this.port}";
        
        httpListener.Prefixes.Add($"http://{this.url}/");
    }
    
    public async Task Run()
    {
        Console.WriteLine($"Server started at {this.url}");
        Console.WriteLine("________________________________________________________");
        while (true)
        {
            
        }
    }
}
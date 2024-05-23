using System.Net;
using System.Net.Sockets;

namespace backend.Bootstrap;

public class Server
{
    public HttpListener HttpListener;
    private int port;
    private string host;
    private string url;
    
    public Server(string host, int port)
    {
        this.HttpListener = new HttpListener();
        this.port = port;
        this.host = host;
        this.url = $"{this.host}:{this.port}";
        
        HttpListener.Prefixes.Add($"http://{this.url}/");
    }
    
    public async Task Run()
    {
        Console.WriteLine($"Server started at {this.url}");
        Console.WriteLine("________________________________________________________");
        this.HttpListener.Start();
        ThreadPool.QueueUserWorkItem((o) =>
        {
            while (this.HttpListener.IsListening)
            {
                HttpListenerContext context = this.HttpListener.GetContext();
                Console.WriteLine("Request received");
            }
        });
        Console.ReadKey();
        this.HttpListener.Stop();
    }
}
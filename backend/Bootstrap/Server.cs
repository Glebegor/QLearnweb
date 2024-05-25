using System;
using System.Net;
using System.Text;
using backend.Api.Controller;

namespace backend.Bootstrap;

public class Server
{
    public HttpListener HttpListener;
    private Config config;
    private Logger logger;
    
    private int port;
    private string host;
    private string url;
    private Database database;

    
    public Server(Config config, Logger logger, Database database)
    {
        this.HttpListener = new HttpListener();
        this.config = config;
        this.logger = logger;
        this.database = database;
        
        this.port = config.Server.PORT;
        this.host = config.Server.HOST;
        this.url = $"{this.host}:{this.port}";
        
        HttpListener.Prefixes.Add($"http://{this.url}/");
    }
    
    public async Task Run(Controller controller)
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
                    
                controller.HandleRequest(context);
                
                // Default Response
                string jsonResponse = "{\"status\": \"Hello world\"}";
                byte[] buffer = Encoding.UTF8.GetBytes(jsonResponse);
                
                context.Response.StatusCode = 200;
                context.Response.ContentType = "application/json";
                context.Response.ContentLength64 = buffer.Length;
                
                using (var output = context.Response.OutputStream)
                {
                    output.Write(buffer, 0, buffer.Length);
                }
                context.Response.OutputStream.Close();
            }
        });
        Console.ReadKey();
        this.HttpListener.Stop();
    }
}
﻿using backend.Bootstrap;

namespace backend;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Server server = new Server("localhost", 5000);
    }
}

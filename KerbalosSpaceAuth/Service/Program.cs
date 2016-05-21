using System;
using System.Net;

namespace Service
{
    internal class Program
    {
        private static MetarService _service = new MetarService();

        private static void Main(string[] args)
        {
            Console.WriteLine($"Service started at {IPAddress.Any}");
        }
    }
}
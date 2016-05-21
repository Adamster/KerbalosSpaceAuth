using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    internal class Reader
    {
        public Reader()
        {
            Poehali();
        }

        private async void Poehali()
        {
            var client = new HttpClient {BaseAddress = new Uri("http://localhost:9999/")};
            var response = await Response(client);

            Console.WriteLine(response);
            Console.ReadLine();
        }

        private static async Task<string> Response(HttpClient client)
        {
            return await client.GetStringAsync("");
        }
    }
}
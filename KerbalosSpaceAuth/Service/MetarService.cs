using System;
using System.IO;
using System.Net;

namespace Service
{
    public class MetarService
    {
        private readonly HttpListener _listener;

        public MetarService()
        {
            var url = "http://127.0.0.1";
            var port = "9999";
            var prefix = $"{url}:{port}/";

            var listener = new HttpListener();
            listener.Prefixes.Add(prefix);

            listener.Start();

            Console.WriteLine("Welcome to Metar Service.\n");
            Console.WriteLine($"Listening on {prefix}...");

            while (true)
            {
                var context = listener.GetContext();
                var request = context.Request;
                var response = context.Response;

                string requestBody = GetLatestMetar();
                var inputStream = request.InputStream;
                var encoding = request.ContentEncoding;
                var reader = new StreamReader(inputStream, encoding);
                requestBody = reader.ReadToEnd();

                Console.WriteLine("{0} request was caught: {1}",
                    request.HttpMethod, request.Url);

                response.StatusCode = (int) HttpStatusCode.OK;

                //Возвращаем ответ
                using (var stream = response.OutputStream)
                {
                   
                }
            }
        }

        public void StopListener()
        {
            _listener.Stop();
        }


        public string GetLatestMetar()
        {
            return "LUKK 201530Z 29009KT 9999 FEW049 21/05 Q1014 R26/CLRD// NOSIG";
        }
    }
}
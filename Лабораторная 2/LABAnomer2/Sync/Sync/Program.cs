using System;

namespace ConsoleApp
{
    class Request
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var urls = new[] { "https://api.hh.ru/openapi/redoc#section/Obshaya-informaciya/Vybor-sajta", "https://www.litres.ru/book/mihail-bulgakov/master-i-margarita-666/", "https://docs.google.com/document/d/1IGzpFmwl9hRWM4P9bAjw41E8CKKI3NhV/edit" };

            var startTime = DateTime.Now;
            for (int i = 0; i < urls.Length; i++)
            {
                var response = client.GetAsync(urls[i]).Result;
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"URL{i + 1}: Error: {response.StatusCode}");
                }
                else
                {
                    var JSON = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"URL{i + 1}: {JSON}");
                }
            }
            var endTime = DateTime.Now;
            Console.WriteLine($"Total time: {endTime - startTime}");
        }
    }
}
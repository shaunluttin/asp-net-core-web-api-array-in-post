using System;
using System.Net.Http;
using System.Text;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            const string obj = @"
{
    'Cart': {
        'Product': [
            {
                'Sku': '123',
                'Size': 'S',
                'quantity': '1'
            },
            {
                'Sku': '456',
                'Size': 'M',
                'quantity': '2'
            },
            {
                'Sku': '789',
                'Size': 'L',
                'quantity': '3'
            }
        ],
        'ShipToZip': '54452',
        'ShipMethod': 'Ground'
    }
}";

            var content = new StringContent(obj.ToString(), Encoding.UTF8, "application/json");
            var result = client.PostAsync("https://localhost:5001/api/values", content).GetAwaiter().GetResult();

            Console.WriteLine(result);
            Console.WriteLine(result.Content.ReadAsStringAsync().GetAwaiter().GetResult());
        }
    }
}

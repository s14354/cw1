using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);
            var body = await response.Content.ReadAsStringAsync();
            var words = body.Split(' ');
            foreach(String word in words)
            {
                if (word.Contains('@'))
                    System.Console.Out.WriteLine(word);
            }
        }
    }
}

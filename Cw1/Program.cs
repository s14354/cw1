using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(args[0]);
            if (response.IsSuccessStatusCode) {
                var body = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z0-9]+@[a-z0-9]+\\.[a-z]+",RegexOptions.IgnoreCase);
                var matches = regex.Matches(body);
                foreach (var email in matches) {
                    Console.WriteLine(email);
                }
            }
        }
    }
}

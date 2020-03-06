using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tut1
{
    public class Program
    {
       public  static async Task Main(string[] args)
        {
            var url = "https://www.pja.edu.pl";
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            


            var regex = new Regex(@"[a-z][A-Z]@");
            var content = response.Content;

            var matches = regex.Matches(content.ToString());

            foreach (var match in matches) {
                Console.WriteLine(match.ToString());
            }
            Console.ReadLine();
        }
    }
}

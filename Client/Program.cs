// <copyright  company="TRUMPF GmbH + Co. KG">
// All rights reserved to TRUMPF GmbH + Co. KG, Germany.
// </copyright>

namespace Client
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        private const string TOKEN = "";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter key to delete:");
            var identifier = Console.ReadLine();

            var response = await new HttpClientBookStore().DeleteAsync(identifier, TOKEN);
            Console.WriteLine($"Status-Code {response.StatusCode} for {identifier}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
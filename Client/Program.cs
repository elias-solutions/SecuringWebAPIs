// <copyright  company="TRUMPF GmbH + Co. KG">
// All rights reserved to TRUMPF GmbH + Co. KG, Germany.
// </copyright>

using Auth0.AuthenticationApi;
using Auth0.ManagementApi;

namespace Client
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        private const string TOKEN = "";

        static async Task Main(string[] args)
        {
            var client = new AuthenticationApiClient(new Uri("https://dev-jonas-elias.eu.auth0.com/"));
            client.
    


            //Console.WriteLine("Enter key to delete:");
            //var identifier = Console.ReadLine();

            //Console.WriteLine($"Status-Code {response.StatusCode} for {identifier}");

            //Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
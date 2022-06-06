using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace az204app
{
    class Program
    {
        private const string _clientId = "7b22162d-0c7c-41fd-b9d8-dd7bbf8733b4"; 
        
        private const string _tenantId = "cd481eae-afd4-4f4a-a766-eb8572ef306d";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri("http://localhost")
            .Build();
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
           {
                Console.WriteLine("25000 USD in sight!");
           }
        }
    }
}

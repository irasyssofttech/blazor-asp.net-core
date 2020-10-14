using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CustomDYOClient.Services;
using Microsoft.AspNetCore.Components;
using CustomDYOClient.wwwroot;

namespace CustomDYOClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
          
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient<IProductCategoryServices, ProductCategoryServices>();

            builder.Services.AddSingleton(async p =>
            {
                var httpClient = p.GetRequiredService<HttpClient>();
                return await httpClient.GetJsonAsync<Settings>("Settings.json")
                    .ConfigureAwait(false);
            });

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}

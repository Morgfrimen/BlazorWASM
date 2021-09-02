
using System;
using System.Net.Http;

using BlazorWASM;
using BlazorWASM.Logger;
using BlazorWASM.Service;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using static Microsoft.AspNetCore.Components.WebAssembly.Hosting.WebAssemblyHostBuilder;



WebAssemblyHostBuilder? builder = CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp =>
new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
}
);
builder.Logging.SetMinimumLevel(LogLevel.Debug);
builder.Logging.AddProvider(new CustomLoggerProvaider());
builder.Services.AddScoped<WindowSizeService>();
await builder.Build().RunAsync();

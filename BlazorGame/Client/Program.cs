using BlazorGame.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorGame.Client.Service;
using Radzen;
using Blazored.Toast;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUnitService, UnitService>();
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<IDevRecordService, DevRecordService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
await builder.Build().RunAsync();

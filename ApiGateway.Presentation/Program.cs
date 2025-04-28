using Ocelot.DependencyInjection;
using Ocelot.Cache.CacheManager;
using ECommmerce.SharedLibrary.DependencyInjection;
using ApiGateway.Presentation.Middleware;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);




builder.Configuration.AddJsonFile
    ("Ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot().AddCacheManager(x => x.WithDictionaryHandle());

JWTAuthenticationscheme.AddJWTAuthenticationScheme(builder.Services, builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
        });
});
var app = builder.Build();
app.UseCors();
app.UseMiddleware<AttachSignatureToRequest>();
app.UseOcelot().Wait();
app.UseHttpsRedirection();



app.Run();


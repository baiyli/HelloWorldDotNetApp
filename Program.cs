var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => ".NET runtime version: "+Environment.Version.ToString());

app.Run();

using RealChat.Hubs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endPoints =>
{
    endPoints.MapHub<ChatHub>("/chat"); 
});

app.Run();

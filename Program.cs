using RealChat.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endPoints =>
{
    endPoints.MapHub<ChatHub>("/chat"); 
});

app.Run();

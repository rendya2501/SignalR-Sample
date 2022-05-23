using SignalRSample;

var builder = WebApplication.CreateBuilder(args);
// SignalR�ǉ�
builder.Services.AddSignalR();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapHub<ChatHub>("/chatHub");

app.Run();

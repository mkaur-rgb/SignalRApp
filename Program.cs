var builder = WebApplication.CreateBuilder(args);

// ✅ Configure CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5073") // 🔹 Allow frontend origin
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});


// ✅ Register SignalR service
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// ✅ FIX: Move `UseCors()` BEFORE `UseRouting()`
app.UseCors();

app.UseRouting();

// ✅ Map SignalR Hub
app.MapHub<ChatHub>("/chathub");

app.Run();

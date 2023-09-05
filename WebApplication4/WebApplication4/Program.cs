var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  //подключение поддежрки контроллеров

var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
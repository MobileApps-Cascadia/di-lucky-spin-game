var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
//TODO : Enable DIJ Services for IRepository and ITextTransform


var app = builder.Build();

/* Middleware in the HTTP Request Pipeline
 */
app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Spinner/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/",
    defaults: new
    {
        controller = "Spinner",
        action = "Index"
    });

app.Run();



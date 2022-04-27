var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.Map("/map1", mapappbuilder =>
{
    mapappbuilder.Run(async context=>
    {
        await context.Response.WriteAsync("Map1\n");
    });
});

app.UseWhen(context => context.Request.Query.ContainsKey("Branch"),
    myconappbuilder => {

        myconappbuilder.Use(async (context, next) =>
       {
           await context.Response.WriteAsync("Use When\n");
           await next();
           await context.Response.WriteAsync("55\n");
       });
    });

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("First Middleware\n");
    await next();
    await context.Response.WriteAsync("5\n");
});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Second Middleware\n");
    await next();
    await context.Response.WriteAsync("4\n");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello Run mathod\n");
    await context.Response.WriteAsync("3\n");

});




app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();






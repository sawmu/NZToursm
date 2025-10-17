using Tourism.Data; // <-- keep usings at the top

var builder = WebApplication.CreateBuilder(args);

// MVC + (optional) Razor Pages
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Seed demo data
AppDb.Seed();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        var path = ctx.File.PhysicalPath?.ToLowerInvariant();
        if (path is not null && (path.EndsWith(".css") || path.EndsWith(".js") || path.EndsWith(".jpg")
            || path.EndsWith(".jpeg") || path.EndsWith(".png") || path.EndsWith(".webp") || path.EndsWith(".svg")))
        {
            // Cache static assets for 30 days
            ctx.Context.Response.Headers["Cache-Control"] = "public,max-age=2592000,immutable";
        }
    }
});

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Destinations}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

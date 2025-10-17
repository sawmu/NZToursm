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
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Destinations}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

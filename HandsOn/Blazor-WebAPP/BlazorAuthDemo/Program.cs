using BlazorAuthDemo.Components;
using BlazorAuthDemo.Data;
using BlazorAuthDemo.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// -------------------- Services --------------------

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
    options.AccessDeniedPath = "/access-denied";
});
//builder.Services.AddScoped(sp =>
//{
//    var nav = sp.GetRequiredService<NavigationManager>();
//    return new HttpClient
//    {
//        BaseAddress = new Uri(nav.BaseUri)
//    };
//});

builder.Services.AddAuthorization();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("ServerAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7131/");
});


// -------------------- App --------------------

var app = builder.Build();

// ---- Seed Roles & Admin ----
using (var scope = app.Services.CreateScope())
{
    await DbInitializer.SeedAsync(scope.ServiceProvider);
}

// -------------------- Middleware --------------------
app.UseAntiforgery();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

// -------------------- Minimal API (LOGIN) --------------------

app.MapPost("/api/login", async (
    LoginRequest request,
    SignInManager<ApplicationUser> signInManager) =>
{
    var result = await signInManager.PasswordSignInAsync(
        request.Email,
        request.Password,
        false,
        false);

    return result.Succeeded
        ? Results.Ok()
        : Results.Unauthorized();
});

// -------------------- Blazor --------------------

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();

// -------------------- DTO --------------------
record LoginRequest(string Email, string Password);

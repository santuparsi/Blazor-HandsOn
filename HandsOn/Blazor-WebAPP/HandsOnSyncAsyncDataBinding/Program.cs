using HandsOnSyncAsyncDataBinding.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
//what is this?
//Antiforgery is a security feature that helps protect web applications from Cross-Site Request
//Forgery (CSRF) attacks. CSRF attacks occur when a malicious website tricks a user's browser into making unwanted requests to a different website where the user is authenticated. By enabling antiforgery protection, the application can ensure that requests made to it are legitimate and originate from trusted sources, thereby enhancing the security of the application.
app.UseAntiforgery();// Enable antiforgery protection

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

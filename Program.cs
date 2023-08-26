using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

string? environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

WebApplicationBuilder builder;

if ("Development".Equals(environment)) {
    builder = WebApplication.CreateBuilder(new WebApplicationOptions() {
        WebRootPath = "ClientApp/dist"
    });
} else {
    builder = WebApplication.CreateBuilder(args);
}

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // 30 days    
} else {
    // var baseDir = app.Environment.ContentRootPath;
    // AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(baseDir, "App_Data"));
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

using Microsoft.EntityFrameworkCore;
using sigestel.Models;
using sigestel.Services.contract;
using sigestel.Services.Implementation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MaxDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

//Agregar servicio de autentificación

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Inicio/IniciarSesion";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20); //La cookie durará 20 minutos
    });

//Función para deshabilitar el caché y que alguien que se ha salido no pueda volver a una vista anterior
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(
        new ResponseCacheAttribute 
        {
            NoStore = true,
            Location = ResponseCacheLocation.None,
        }
        );
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

//Dice donde empieza la aplicación (en este caso en el iniciar sesion)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=IniciarSesion}/{id?}");

app.Run();

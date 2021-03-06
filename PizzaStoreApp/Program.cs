using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using PizzaStoreApp.Data;
using PizzaStoreApp.Data.Repositories;
using PizzaStoreApp.Interfaces;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContextFactory<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IingredientRepository, IngredientRepository>();
builder.Services.AddScoped<IIngredientTypeRepository, IngredientTypeRepository>();
builder.Services.AddScoped<IPizzaBuilderRepository, PizzaBuilderRepository>();
builder.Services.AddScoped<ICrustTypeRepository, CrustTypeRepository>();
builder.Services.AddScoped<IPizzaSizeRepository, PizzaSizeRepository>();
builder.Services.AddScoped<IBakeStyleRepository, BakeStyleRepository>();
builder.Services.AddScoped<ICutStyleRepository, CutStyleRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

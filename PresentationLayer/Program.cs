using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayer;
using BusinessLayer.Implementations;
using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.Implementations;
using EntityLayer.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});

builder.Services.AddAutoMapper(x =>
{
    x.AddExpressionMapping(); // expressionlar? map'lemek için.
    x.AddProfile(typeof(Maps));

});

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services.AddScoped<IBookTypeRepository, BookTypeRepository>();
builder.Services.AddScoped<IBookTypeService, BookTypeService>();

//builder.Services.AddTransient<IBookService, BookService>();
//builder.Services.AddTransient<IBookTypeService, BookTypeService>();
//builder.Services.AddTransient<IAuthorService, AuthorService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

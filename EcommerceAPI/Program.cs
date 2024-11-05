using EcommerceAPI.Repositories.ProductRepo;
using EcommerceAPI.StoreContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EcommerceContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

}
);
builder.Services.AddScoped<IproductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
var scope = app.Services.CreateScope();
var services= scope.ServiceProvider;
var context= services.GetRequiredService<EcommerceContext>();
var logger = services.GetRequiredService<ILogger<Program>>();
 try{
    await context.Database.MigrateAsync();
}
catch(System.Exception ex)
{
    logger.LogError(ex, "error occured during migration");
}

app.Run();

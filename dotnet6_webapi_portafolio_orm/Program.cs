using db_portafolio;
using dotnet6_webapi_portafolio_orm.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyección de dependencia ----------------------------------------------------------------
builder.Services.AddDbContext<PortafolioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RutaLocalSQL1"));
});

builder.Services.AddTransient(_ => new ConexionDBContext(builder.Configuration.GetConnectionString("RutaLocalSQL1")));
// -----------------------------------------------------------------------------------------

var app = builder.Build();

//swagger as default and Cors --------------------------------------------------------------
//app.UseCors(x => x
//            .AllowAnyMethod()
//            .AllowAnyHeader()
//            .SetIsOriginAllowed(origin => true) // allow any origin
//            .AllowCredentials());

//app.UseSwaggerUI(options =>
//{
//    options.SwaggerEndpoint("./swagger/v1/swagger.json", "v1");
//    options.RoutePrefix = string.Empty;
//});

//app.UseSwagger(options =>
//{
//    options.SerializeAsV2 = true;
//});
//------------------------------------------------------------------------------------------

//// Migrar BD -------------------------------------------------------------------------------
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PortafolioContext>();
    context.Database.Migrate();
}
// -----------------------------------------------------------------------------------------

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

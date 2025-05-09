using ProdutosApp.Infra.Data.Extensions;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//Registrando os serviços de injeção de dependência
builder.Services.AddEntityFramework(builder.Configuration);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    //c =>
    //{
    //    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    //    {
    //        Title = "ProdutosApp API",
    //        Version = "v1"
    //    });
    //}
    );

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//Swagger
app.UseSwagger();
app.UseSwaggerUI(
    //    c =>
    //{
    //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProdutosApp API V1");
    //    c.RoutePrefix = string.Empty; // Set the Swagger UI at the app's root
    //}
    );

//Scalar
app.MapScalarApiReference(options => {
    options.WithTheme(ScalarTheme.BluePlanet);
});

app.UseAuthorization();
app.MapControllers();
app.Run();
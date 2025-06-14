using ImageProcessing.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<PluginManager>();
builder.Services.AddSingleton<ImageProcessor>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

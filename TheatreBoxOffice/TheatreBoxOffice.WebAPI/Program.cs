using TheatreBoxOffice.BLL.MappingProfiles;
using TheatreBoxOffice.WebAPI.ConfigExtensions;
using TheatreBoxOffice.WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTheatreBoxOfficeDbContext(builder.Configuration);
builder.Services.AddServices();
builder.Services.AddJwtTokenAuth(builder.Configuration);
builder.Services.AddAuthorization();
builder.Services.AddAuthorization();

builder.Services.AddAutoMapper(typeof(PerformanceProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.InitializeDatabase();
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

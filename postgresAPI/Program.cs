using postgresAPI.Data;
using postgresAPI.Services.HealthCareABApi.Services;

var builder = WebApplication.CreateBuilder(args);

// --------POSTGRES----------
// Configure PostgreSQL with Entity Framework Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Since UserService now depends on ApplicationDbContext, which is registered as scoped,
// you should also register UserService as scoped
builder.Services.AddScoped<UserService>();

// -------------------


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();


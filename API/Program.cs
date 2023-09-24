using Moulding.Application;
using Moulding.Infrastructure.MouldCardRepository;
using Moulding.Infrastructure.MouldingMachineClient;
using Moulding.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAuditService, AuditService>();
builder.Services.AddScoped<IMouldCardService, MouldCardService>();
builder.Services.AddScoped<IMouldingMachineClient, MouldingMachineClient>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddSingleton<IMouldCardRepository, MouldCardRepository>();

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

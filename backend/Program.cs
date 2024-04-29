var builder = WebApplication.CreateBuilder(args);

const string allowSpecificOriginsPolicy = "_allOrigins";
// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(allowSpecificOriginsPolicy,
        buiid =>
        {
            buiid.WithOrigins("http://localhost:4000")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }
//
// app.UseHttpsRedirection();

app.UseCors(allowSpecificOriginsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();